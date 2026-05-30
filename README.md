# 🚀 AspNetCore10 Backend Boilerplate

A production-ready, clean architecture **ASP.NET Core** backend template built with **.NET 10** and **EF Core 8**. Designed to be a solid starting point for any enterprise-level API, including security, authentication with Refresh Tokens, role-based access control, audit logging, and modern API documentation.

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![EF Core](https://img.shields.io/badge/EF%20Core-8.0-512BD4?style=for-the-badge&logo=dotnet)](https://docs.microsoft.com/ef/core/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-2019+-CC2927?style=for-the-badge&logo=microsoftsqlserver)](https://www.microsoft.com/sql-server)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge)](LICENSE)

---

## ✨ Features

| Feature | Details |
|---|---|
| 🏗️ **Clean Architecture** | Dominio, Aplicacion, Infraestructura, WebServices |
| 🔐 **JWT Authentication** | Access Token + Refresh Token |
| 🔒 **BCrypt Password Hashing** | Secure, salted hashing with `BCrypt.Net-Next` |
| 👥 **Role-Based Access Control** | Fine-grained screen/action permissions per role |
| 🗃️ **EF Core Migrations** | Code-first database schema with migration support |
| 📋 **Audit Log** | Full transaction logging for all entity changes |
| 🗺️ **AutoMapper 16** | Modern object mapping configuration |
| 📖 **Scalar API Docs** | Modern OpenAPI 3.1 UI (replaces Swagger) |
| ⚡ **DataSeeder** | Automatic seeding of default roles and permissions |
| 🌐 **CORS** | Pre-configured for frontend integration |
| 🛡️ **Global Exception Middleware** | Centralized error handling |

---

## 🏛️ Architecture

The solution follows **Clean Architecture** principles, organized into four layers:

```
📦 TemplateBackEndNetCore
 ├── 📂 Dominio           → Entities, domain contracts, value objects
 ├── 📂 Aplicacion        → Use cases, DTOs, application services
 ├── 📂 Infraestructura   → EF Core, repositories, JWT, migrations
 ├── 📂 WebServices       → ASP.NET Core API, controllers, middleware
 └── 📂 CrossCutting      → Shared utilities (config, helpers)
```

---

## 🔑 Authentication Flow

### Login
```
POST /api/User/login
```
Returns an **Access Token** (short-lived) and a **Refresh Token** (long-lived). Only a SHA-256 hash of the refresh token is stored in DB.

### Refresh Token
```
POST /api/User/refresh-token
```
Exchange an expired Access Token + Refresh Token for a new pair, without re-entering credentials.

---

## 📋 API Endpoints

### 🔓 Public
| Method | Route | Description |
|---|---|---|
| `POST` | `/api/User/login` | Authenticate and get tokens |
| `POST` | `/api/User/refresh-token` | Renew tokens |

### 🔒 Protected (requires JWT Bearer token)
| Method | Route | Description |
|---|---|---|
| `POST` | `/api/User/crear-usuario` | Create a new user |
| `POST` | `/api/User/editar-usuario` | Edit an existing user |
| `POST` | `/api/User/obtener-usuarios` | Paginated user list |
| `GET`  | `/api/User/obtener-roles` | List all roles |
| `POST` | `/api/User/crear-rol` | Create a new role |
| `POST` | `/api/User/editar-rol` | Edit a role |
| `GET`  | `/api/User/obtener-pantalla` | List all screens |
| `POST` | `/api/User/edicion-permisos` | Assign permissions to a role |

---

## 🗃️ Database

The project uses **SQL Server** with **EF Core Code-First Migrations**.

### Schemas
- `Seguridad` — Users, Roles, Permissions, Screens
- `Comunes` — Configurations, Transaction Logs

### Apply Migrations
```bash
dotnet ef database update --context MyContext --project Infraestructura --startup-project WebServices
```

### Default Seed Data
On first run, the `DataSeeder` automatically creates base security data. The admin user is only created when `Seed:AdminPassword` is configured.

| Type | Value |
|---|---|
| **Optional Admin User** | `admin` with password from `Seed:AdminPassword` |
| **Roles** | `Admin`, `User` |
| **Screen** | `Seguridad` |
| **Permission** | Admin → Seguridad (Ver, Editar, Eliminar) |

---

## ⚙️ Configuration

### `appsettings.json`
```json
{
  "ConnectionStrings": {
    "conectionDataBase": "Server=YOUR_SERVER;Database=YOUR_DB;Encrypt=True;TrustServerCertificate=False"
  },
  "JwtSettings": {
    "Secret": "YOUR_SUPER_SECRET_KEY_MIN_32_CHARS",
    "ExpirationInMinutes": 60,
    "RefreshTokenExpirationInDays": 7,
    "Issuer": "YourIssuer",
    "Audience": "YourAudience"
  },
  "Cors": {
    "AllowedOrigins": [ "https://your-frontend.example.com" ]
  }
}
```

Prefer environment variables or a secret manager for production secrets:

```bash
JwtSettings__Secret=YOUR_SUPER_SECRET_KEY_MIN_32_BYTES
ConnectionStrings__conectionDataBase=Server=YOUR_SERVER;Database=YOUR_DB;User Id=YOUR_USER;Password=YOUR_PASS;Encrypt=True;TrustServerCertificate=False
Seed__AdminPassword=CHANGE_ME_ONLY_FOR_INITIAL_SEED
Cors__AllowedOrigins__0=https://your-frontend.example.com
```

---

## 🚀 Getting Started

### Prerequisites
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- SQL Server 2019+ (or LocalDB for development)

### Setup

```bash
# 1. Clone the repository
git clone https://github.com/Alex16leiva/AspNetCore10-Backend-Boilerplate.git
cd AspNetCore10-Backend-Boilerplate

# 2. Configure your connection string, JWT secret, and CORS origins using environment variables or Secret Manager

# 3. Apply EF Core migrations
dotnet ef database update --context MyContext --project Infraestructura --startup-project WebServices

# 4. Run the API
cd WebServices
dotnet run
```

### API Documentation
Once running, open your browser at:
```
https://localhost:7217/scalar/v1
```

---

## 🛡️ Security Highlights

- ✅ **BCrypt** — Password hashing with automatic salt (replaces plain SHA-256)
- ✅ **JWT Bearer** — Stateless authentication
- ✅ **Refresh Token Rotation** — New refresh token issued on every renewal
- ✅ **Hashed Refresh Tokens** — Database stores token hashes, not raw refresh tokens
- ✅ **Refresh Token Expiry** — Configurable expiration (default: 7 days)
- ✅ **Auth Rate Limiting** — Login and refresh endpoints are rate-limited
- ✅ **Secure Dependencies** — All NuGet packages audited for known vulnerabilities

---

## 📦 Key Packages

| Package | Version | Purpose |
|---|---|---|
| `Microsoft.AspNetCore.OpenApi` | 10.0.x | Native OpenAPI 3.1 generation |
| `Scalar.AspNetCore` | 2.x | Modern API documentation UI |
| `Microsoft.EntityFrameworkCore.SqlServer` | 8.x | ORM + SQL Server provider |
| `AutoMapper` | 16.x | Object-object mapping |
| `BCrypt.Net-Next` | Latest | Secure password hashing |
| `Microsoft.AspNetCore.Authentication.JwtBearer` | 8.x | JWT middleware |

---

## 📄 License

This project is licensed under the **MIT License** — free to use, modify, and distribute.

---

<div align="center">
  Made with ❤️ by <a href="https://github.com/Alex16leiva">Alex16leiva</a>
</div>
