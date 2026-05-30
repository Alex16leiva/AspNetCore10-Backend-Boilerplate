using Dominio.Core.Jwtoken;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace WebServices.Jwtoken
{
    public static class JwtConfiguration
    {
        public static void ConfigureJwt(this WebApplicationBuilder builder)
        {
            builder.Services.Configure<JwtSettings>(options => builder.Configuration.GetSection("JwtSettings").Bind(options));

            AddAuthenticationJwt(builder.Services, builder.Configuration);
        }

        private static void AddAuthenticationJwt(IServiceCollection services, IConfiguration configuration)
        {
            var settings = configuration.GetSection("JwtSettings").Get<JwtSettings>()
                ?? throw new InvalidOperationException("JwtSettings section is missing.");

            var secret = settings.Secret;
            if (string.IsNullOrWhiteSpace(secret) || secret == "CHANGE_ME_TO_A_STRONG_SECRET")
            {
                throw new InvalidOperationException("JwtSettings:Secret must be configured in production using an environment variable or a secret manager.");
            }

            if (Encoding.UTF8.GetByteCount(secret) < 32)
            {
                throw new InvalidOperationException("JwtSettings:Secret must be at least 32 bytes long.");
            }

            if (string.IsNullOrWhiteSpace(settings.Issuer) || string.IsNullOrWhiteSpace(settings.Audience))
            {
                throw new InvalidOperationException("JwtSettings:Issuer and JwtSettings:Audience must be configured.");
            }

            if (settings.ExpirationInMinutes <= 0 || settings.RefreshTokenExpirationInDays <= 0)
            {
                throw new InvalidOperationException("JwtSettings expiration values must be greater than zero.");
            }

            var key = Encoding.UTF8.GetBytes(secret);

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = true;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    ValidateIssuer = true,
                    ValidIssuer = settings.Issuer,
                    ValidateAudience = true,
                    ValidAudience = settings.Audience,
                };
            });
        }
    }
}
