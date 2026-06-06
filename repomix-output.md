This file is a merged representation of the entire codebase, combined into a single document by Repomix.

# File Summary

## Purpose
This file contains a packed representation of the entire repository's contents.
It is designed to be easily consumable by AI systems for analysis, code review,
or other automated processes.

## File Format
The content is organized as follows:
1. This summary section
2. Repository information
3. Directory structure
4. Repository files (if enabled)
5. Multiple file entries, each consisting of:
  a. A header with the file path (## File: path/to/file)
  b. The full contents of the file in a code block

## Usage Guidelines
- This file should be treated as read-only. Any changes should be made to the
  original repository files, not this packed version.
- When processing this file, use the file path to distinguish
  between different files in the repository.
- Be aware that this file may contain sensitive information. Handle it with
  the same level of security as you would the original repository.

## Notes
- Some files may have been excluded based on .gitignore rules and Repomix's configuration
- Binary files are not included in this packed representation. Please refer to the Repository Structure section for a complete list of file paths, including binary files
- Files matching patterns in .gitignore are excluded
- Files matching default ignore patterns are excluded
- Files are sorted by Git change count (files with more changes are at the bottom)

# Directory Structure
```
.gitattributes
.gitignore
Aplicacion/Aplicacion.csproj
Aplicacion/Core/AutoMapperProfile.cs
Aplicacion/Core/BaseDisposable.cs
Aplicacion/DTOs/ConfiguracionesDTO/ConfiguracionesDetalleDTO.cs
Aplicacion/DTOs/ConfiguracionesDTO/ConfiguracionesDTO.cs
Aplicacion/DTOs/ConfiguracionesDTO/ConfiguracionesRequest.cs
Aplicacion/DTOs/QueryInfo.cs
Aplicacion/DTOs/RequestBase.cs
Aplicacion/DTOs/RequestUserInfo.cs
Aplicacion/DTOs/ResponseBase.cs
Aplicacion/DTOs/SearchResult.cs
Aplicacion/DTOs/Seguridad/PantallaDTO.cs
Aplicacion/DTOs/Seguridad/PermisosDTO.cs
Aplicacion/DTOs/Seguridad/RolDTO.cs
Aplicacion/DTOs/Seguridad/TokenRequest.cs
Aplicacion/DTOs/Seguridad/UserRequest.cs
Aplicacion/DTOs/Seguridad/UsuarioDTO.cs
Aplicacion/Helpers/DynamicFilterFactory.cs
Aplicacion/Helpers/TransactionInfoExtensions.cs
Aplicacion/Helpers/TransactionInfoHelper.cs
Aplicacion/Services/ConfiguracionesApp/ConfiguracionesApplicationService.cs
Aplicacion/Services/ConfiguracionesApp/IConfiguracionesApplicationService.cs
Aplicacion/Services/Seguridad/Examples/ResultPatternExamples.cs
Aplicacion/Services/Seguridad/ISecurityApplicationService.cs
Aplicacion/Services/Seguridad/SecurityAplicationService.cs
Aplicacion/Services/Seguridad/Validators/EdicionUsuarioRequestValidator.cs
Aplicacion/Services/Seguridad/Validators/TokenRequestValidator.cs
Aplicacion/Services/Seguridad/Validators/UserRequestValidator.cs
Aplicacion/Services/Seguridad/Validators/UsuarioDTOValidator.cs
CrossCutting/Configuration/AppSettingsException.cs
CrossCutting/Configuration/AppSettingsManager.cs
CrossCutting/CrossCutting.csproj
Dominio/Context/Entidades/ConfiguracionesAgg/Configuraciones.cs
Dominio/Context/Entidades/ConfiguracionesAgg/ConfiguracionesDetalle.cs
Dominio/Context/Entidades/PasswordEncryptor.cs
Dominio/Context/Entidades/Seguridad/Pantalla.cs
Dominio/Context/Entidades/Seguridad/Permisos.cs
Dominio/Context/Entidades/Seguridad/Rol.cs
Dominio/Context/Entidades/Seguridad/Usuario.cs
Dominio/Core/DynamicFilter.cs
Dominio/Core/Entity.cs
Dominio/Core/Extensions/DateTimeExtensions.cs
Dominio/Core/Extensions/DomainListExtensions.cs
Dominio/Core/Extensions/EntidadExtension.cs
Dominio/Core/Extensions/EnumerableExtensions.cs
Dominio/Core/Extensions/ListExtensions.cs
Dominio/Core/Extensions/NumericExtensions.cs
Dominio/Core/Extensions/ReflectionManager.cs
Dominio/Core/Extensions/StringExtensions.cs
Dominio/Core/Jwtoken/JwtSettings.cs
Dominio/Core/PagedCollection.cs
Dominio/Core/Result/IResult.cs
Dominio/Core/Result/Result.cs
Dominio/Core/Result/Result{T}.cs
Dominio/Core/TransactionInfo.cs
Dominio/Dominio.csproj
EstructuraBaseDatos.txt
Infraestructura/Context/DataSeeder.cs
Infraestructura/Context/GenericRepository.cs
Infraestructura/Context/IDataContext.cs
Infraestructura/Context/IGenericRepository.cs
Infraestructura/Context/Mapping/ConfiguracionesMap/ConfiguracionesDetalleMap.cs
Infraestructura/Context/Mapping/ConfiguracionesMap/ConfiguracionesMap.cs
Infraestructura/Context/Mapping/EntityMap.cs
Infraestructura/Context/Mapping/Seguridad/PantallaMap.cs
Infraestructura/Context/Mapping/Seguridad/PermisosMap.cs
Infraestructura/Context/Mapping/Seguridad/RolMap.cs
Infraestructura/Context/Mapping/Seguridad/UsuarioMap.cs
Infraestructura/Context/MyContext.cs
Infraestructura/Core/BCUnitOfWork.cs
Infraestructura/Core/DynamicQueryable.cs
Infraestructura/Core/EntityMapping.cs
Infraestructura/Core/Exception/ThrowIf.cs
Infraestructura/Core/Identity/TransactionIdentity.cs
Infraestructura/Core/IQueryableUnitOfWork.cs
Infraestructura/Core/IUnitOfWork.cs
Infraestructura/Core/Jwtoken/ITokenService.cs
Infraestructura/Core/Jwtoken/JwtTokenService.cs
Infraestructura/Core/Logging/Transaction.cs
Infraestructura/Core/Logging/TransactionDetail.cs
Infraestructura/Core/ModifiedEntityEntry.cs
Infraestructura/Core/RestClient/HttpRestClient.cs
Infraestructura/Core/RestClient/HttpRestClientFactory.cs
Infraestructura/Core/RestClient/IRestClient.cs
Infraestructura/Core/RestClient/IRestClientFactory.cs
Infraestructura/Core/RestClient/QueryStringBuilder.cs
Infraestructura/Core/RestClient/RestClientFactory.cs
Infraestructura/Core/SqlCommandInfo.cs
Infraestructura/Core/TransactionScopeFactory.cs
Infraestructura/Infraestructura.csproj
Infraestructura/Migrations/20260529013725_AddRefreshToken.cs
Infraestructura/Migrations/20260529013725_AddRefreshToken.Designer.cs
Infraestructura/Migrations/MyContextModelSnapshot.cs
README.md
RESULT_PATTERN_GUIDE.md
TemplateBackEndNetCore.sln
WebServices/appsettings.Development.json
WebServices/appsettings.json
WebServices/Controllers/ConfiguracionesController.cs
WebServices/Controllers/TestRestClient.cs
WebServices/Controllers/UserController.cs
WebServices/Extensions/DependencyInjectionRepository.cs
WebServices/Jwtoken/JwtConfiguration.cs
WebServices/Middleware/GlobalExceptionHandlingMiddleware.cs
WebServices/Program.cs
WebServices/Properties/launchSettings.json
WebServices/WeatherForecast.cs
WebServices/WebServices.csproj
WebServices/WebServices.http
```

# Files

## File: .gitattributes
````
###############################################################################
# Set default behavior to automatically normalize line endings.
###############################################################################
* text=auto

###############################################################################
# Set default behavior for command prompt diff.
#
# This is need for earlier builds of msysgit that does not have it on by
# default for csharp files.
# Note: This is only used by command line
###############################################################################
#*.cs     diff=csharp

###############################################################################
# Set the merge driver for project and solution files
#
# Merging from the command prompt will add diff markers to the files if there
# are conflicts (Merging from VS is not affected by the settings below, in VS
# the diff markers are never inserted). Diff markers may cause the following 
# file extensions to fail to load in VS. An alternative would be to treat
# these files as binary and thus will always conflict and require user
# intervention with every merge. To do so, just uncomment the entries below
###############################################################################
#*.sln       merge=binary
#*.csproj    merge=binary
#*.vbproj    merge=binary
#*.vcxproj   merge=binary
#*.vcproj    merge=binary
#*.dbproj    merge=binary
#*.fsproj    merge=binary
#*.lsproj    merge=binary
#*.wixproj   merge=binary
#*.modelproj merge=binary
#*.sqlproj   merge=binary
#*.wwaproj   merge=binary

###############################################################################
# behavior for image files
#
# image files are treated as binary by default.
###############################################################################
#*.jpg   binary
#*.png   binary
#*.gif   binary

###############################################################################
# diff behavior for common document formats
# 
# Convert binary document formats to text before diffing them. This feature
# is only available from the command line. Turn it on by uncommenting the 
# entries below.
###############################################################################
#*.doc   diff=astextplain
#*.DOC   diff=astextplain
#*.docx  diff=astextplain
#*.DOCX  diff=astextplain
#*.dot   diff=astextplain
#*.DOT   diff=astextplain
#*.pdf   diff=astextplain
#*.PDF   diff=astextplain
#*.rtf   diff=astextplain
#*.RTF   diff=astextplain
````

## File: .gitignore
````
## Ignore Visual Studio temporary files, build results, and
## files generated by popular Visual Studio add-ons.
##
## Get latest from https://github.com/github/gitignore/blob/master/VisualStudio.gitignore

# User-specific files
*.rsuser
*.suo
*.user
*.userosscache
*.sln.docstates

# User-specific files (MonoDevelop/Xamarin Studio)
*.userprefs

# Mono auto generated files
mono_crash.*

# Build results
[Dd]ebug/
[Dd]ebugPublic/
[Rr]elease/
[Rr]eleases/
x64/
x86/
[Ww][Ii][Nn]32/
[Aa][Rr][Mm]/
[Aa][Rr][Mm]64/
bld/
[Bb]in/
[Oo]bj/
[Oo]ut/
[Ll]og/
[Ll]ogs/

# Visual Studio 2015/2017 cache/options directory
.vs/
# Uncomment if you have tasks that create the project's static files in wwwroot
#wwwroot/

# Visual Studio 2017 auto generated files
Generated\ Files/

# MSTest test Results
[Tt]est[Rr]esult*/
[Bb]uild[Ll]og.*

# NUnit
*.VisualState.xml
TestResult.xml
nunit-*.xml

# Build Results of an ATL Project
[Dd]ebugPS/
[Rr]eleasePS/
dlldata.c

# Benchmark Results
BenchmarkDotNet.Artifacts/

# .NET Core
project.lock.json
project.fragment.lock.json
artifacts/

# ASP.NET Scaffolding
ScaffoldingReadMe.txt

# StyleCop
StyleCopReport.xml

# Files built by Visual Studio
*_i.c
*_p.c
*_h.h
*.ilk
*.meta
*.obj
*.iobj
*.pch
*.pdb
*.ipdb
*.pgc
*.pgd
*.rsp
*.sbr
*.tlb
*.tli
*.tlh
*.tmp
*.tmp_proj
*_wpftmp.csproj
*.log
*.vspscc
*.vssscc
.builds
*.pidb
*.svclog
*.scc

# Chutzpah Test files
_Chutzpah*

# Visual C++ cache files
ipch/
*.aps
*.ncb
*.opendb
*.opensdf
*.sdf
*.cachefile
*.VC.db
*.VC.VC.opendb

# Visual Studio profiler
*.psess
*.vsp
*.vspx
*.sap

# Visual Studio Trace Files
*.e2e

# TFS 2012 Local Workspace
$tf/

# Guidance Automation Toolkit
*.gpState

# ReSharper is a .NET coding add-in
_ReSharper*/
*.[Rr]e[Ss]harper
*.DotSettings.user

# TeamCity is a build add-in
_TeamCity*

# DotCover is a Code Coverage Tool
*.dotCover

# AxoCover is a Code Coverage Tool
.axoCover/*
!.axoCover/settings.json

# Coverlet is a free, cross platform Code Coverage Tool
coverage*.json
coverage*.xml
coverage*.info

# Visual Studio code coverage results
*.coverage
*.coveragexml

# NCrunch
_NCrunch_*
.*crunch*.local.xml
nCrunchTemp_*

# MightyMoose
*.mm.*
AutoTest.Net/

# Web workbench (sass)
.sass-cache/

# Installshield output folder
[Ee]xpress/

# DocProject is a documentation generator add-in
DocProject/buildhelp/
DocProject/Help/*.HxT
DocProject/Help/*.HxC
DocProject/Help/*.hhc
DocProject/Help/*.hhk
DocProject/Help/*.hhp
DocProject/Help/Html2
DocProject/Help/html

# Click-Once directory
publish/

# Publish Web Output
*.[Pp]ublish.xml
*.azurePubxml
# Note: Comment the next line if you want to checkin your web deploy settings,
# but database connection strings (with potential passwords) will be unencrypted
*.pubxml
*.publishproj

# Microsoft Azure Web App publish settings. Comment the next line if you want to
# checkin your Azure Web App publish settings, but sensitive information contained
# in these scripts will be unencrypted
PublishScripts/

# NuGet Packages
*.nupkg
# NuGet Symbol Packages
*.snupkg
# The packages folder can be ignored because of Package Restore
**/[Pp]ackages/*
# except build/, which is used as an MSBuild target.
!**/[Pp]ackages/build/
# Uncomment if necessary however generally it will be regenerated when needed
#!**/[Pp]ackages/repositories.config
# NuGet v3's project.json files produces more ignorable files
*.nuget.props
*.nuget.targets

# Microsoft Azure Build Output
csx/
*.build.csdef

# Microsoft Azure Emulator
ecf/
rcf/

# Windows Store app package directories and files
AppPackages/
BundleArtifacts/
Package.StoreAssociation.xml
_pkginfo.txt
*.appx
*.appxbundle
*.appxupload

# Visual Studio cache files
# files ending in .cache can be ignored
*.[Cc]ache
# but keep track of directories ending in .cache
!?*.[Cc]ache/

# Others
ClientBin/
~$*
*~
*.dbmdl
*.dbproj.schemaview
*.jfm
*.pfx
*.publishsettings
orleans.codegen.cs

# Including strong name files can present a security risk
# (https://github.com/github/gitignore/pull/2483#issue-259490424)
#*.snk

# Since there are multiple workflows, uncomment next line to ignore bower_components
# (https://github.com/github/gitignore/pull/1529#issuecomment-104372622)
#bower_components/

# RIA/Silverlight projects
Generated_Code/

# Backup & report files from converting an old project file
# to a newer Visual Studio version. Backup files are not needed,
# because we have git ;-)
_UpgradeReport_Files/
Backup*/
UpgradeLog*.XML
UpgradeLog*.htm
ServiceFabricBackup/
*.rptproj.bak

# SQL Server files
*.mdf
*.ldf
*.ndf

# Business Intelligence projects
*.rdl.data
*.bim.layout
*.bim_*.settings
*.rptproj.rsuser
*- [Bb]ackup.rdl
*- [Bb]ackup ([0-9]).rdl
*- [Bb]ackup ([0-9][0-9]).rdl

# Microsoft Fakes
FakesAssemblies/

# GhostDoc plugin setting file
*.GhostDoc.xml

# Node.js Tools for Visual Studio
.ntvs_analysis.dat
node_modules/

# Visual Studio 6 build log
*.plg

# Visual Studio 6 workspace options file
*.opt

# Visual Studio 6 auto-generated workspace file (contains which files were open etc.)
*.vbw

# Visual Studio LightSwitch build output
**/*.HTMLClient/GeneratedArtifacts
**/*.DesktopClient/GeneratedArtifacts
**/*.DesktopClient/ModelManifest.xml
**/*.Server/GeneratedArtifacts
**/*.Server/ModelManifest.xml
_Pvt_Extensions

# Paket dependency manager
.paket/paket.exe
paket-files/

# FAKE - F# Make
.fake/

# CodeRush personal settings
.cr/personal

# Python Tools for Visual Studio (PTVS)
__pycache__/
*.pyc

# Cake - Uncomment if you are using it
# tools/**
# !tools/packages.config

# Tabs Studio
*.tss

# Telerik's JustMock configuration file
*.jmconfig

# BizTalk build output
*.btp.cs
*.btm.cs
*.odx.cs
*.xsd.cs

# OpenCover UI analysis results
OpenCover/

# Azure Stream Analytics local run output
ASALocalRun/

# MSBuild Binary and Structured Log
*.binlog

# NVidia Nsight GPU debugger configuration file
*.nvuser

# MFractors (Xamarin productivity tool) working folder
.mfractor/

# Local History for Visual Studio
.localhistory/

# BeatPulse healthcheck temp database
healthchecksdb

# Backup folder for Package Reference Convert tool in Visual Studio 2017
MigrationBackup/

# Ionide (cross platform F# VS Code tools) working folder
.ionide/

# Fody - auto-generated XML schema
FodyWeavers.xsd
````

## File: Aplicacion/Core/AutoMapperProfile.cs
````csharp
using Aplicacion.DTOs.Seguridad;
using AutoMapper;
using Dominio.Context.Entidades.Seguridad;

namespace Aplicacion.Core
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Usuario, UsuarioDTO>();
        }
    }
}
````

## File: Aplicacion/Core/BaseDisposable.cs
````csharp
namespace Aplicacion.Core
{
    public class BaseDisposable : IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) 
        { 
            if (disposing)
            {
                //free other states (managed objects).
            }
            //free your own state (unmanaged objects).
            //Set large fields to null.
        }

        ~BaseDisposable()
        {
            Dispose(false);
        }
    }
}
````

## File: Aplicacion/DTOs/ConfiguracionesDTO/ConfiguracionesDetalleDTO.cs
````csharp
namespace Aplicacion.DTOs.ConfiguracionesDTO
{
    public class ConfiguracionesDetalleDTO : ResponseBase
    {
        public string? ConfiguracionId { get; set; }
        public string? Atributo { get; set; }
        public string? Valor { get; set; }
        public string? Descripcion { get; set; }
    }
}
````

## File: Aplicacion/DTOs/ConfiguracionesDTO/ConfiguracionesDTO.cs
````csharp
namespace Aplicacion.DTOs.ConfiguracionesDTO
{
    public class ConfiguracionesDTO : ResponseBase
    {
        public required string ConfiguracionId { get; set; }
        public required string Descripcion { get; set; }
        public List<ConfiguracionesDetalleDTO> ConfiguracionesDetalle { get; set; }
    }
}
````

## File: Aplicacion/DTOs/ConfiguracionesDTO/ConfiguracionesRequest.cs
````csharp
namespace Aplicacion.DTOs.ConfiguracionesDTO
{
    public class ConfiguracionesRequest : RequestBase
    {
        public ConfiguracionesDTO? Configuraciones { get; set; }
        public ConfiguracionesDetalleDTO? ConfiguracionesDetalle { get; set; }
    }
}
````

## File: Aplicacion/DTOs/SearchResult.cs
````csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.DTOs
{
    public class SearchResult<T> where T : class
    {
        public int PageIndex { get; set; }
        public int PageCount { get; set; }
        public int? TotalItems { get; set; }
        public int? ItemCount { get; set; }
        public List<T>? Items { get; set; }

        public Dictionary<string, int> GetPagedCollectionAttributes()
        {
            return new Dictionary<string, int> { { "PageCount", PageCount }, { "PageIndex", PageIndex } };
        }

        public string? ValidationErrorMessage { get; set; }
    }
}
````

## File: Aplicacion/DTOs/Seguridad/PantallaDTO.cs
````csharp
namespace Aplicacion.DTOs.Seguridad
{
    public class PantallaDTO : ResponseBase
    {
        public string? PantallaId { get; set; }
        public string? Descripcion { get; set; }
    }
}
````

## File: Aplicacion/DTOs/Seguridad/PermisosDTO.cs
````csharp
namespace Aplicacion.DTOs.Seguridad
{
    public class PermisosDTO : ResponseBase
    {
        public string? RolId { get; set; }
        public string? PantallaId { get; set; }
        public bool Ver { get; set; }
        public bool Editar { get; set; }
        public bool Eliminar { get; set; }
    }
}
````

## File: Aplicacion/DTOs/Seguridad/RolDTO.cs
````csharp
namespace Aplicacion.DTOs.Seguridad
{
    public class RolDTO : ResponseBase
    {
        public string? RolId { get; set; }
        public string? Descripcion { get; set; }
        public List<PermisosDTO>? Permisos { get; set; }
    }
}
````

## File: Aplicacion/Helpers/TransactionInfoExtensions.cs
````csharp
using Aplicacion.DTOs;
using Dominio.Core;

namespace Aplicacion.Helpers
{
    public static class TransactionInfoExtensions
    {
        public static TransactionInfo CrearTransactionInfo(this RequestUserInfo requestUserInfo, string transactionId)
        {
            return TransactionInfoHelper.CrearTransactionInfo(requestUserInfo, transactionId);
        }

        public static TransactionInfo CrearTransactionInfo(this RequestUserInfo requestUserInfo)
        {
            return TransactionInfoHelper.CrearTransactionInfo(requestUserInfo);
        }
    }
}
````

## File: Aplicacion/Helpers/TransactionInfoHelper.cs
````csharp
using Aplicacion.DTOs;
using Dominio.Core;
using Infraestructura.Core.Identity;
using Infraestructura.Core.Logging;

namespace Aplicacion.Helpers
{
    public static class TransactionInfoHelper
    {
        public static void ValidarArgumentosUserInfo(RequestUserInfo userInfoDTO)
        {
            if (userInfoDTO == null) throw new ArgumentNullException("userInfoDTO");
            if (string.IsNullOrWhiteSpace(userInfoDTO.UsuarioId)) throw new ArgumentException("userInfoDTO.UserId");
        }

        public static TransactionInfo CrearTransactionInfo(RequestUserInfo userInfoDTO, string transaccionId)
        {
            //ValidarArgumentosUserInfo(userInfoDTO);

            return new TransactionInfo
            {
                ModificadoPor = userInfoDTO.UsuarioId,
                TipoTransaccion = transaccionId,
            };
        }

        public static TransactionInfo CrearTransactionInfo(RequestUserInfo userInfoDTO)
        {
            ValidarArgumentosUserInfo(userInfoDTO);

            return new TransactionInfo
            {
                ModificadoPor = userInfoDTO.UsuarioId
            };
        }

        public static Guid NewSequentialGuid()
        {
            byte[] uid = Guid.NewGuid().ToByteArray();
            byte[] binDate = BitConverter.GetBytes(DateTime.UtcNow.Ticks);

            var secuentialGuid = new byte[uid.Length];

            secuentialGuid[0] = uid[0];
            secuentialGuid[1] = uid[1];
            secuentialGuid[2] = uid[2];
            secuentialGuid[3] = uid[3];
            secuentialGuid[4] = uid[4];
            secuentialGuid[5] = uid[5];
            secuentialGuid[6] = uid[6];
            // set the first part of the 8th byte to '1100' so
            // later we'll be able to validate it was generated by us

            secuentialGuid[7] = (byte)(0xc0 | (0xf & uid[7]));

            // the last 8 bytes are sequential,
            // it minimizes index fragmentation
            // to a degree as long as there are not a large
            // number of Secuential-Guids generated per millisecond

            secuentialGuid[9] = binDate[0];
            secuentialGuid[8] = binDate[1];
            secuentialGuid[15] = binDate[2];
            secuentialGuid[14] = binDate[3];
            secuentialGuid[13] = binDate[4];
            secuentialGuid[12] = binDate[5];
            secuentialGuid[11] = binDate[6];
            secuentialGuid[10] = binDate[7];

            return new Guid(secuentialGuid);
        }


        public static TransactionIdentity NewSequentialTransactionIdentity()
        {
            return new TransactionIdentity
            {
                TransactionId = NewSequentialGuid(),
                TransactionDate = DateTime.Now,
                TransactionUtcDate = DateTime.UtcNow
            };
        }

        public static Transaction CrearTransactionCompleta(RequestUserInfo requestUserInfo, string transaccionId)
        {
            var transactionInfo = CrearTransactionInfo(requestUserInfo, transaccionId);

            var transactionIdentity = NewSequentialTransactionIdentity();

            return new Transaction
            {
                TransactionId = transactionIdentity.TransactionId,
                TransactionDate = transactionIdentity.TransactionDate,
                TransactionOrigen = transactionInfo.TipoTransaccion,
                TransactionType = transactionInfo.TipoTransaccion,
                ModifiedBy = transactionInfo.ModificadoPor,
            };
        }
    }
}
````

## File: Aplicacion/Services/Seguridad/Examples/ResultPatternExamples.cs
````csharp
using Dominio.Core.Result;

namespace Aplicacion.Services.Seguridad.Examples
{
    /// <summary>
    /// Ejemplos de cómo refactorizar los métodos del SecurityAplicationService
    /// para utilizar el Patrón Result en lugar de retornar DTOs con propiedades de mensaje.
    /// 
    /// Este archivo documenta el patrón y NO debe ser incluido en la compilación final.
    /// Sirve como referencia durante la migración gradual del código.
    /// </summary>
    public class ResultPatternExamples
    {
        /*
        EJEMPLO 1: Método que devuelve éxito o fallo simple
        =====================================================
        
        // ANTES (usando DTO con propiedades de mensaje):
        public UsuarioDTO IniciarSesion(UserRequest request)
        {
            if (usuario.IsNotNull() && PasswordEncryptor.VerifyPassword(request?.Password, usuario.Contrasena))
            {
                return new UsuarioDTO { ... Token = newAccessToken, ... UsuarioAutenticado = true };
            }
            return new UsuarioDTO { Message = "Usuario o Contraseña no valido", UsuarioAutenticado = false };
        }
        
        // DESPUÉS (usando Result<T>):
        public Result<UsuarioDTO> IniciarSesion(UserRequest request)
        {
            if (usuario == null)
            {
                return Result<UsuarioDTO>.Failure("Usuario no encontrado", "USER_NOT_FOUND");
            }
            
            if (!PasswordEncryptor.VerifyPassword(request?.Password, usuario.Contrasena))
            {
                return Result<UsuarioDTO>.Failure("Contraseña incorrecta", "INVALID_PASSWORD");
            }
            
            var usuarioDto = new UsuarioDTO { ... Token = newAccessToken, ... };
            return Result<UsuarioDTO>.Success(usuarioDto, "Sesión iniciada correctamente");
        }
        
        // USO EN CONTROLADOR:
        [HttpPost("login")]
        public IActionResult Login([FromBody] UserRequest request)
        {
            var result = _securityService.IniciarSesion(request);
            
            if (!result.IsSuccess)
            {
                return BadRequest(new { message = result.Message, errorCode = result.ErrorCode });
            }
            
            return Ok(result.Data);
        }
        
        
        EJEMPLO 2: Validación con múltiples errores
        ============================================
        
        public Result<UsuarioDTO> CrearUsuario(EdicionUsuarioRequest request)
        {
            var validationErrors = new List<string>();
            
            if (request.Usuario is null)
            {
                validationErrors.Add("El usuario es obligatorio");
            }
            
            if (string.IsNullOrEmpty(request.Usuario?.UsuarioId))
            {
                validationErrors.Add("El ID de usuario es obligatorio");
            }
            
            if (validationErrors.Any())
            {
                return Result<UsuarioDTO>.ValidationFailure(
                    "Validación fallida",
                    validationErrors,
                    "VALIDATION_ERROR"
                );
            }
            
            var usuarioExiste = _genericRepository.GetSingle<Usuario>(r => r.UsuarioId == request.Usuario.UsuarioId);
            
            if (usuarioExiste.IsNotNull())
            {
                return Result<UsuarioDTO>.Failure("Usuario ya está registrado", "USER_ALREADY_EXISTS");
            }
            
            var usuario = new Usuario { ... };
            _genericRepository.Add(usuario);
            _genericRepository.UnitOfWork.Commit(transactionInfo);
            
            return Result<UsuarioDTO>.Success(
                _mapper.Map<UsuarioDTO>(usuario),
                "Usuario creado exitosamente"
            );
        }
        
        // USO EN CONTROLADOR:
        [HttpPost("create")]
        public IActionResult CreateUser([FromBody] EdicionUsuarioRequest request)
        {
            var result = _securityService.CrearUsuario(request);
            
            if (!result.IsSuccess)
            {
                if (result.Errors.Any())
                {
                    return BadRequest(new 
                    { 
                        message = result.Message,
                        errors = result.Errors.ToList(),
                        errorCode = result.ErrorCode 
                    });
                }
                
                return BadRequest(new { message = result.Message, errorCode = result.ErrorCode });
            }
            
            return Created($"users/{result.Data.UsuarioId}", result.Data);
        }
        
        
        EJEMPLO 3: Encadenamiento con Bind
        ===================================
        
        public Result<PermisosDTO> AsignarPermisos(int usuarioId, List<PermisoRequest> permisos)
        {
            return ObtenerUsuarioVerificado(usuarioId)
                .Bind(usuario => ValidarPermisos(permisos))
                .Bind(permisosValidos => GuardarPermisos(usuarioId, permisosValidos))
                .Map(permisosGuardados => new PermisosDTO { ... });
        }
        
        
        EJEMPLO 4: Transformación con Map
        ==================================
        
        var resultado = _securityService.ObtenerUsuario(userId)
            .Map(usuario => new UsuarioResumenDTO 
            { 
                Id = usuario.UsuarioId,
                NombreCompleto = $"{usuario.Nombre} {usuario.Apellido}"
            });
        
        if (resultado.IsSuccess)
        {
            return Ok(resultado.Data);
        }
        
        return NotFound(new { message = resultado.Message });
        */

        /// <summary>
        /// Ventajas del Patrón Result:
        /// 
        /// 1. Type-safe: El compilador asegura que verificas IsSuccess antes de acceder a Data
        /// 2. Explícito: Los errores son parte del contrato del método
        /// 3. Sin excepciones: Evita el overhead de las excepciones para casos esperados
        /// 4. Composable: Puedes usar Map y Bind para encadenar operaciones
        /// 5. Testeable: Fácil de testear sin necesidad de mocking de excepciones
        /// 6. API consistente: Todos los métodos retornan Result<T>
        /// 
        /// Pasos para migrar el código actual:
        /// 
        /// 1. Cambiar tipos de retorno de métodos:
        ///    UsuarioDTO IniciarSesion(...) → Result<UsuarioDTO> IniciarSesion(...)
        ///
        /// 2. Reemplazar retornos con message por Result.Success() o Result.Failure():
        ///    return new UsuarioDTO { Message = "Error" } → Result<UsuarioDTO>.Failure("Error")
        ///
        /// 3. Actualizar controladores para revisar IsSuccess y acceder a Data:
        ///    var usuario = dto; → var result = service.Method(); if (result.IsSuccess) { var usuario = result.Data; }
        ///
        /// 4. Manejar errores de validación con ValidationFailure()
        ///
        /// 5. Usar Map para transformaciones simples
        /// 6. Usar Bind para operaciones que devuelven otro Result
        /// </summary>
        public class MigrationGuide { }
    }
}
````

## File: Aplicacion/Services/Seguridad/Validators/EdicionUsuarioRequestValidator.cs
````csharp
using Aplicacion.DTOs.Seguridad;
using FluentValidation;

namespace Aplicacion.Services.Seguridad.Validators
{
    public class EdicionUsuarioRequestValidator : AbstractValidator<EdicionUsuarioRequest>
    {
        public EdicionUsuarioRequestValidator()
        {
            RuleFor(x => x.Usuario).NotNull().WithMessage("Usuario es requerido").SetValidator(new UsuarioDTOValidator());
        }
    }
}
````

## File: Aplicacion/Services/Seguridad/Validators/TokenRequestValidator.cs
````csharp
using Aplicacion.DTOs.Seguridad;
using FluentValidation;

namespace Aplicacion.Services.Seguridad.Validators
{
    public class TokenRequestValidator : AbstractValidator<TokenRequest>
    {
        public TokenRequestValidator()
        {
            RuleFor(x => x.AccessToken).NotEmpty().WithMessage("AccessToken es requerido");
            RuleFor(x => x.RefreshToken).NotEmpty().WithMessage("RefreshToken es requerido");
        }
    }
}
````

## File: Aplicacion/Services/Seguridad/Validators/UserRequestValidator.cs
````csharp
using Aplicacion.DTOs.Seguridad;
using FluentValidation;

namespace Aplicacion.Services.Seguridad.Validators
{
    public class UserRequestValidator : AbstractValidator<UserRequest>
    {
        public UserRequestValidator()
        {
            RuleFor(x => x.UsuarioId).NotEmpty().WithMessage("UsuarioId es requerido").MaximumLength(25);
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password es requerido").MinimumLength(8);
        }
    }
}
````

## File: Aplicacion/Services/Seguridad/Validators/UsuarioDTOValidator.cs
````csharp
using Aplicacion.DTOs.Seguridad;
using FluentValidation;

namespace Aplicacion.Services.Seguridad.Validators
{
    public class UsuarioDTOValidator : AbstractValidator<UsuarioDTO>
    {
        public UsuarioDTOValidator()
        {
            RuleFor(x => x.UsuarioId).NotEmpty().WithMessage("UsuarioId es requerido").MaximumLength(25);
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("Nombre es requerido");
            RuleFor(x => x.Apellido).NotEmpty().WithMessage("Apellido es requerido");
            RuleFor(x => x.RolId).NotEmpty().WithMessage("RolId es requerido");
            RuleFor(x => x.Contrasena)
                .MinimumLength(8).WithMessage("La contraseña debe tener al menos 8 caracteres")
                .When(x => x.EditarContrasena);
        }
    }
}
````

## File: CrossCutting/Configuration/AppSettingsException.cs
````csharp
namespace CrossCutting.Configuration
{
    /// <summary>
    /// Excepción neutra de dominio que encapsula errores de configuración
    /// sin filtrar detalles de infraestructura hacia las capas superiores.
    /// </summary>
    public sealed class AppSettingsException : Exception
    {
        public AppSettingsException(string message) : base(message) { }
        public AppSettingsException(string message, Exception inner) : base(message, inner) { }
    }
}
````

## File: Dominio/Context/Entidades/ConfiguracionesAgg/Configuraciones.cs
````csharp
using Dominio.Core;

namespace Dominio.Context.Entidades.ConfiguracionesAgg
{
    public class Configuraciones : Entity
    {
        public required string ConfiguracionId { get; set; }
        public required string Descripcion { get; set; }
        public virtual ICollection<ConfiguracionesDetalle>? ConfiguracionesDetalle { get; set; }
    }
}
````

## File: Dominio/Context/Entidades/ConfiguracionesAgg/ConfiguracionesDetalle.cs
````csharp
using Dominio.Core;

namespace Dominio.Context.Entidades.ConfiguracionesAgg
{
    public class ConfiguracionesDetalle : Entity
    {
        public required string ConfiguracionId { get; set; }
        public required string Atributo { get; set; }
        public required string Valor { get; set; }
        public required string Descripcion { get; set; }
        public virtual Configuraciones? Configuraciones { get; set; }
    }
}
````

## File: Dominio/Context/Entidades/Seguridad/Pantalla.cs
````csharp
using Dominio.Core;

namespace Dominio.Context.Entidades.Seguridad
{
    public class Pantalla : Entity
    {
        public required string PantallaId { get; set; }
        public required string Descripcion { get; set; }
    }
}
````

## File: Dominio/Context/Entidades/Seguridad/Permisos.cs
````csharp
using Dominio.Core;

namespace Dominio.Context.Entidades.Seguridad
{
    public class Permisos : Entity
    {
        public required string RolId { get; set; }
        public required string PantallaId { get; set; }
        public required bool Ver { get; set; }
        public required bool Editar { get; set; }
        public required bool Eliminar { get; set; }

        public virtual Rol? Rol { get; set; }
    }
}
````

## File: Dominio/Core/PagedCollection.cs
````csharp
using System.Collections;

namespace Dominio.Core
{
    public sealed class PagedCollection
    {
        /// <summary>
        /// Create a new entities paginated set.
        /// </summary>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="pageSize">The page size.</param>
        /// <param name="entities">The entities in the page.</param>
        /// <param name="totalItems">Total items avaibale.</param>
        /// <param name="count">The total amount of entities in the page.</param>
        public PagedCollection(int pageIndex, int pageSize, IEnumerable entities, int totalItems, int count)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            Items = entities;
            TotalItems = totalItems;
            ItemCount = count;
            PageCount = pageSize > 0 ? (int)Math.Ceiling(totalItems / (decimal)pageSize) : 0;
        }

        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public IEnumerable Items { get; private set; }
        public int TotalItems { get; private set; }
        public int PageCount { get; private set; }
        public int ItemCount { get; private set; }
    }
}
````

## File: Dominio/Core/TransactionInfo.cs
````csharp
namespace Dominio.Core
{
    public class TransactionInfo : Entity
    {
        public bool GenerateTransaction { get; set; }
    }
}
````

## File: Infraestructura/Context/IDataContext.cs
````csharp
using Infraestructura.Core;

namespace Infraestructura.Context
{
    public interface IDataContext : IQueryableUnitOfWork
    {
    }
}
````

## File: Infraestructura/Context/IGenericRepository.cs
````csharp
using Dominio.Core;
using Infraestructura.Core;
using Microsoft.Data.SqlClient;
using System.Linq.Expressions;

namespace Infraestructura.Context
{
    public interface IGenericRepository<T> : IDisposable
        where T : IQueryableUnitOfWork
    {
        /// <summary>
        /// Get the unit of work in this repository.
        /// </summary>
        IUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// Add the entity to the repository.
        /// </summary>
        /// <typeparam name="TEntity">The entity type.</typeparam>
        /// <param name="entity">the new entity to add.</param>
        void Add<TEntity>(TEntity entity)
            where TEntity : Entity;

        /// <summary>
        /// Add the entity to the repository.
        /// </summary>
        /// <typeparam name="TEntity">The entity type</typeparam>
        /// <param name="entity">The new entity to add</param>
        /// <returns></returns>
        Task AddAsync<TEntity>(TEntity entity)
            where TEntity : Entity;

        /// <summary>
        /// Add the entities to the repository
        /// </summary>
        /// <typeparam name="TEntity">the entity type</typeparam>
        /// <param name="entities">The new entities to add</param>
        void AddRange<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : Entity;

        /// <summary>
        /// Add the entities to the repository.
        /// </summary>
        /// <typeparam name="TEntity">The entity type</typeparam>
        /// <param name="entities">The new entities to add</param>
        /// <returns></returns>
        Task AddRangeAsync<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : Entity;

        /// <summary>
        /// Remove the specified entity
        /// </summary>
        /// <typeparam name="TEntity">The entity type</typeparam>
        /// <param name="entity">The entity to remove</param>
        void Remove<TEntity>(TEntity entity) 
            where TEntity : Entity;

        /// <summary>
        /// Remove the specified from the repository
        /// </summary>
        /// <typeparam name="TEntity">The entity type</typeparam>
        /// <param name="entities">The entities to remove</param>
        void RemoveRange<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : Entity;

        /// <summary>
        /// Get All rows.
        /// </summary>
        /// <typeparam name="TEntity">The entity type</typeparam>
        /// <returns>{List{`0}}</returns>
        IEnumerable<TEntity> GetAll<TEntity>() 
            where TEntity : Entity;

        /// <summary>
        /// Get all row asynchronously.
        /// </summary>
        /// <typeparam name="TEntity">The entity type</typeparam>
        /// <returns>Task{List{`0}}</returns>
        Task<IEnumerable<TEntity>> GetAllAsync<TEntity>() 
            where TEntity : Entity;

        /// <summary>
        /// Get All rows.
        /// </summary>
        /// <typeparam name="TEntity">The entity type</typeparam>
        /// <param name="includes">Related entities to include in the result set</param>
        /// <returns>List{`0}</returns>
        IEnumerable<TEntity> GetAll<TEntity>(List<string> includes) 
            where TEntity : Entity;

        /// <summary>
        /// Get All rows asynchronously
        /// </summary>
        /// <typeparam name="TEntity">The entity type</typeparam>
        /// <param name="includes">Related entities to include in the result set</param>
        /// <returns>Task{List{`0}}</returns>
        Task<IEnumerable<TEntity>> GetAllAsync<TEntity>(List<string> includes)
            where TEntity : Entity;

        /// <summary>
        /// Get the first or default row filtered by the query expression.
        /// </summary>
        /// <typeparam name="TEntity">The entity type</typeparam>
        /// <param name="predicate">The where (the qyery expression)</param>
        /// <returns>Object of the TEntity class</returns>
        TEntity GetSingle<TEntity>(Expression<Func<TEntity, bool>> predicate) 
            where TEntity : Entity;

        /// <summary>
        /// Get the first or default row filtered by the query expression.
        /// </summary>
        /// <typeparam name="TEntity">The entity type</typeparam>
        /// <param name="predicate">The where (the query expression)</param>
        /// <returns>Object of the TEntity class</returns>
        Task<TEntity> GetSingleAsync<TEntity>(Expression<Func<TEntity, bool>> predicate)
            where TEntity : Entity;

        /// <summary>
        /// Get an element of type TEntity in repository
        /// </summary>
        /// <typeparam name="TEntity">The entity type</typeparam>
        /// <param name="predicate">Filter that the element do match</param>
        /// <param name="includes">Related entities to include in the result set</param>
        /// <returns>Selected element</returns>
        TEntity GetSingle<TEntity>(Expression<Func<TEntity, bool>> predicate, List<string> includes)
            where TEntity : Entity;

        /// <summary>
        /// Get element of type TEntity in repository
        /// </summary>
        /// <typeparam name="TEntity">The entity type</typeparam>
        /// <param name="predicate">Filter that the element do match</param>
        /// <param name="includes">Related entities to include in the result set</param>
        /// <returns>Selected element</returns>
        Task<TEntity> GetSingleAsync<TEntity>(Expression<Func<TEntity, bool>> predicate, List<string> includes)
            where TEntity : Entity;

        /// <summary>
        /// Gets filtered entities
        /// </summary>
        /// <typeparam name="TEntity">The entity type</typeparam>
        /// <param name="predicate">The where.</param>
        /// <returns>Enumerable of the TEntity class</returns>
        IEnumerable<TEntity> GetFiltered<TEntity>(Expression<Func<TEntity, bool>> predicate)
            where TEntity : Entity;

        /// <summary>
        /// Gets the many asynchronous
        /// </summary>
        /// <typeparam name="TEntity">The entity type</typeparam>
        /// <param name="predicate">The where</param>
        /// <returns>Enumerable of the TEntity class</returns>
        Task<IEnumerable<TEntity>> GetFilteredAsync<TEntity>(Expression<Func<TEntity, bool>> predicate)
            where TEntity: Entity;

        /// <summary>
        /// Gets the many entities
        /// </summary>
        /// <typeparam name="TEntity">The entity type</typeparam>
        /// <param name="predicate">The where</param>
        /// <returns>Enumerable of the TEntity class</returns>
        IEnumerable<TEntity> GetFiltered<TEntity>(Expression<Func<TEntity, bool>> predicate, List<string> includes)
            where TEntity : Entity;

        /// <summary>
        /// Gets the many asynchronous
        /// </summary>
        /// <typeparam name="TEntity">The entity type</typeparam>
        /// <param name="predicate">The where</param>
        /// <returns>Enumerable of the TEntity class</returns>
        Task<IEnumerable<TEntity>> GetFilteredAsync<TEntity>(Expression<Func<TEntity, bool>> predicate, List<string> includes)
            where TEntity : Entity;

        PagedCollection GetPagedAndFiltered<TEntity>(DynamicFilter filterDef)
            where TEntity : Entity;

        Task<PagedCollection> GetPagedAndFilteredAsync<TEntity>(DynamicFilter filterDef)
            where TEntity : Entity;

        /// <summary>
        /// Gets Modify entities
        /// </summary>
        /// <typeparam name="TEntity">The entity type</typeparam>
        /// <param name="item">The where</param>
        void Modify<TEntity>(TEntity item)
            where TEntity : Entity;

        /// <summary>
        /// Execute specific stored procedure with underliying persistence store
        /// </summary>
        /// <typeparam name="TType">Entity type to map query results</typeparam>
        /// <param name="storedProcedure">
        /// The Stored Procedure name 
        /// <example>
        /// ImportacionExportacion.spControlInvoiceLineaProductoCP
        /// </example>
        /// </param>
        /// <param name="parameters">A vector of parameters values</param>
        /// <returns>
        /// Enumerable results 
        /// </returns>
        IEnumerable<TType> ExecuteStoredProcedure<TType>(string storedProcedure, Dictionary<string, object> parameters);
        IEnumerable<TType> ExecuteStoredProcedure<TType>(string storedProcedure, SqlParameter[] parameters);

        /// <summary>
        /// Execute specific scalar function with underliying persistence store
        /// </summary>
        /// <typeparam name="TType"></typeparam>
        /// <param name="scalarFunction"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        TType ExecuteScalarFunction<TType>(string scalarFunction, Dictionary<string, object> parameters);

        void ExecuteQuery(string sqlQuery, Dictionary<string, object> parameters);

        void ExecuteQuery(SqlParameter[] parms, string sqlQuery);

        /// <summary>
        /// Validate is running any jobs
        /// </summary>
        /// <param name="jobNames">Job names to be valid</param>
        /// <returns>If a job is run from the jobNames list, it returns true</returns>
        Task<bool> IsRunningJobsAsync(string jobName);

        IEnumerable<TEntity> ExecuteQuery<TEntity>(SqlParameter[] parms, string sqlQuery);
    }
}
````

## File: Infraestructura/Context/Mapping/ConfiguracionesMap/ConfiguracionesDetalleMap.cs
````csharp
using Dominio.Context.Entidades.ConfiguracionesAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Context.Mapping.ConfiguracionesMap
{
    internal class ConfiguracionesDetalleMap : EntityMap<ConfiguracionesDetalle>
    {
        public override void Configure(EntityTypeBuilder<ConfiguracionesDetalle> builder)
        {
            builder.HasKey(r => new { r.ConfiguracionId, r.Atributo });
            builder.ToTable("ConfiguracionesDetalle","Comunes");
            builder.Property(r => r.ConfiguracionId).HasColumnName("ConfiguracionId").HasMaxLength(150).IsRequired();
            builder.Property(r => r.Atributo).HasColumnName("Atributo").HasMaxLength(150).IsRequired();
            builder.Property(r => r.Valor).HasColumnName("Valor").HasMaxLength(150).IsRequired();
            builder.Property(r => r.Descripcion).HasColumnName("Descripcion").HasMaxLength(100);
            builder.HasOne(r => r.Configuraciones)
           .WithMany(p => p.ConfiguracionesDetalle)
           .HasForeignKey(r => r.ConfiguracionId)
           .IsRequired();
            base.Configure(builder);
        }
    }
}
````

## File: Infraestructura/Context/Mapping/ConfiguracionesMap/ConfiguracionesMap.cs
````csharp
using Dominio.Context.Entidades.ConfiguracionesAgg;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Context.Mapping.ConfiguracionesMap
{
    internal class ConfiguracionesMap : EntityMap<Configuraciones>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Configuraciones> builder)
        {
            builder.HasKey(r => r.ConfiguracionId);
            builder.ToTable("Configuraciones", "comunes");
            builder.Property(r => r.ConfiguracionId).HasColumnName("ConfiguracionId").HasMaxLength(150).IsRequired();
            builder.Property(r => r.Descripcion).HasColumnName("Descripcion").HasMaxLength(100).IsRequired().IsUnicode(false);
            base.Configure(builder);
        }
    }
}
````

## File: Infraestructura/Context/Mapping/Seguridad/PantallaMap.cs
````csharp
using Dominio.Context.Entidades.Seguridad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Context.Mapping.Seguridad
{
    internal class PantallaMap : EntityMap<Pantalla>
    {
        public override void Configure(EntityTypeBuilder<Pantalla> builder)
        {
            builder.HasKey(r => r.PantallaId);
            builder.ToTable("Pantalla", "Seguridad");
            builder.Property(r => r.PantallaId).HasColumnName("PantallaId").IsRequired();
            builder.Property(r => r.Descripcion).HasColumnName("Descripcion").IsRequired().IsUnicode(false);

            base.Configure(builder);
        }
    }
}
````

## File: Infraestructura/Context/Mapping/Seguridad/PermisosMap.cs
````csharp
using Dominio.Context.Entidades.Seguridad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Context.Mapping.Seguridad
{
    internal class PermisosMap : EntityMap<Permisos>
    {
        public override void Configure(EntityTypeBuilder<Permisos> builder)
        {
            builder.ToTable("Permisos", "Seguridad");
            builder.HasKey(p => new { p.RolId, p.PantallaId });
            builder.Property(r => r.PantallaId).HasColumnName("PantallaId").IsRequired();
            builder.Property(r => r.RolId).HasColumnName("RolId").IsRequired();
            builder.Property(r => r.Ver).HasColumnName("Ver").IsRequired();
            builder.Property(r => r.Editar).HasColumnName("Editar").IsRequired();
            builder.Property(r => r.Eliminar).HasColumnName("Eliminar").IsRequired();

            builder.HasOne(r => r.Rol).WithMany(r => r.Permisos).HasForeignKey(r => r.RolId);


            base.Configure(builder);
        }
    }
}
````

## File: Infraestructura/Core/DynamicQueryable.cs
````csharp
//Copyright (C) Microsoft Corporation.  All rights reserved.
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace System.Linq.Dynamic
{
    public static class DynamicQueryable
    {
        public static IQueryable<T> Where<T>(this IQueryable<T> source, string predicate, params object[] values)
        {
            return (IQueryable<T>)Where((IQueryable)source, predicate, values);
        }

        public static IQueryable Where(this IQueryable source, string predicate, params object[] values)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (predicate == null) throw new ArgumentNullException("predicate");
            LambdaExpression lambda = DynamicExpression.ParseLambda(source.ElementType, typeof(bool), predicate, values);
            return source.Provider.CreateQuery(
                Expression.Call(
                    typeof(Queryable), "Where",
                    new Type[] { source.ElementType },
                    source.Expression, Expression.Quote(lambda)));
        }

        public static IQueryable Select(this IQueryable source, string selector, params object[] values)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (selector == null) throw new ArgumentNullException("selector");
            LambdaExpression lambda = DynamicExpression.ParseLambda(source.ElementType, null, selector, values);
            return source.Provider.CreateQuery(
                Expression.Call(
                    typeof(Queryable), "Select",
                    new Type[] { source.ElementType, lambda.Body.Type },
                    source.Expression, Expression.Quote(lambda)));
        }

        public static IQueryable<T> OrderBy<T>(this IQueryable<T> source, string ordering, params object[] values)
        {
            return (IQueryable<T>)OrderBy((IQueryable)source, ordering, values);
        }

        public static IQueryable OrderBy(this IQueryable source, string ordering, params object[] values)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (ordering == null) throw new ArgumentNullException("ordering");
            ParameterExpression[] parameters = new ParameterExpression[] {
                Expression.Parameter(source.ElementType, "") };
            ExpressionParser parser = new ExpressionParser(parameters, ordering, values);
            IEnumerable<DynamicOrdering> orderings = parser.ParseOrdering();
            Expression queryExpr = source.Expression;
            string methodAsc = "OrderBy";
            string methodDesc = "OrderByDescending";
            foreach (DynamicOrdering o in orderings)
            {
                queryExpr = Expression.Call(
                    typeof(Queryable), o.Ascending ? methodAsc : methodDesc,
                    new Type[] { source.ElementType, o.Selector.Type },
                    queryExpr, Expression.Quote(Expression.Lambda(o.Selector, parameters)));
                methodAsc = "ThenBy";
                methodDesc = "ThenByDescending";
            }
            return source.Provider.CreateQuery(queryExpr);
        }

        public static IQueryable Take(this IQueryable source, int count)
        {
            if (source == null) throw new ArgumentNullException("source");
            return source.Provider.CreateQuery(
                Expression.Call(
                    typeof(Queryable), "Take",
                    new Type[] { source.ElementType },
                    source.Expression, Expression.Constant(count)));
        }

        public static IQueryable Skip(this IQueryable source, int count)
        {
            if (source == null) throw new ArgumentNullException("source");
            return source.Provider.CreateQuery(
                Expression.Call(
                    typeof(Queryable), "Skip",
                    new Type[] { source.ElementType },
                    source.Expression, Expression.Constant(count)));
        }

        public static IQueryable GroupBy(this IQueryable source, string keySelector, string elementSelector, params object[] values)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (keySelector == null) throw new ArgumentNullException("keySelector");
            if (elementSelector == null) throw new ArgumentNullException("elementSelector");
            LambdaExpression keyLambda = DynamicExpression.ParseLambda(source.ElementType, null, keySelector, values);
            LambdaExpression elementLambda = DynamicExpression.ParseLambda(source.ElementType, null, elementSelector, values);
            return source.Provider.CreateQuery(
                Expression.Call(
                    typeof(Queryable), "GroupBy",
                    new Type[] { source.ElementType, keyLambda.Body.Type, elementLambda.Body.Type },
                    source.Expression, Expression.Quote(keyLambda), Expression.Quote(elementLambda)));
        }

        public static bool Any(this IQueryable source)
        {
            if (source == null) throw new ArgumentNullException("source");
            return (bool)source.Provider.Execute(
                Expression.Call(
                    typeof(Queryable), "Any",
                    new Type[] { source.ElementType }, source.Expression));
        }

        public static int Count(this IQueryable source)
        {
            if (source == null) throw new ArgumentNullException("source");
            return (int)source.Provider.Execute(
                Expression.Call(
                    typeof(Queryable), "Count",
                    new Type[] { source.ElementType }, source.Expression));
        }
    }

    public abstract class DynamicClass
    {
        public override string ToString()
        {
            PropertyInfo[] props = this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            for (int i = 0; i < props.Length; i++)
            {
                if (i > 0) sb.Append(", ");
                sb.Append(props[i].Name);
                sb.Append("=");
                sb.Append(props[i].GetValue(this, null));
            }
            sb.Append("}");
            return sb.ToString();
        }
    }

    public class DynamicProperty
    {
        private string name;
        private Type type;

        public DynamicProperty(string name, Type type)
        {
            if (name == null) throw new ArgumentNullException("name");
            if (type == null) throw new ArgumentNullException("type");
            this.name = name;
            this.type = type;
        }

        public string Name
        {
            get { return name; }
        }

        public Type Type
        {
            get { return type; }
        }
    }

    public static class DynamicExpression
    {
        public static Expression Parse(Type resultType, string expression, params object[] values)
        {
            ExpressionParser parser = new ExpressionParser(null, expression, values);
            return parser.Parse(resultType);
        }

        public static LambdaExpression ParseLambda(Type itType, Type resultType, string expression, params object[] values)
        {
            return ParseLambda(new ParameterExpression[] { Expression.Parameter(itType, "") }, resultType, expression, values);
        }

        public static LambdaExpression ParseLambda(ParameterExpression[] parameters, Type resultType, string expression, params object[] values)
        {
            ExpressionParser parser = new ExpressionParser(parameters, expression, values);
            return Expression.Lambda(parser.Parse(resultType), parameters);
        }

        public static Expression<Func<T, S>> ParseLambda<T, S>(string expression, params object[] values)
        {
            return (Expression<Func<T, S>>)ParseLambda(typeof(T), typeof(S), expression, values);
        }

        public static Type CreateClass(params DynamicProperty[] properties)
        {
            return ClassFactory.Instance.GetDynamicClass(properties);
        }

        public static Type CreateClass(IEnumerable<DynamicProperty> properties)
        {
            return ClassFactory.Instance.GetDynamicClass(properties);
        }
    }

    internal class DynamicOrdering
    {
        public Expression Selector;
        public bool Ascending;
    }

    internal class Signature : IEquatable<Signature>
    {
        public DynamicProperty[] properties;
        public int hashCode;

        public Signature(IEnumerable<DynamicProperty> properties)
        {
            this.properties = properties.ToArray();
            hashCode = 0;
            foreach (DynamicProperty p in properties)
            {
                hashCode ^= p.Name.GetHashCode() ^ p.Type.GetHashCode();
            }
        }

        public override int GetHashCode()
        {
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            return obj is Signature ? Equals((Signature)obj) : false;
        }

        public bool Equals(Signature other)
        {
            if (properties.Length != other.properties.Length) return false;
            for (int i = 0; i < properties.Length; i++)
            {
                if (properties[i].Name != other.properties[i].Name ||
                    properties[i].Type != other.properties[i].Type)
                    return false;
            }
            return true;
        }
    }

    internal class ClassFactory
    {
        public static readonly ClassFactory Instance = new ClassFactory();

        static ClassFactory()
        {
        }  // Trigger lazy initialization of static fields

        private ModuleBuilder module;
        private Dictionary<Signature, Type> classes;
        private int classCount;
        private ReaderWriterLock rwLock;

        private ClassFactory()
        {
            AssemblyName name = new AssemblyName("DynamicClasses");
            
            AssemblyBuilder assembly = AssemblyBuilder.DefineDynamicAssembly(name, AssemblyBuilderAccess.Run);
#if ENABLE_LINQ_PARTIAL_TRUST
            new ReflectionPermission(PermissionState.Unrestricted).Assert();
#endif
            try
            {
                module = assembly.DefineDynamicModule("Module");
            }
            finally
            {
#if ENABLE_LINQ_PARTIAL_TRUST
                PermissionSet.RevertAssert();
#endif
            }
            classes = new Dictionary<Signature, Type>();
            rwLock = new ReaderWriterLock();
        }

        public Type GetDynamicClass(IEnumerable<DynamicProperty> properties)
        {
            rwLock.AcquireReaderLock(Timeout.Infinite);
            try
            {
                Signature signature = new Signature(properties);
                Type type;
                if (!classes.TryGetValue(signature, out type))
                {
                    type = CreateDynamicClass(signature.properties);
                    classes.Add(signature, type);
                }
                return type;
            }
            finally
            {
                rwLock.ReleaseReaderLock();
            }
        }

        private Type CreateDynamicClass(DynamicProperty[] properties)
        {
            LockCookie cookie = rwLock.UpgradeToWriterLock(Timeout.Infinite);
            try
            {
                string typeName = "DynamicClass" + (classCount + 1);
#if ENABLE_LINQ_PARTIAL_TRUST
                new ReflectionPermission(PermissionState.Unrestricted).Assert();
#endif
                try
                {
                    TypeBuilder tb = this.module.DefineType(typeName, TypeAttributes.Class |
                        TypeAttributes.Public, typeof(DynamicClass));
                    FieldInfo[] fields = GenerateProperties(tb, properties);
                    GenerateEquals(tb, fields);
                    GenerateGetHashCode(tb, fields);
                    Type result = tb.CreateType();
                    classCount++;
                    return result;
                }
                finally
                {
#if ENABLE_LINQ_PARTIAL_TRUST
                    PermissionSet.RevertAssert();
#endif
                }
            }
            finally
            {
                rwLock.DowngradeFromWriterLock(ref cookie);
            }
        }

        private FieldInfo[] GenerateProperties(TypeBuilder tb, DynamicProperty[] properties)
        {
            FieldInfo[] fields = new FieldBuilder[properties.Length];
            for (int i = 0; i < properties.Length; i++)
            {
                DynamicProperty dp = properties[i];
                FieldBuilder fb = tb.DefineField("_" + dp.Name, dp.Type, FieldAttributes.Private);
                PropertyBuilder pb = tb.DefineProperty(dp.Name, PropertyAttributes.HasDefault, dp.Type, null);
                MethodBuilder mbGet = tb.DefineMethod("get_" + dp.Name,
                    MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig,
                    dp.Type, Type.EmptyTypes);
                ILGenerator genGet = mbGet.GetILGenerator();
                genGet.Emit(OpCodes.Ldarg_0);
                genGet.Emit(OpCodes.Ldfld, fb);
                genGet.Emit(OpCodes.Ret);
                MethodBuilder mbSet = tb.DefineMethod("set_" + dp.Name,
                    MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig,
                    null, new Type[] { dp.Type });
                ILGenerator genSet = mbSet.GetILGenerator();
                genSet.Emit(OpCodes.Ldarg_0);
                genSet.Emit(OpCodes.Ldarg_1);
                genSet.Emit(OpCodes.Stfld, fb);
                genSet.Emit(OpCodes.Ret);
                pb.SetGetMethod(mbGet);
                pb.SetSetMethod(mbSet);
                fields[i] = fb;
            }
            return fields;
        }

        private void GenerateEquals(TypeBuilder tb, FieldInfo[] fields)
        {
            MethodBuilder mb = tb.DefineMethod("Equals",
                MethodAttributes.Public | MethodAttributes.ReuseSlot |
                MethodAttributes.Virtual | MethodAttributes.HideBySig,
                typeof(bool), new Type[] { typeof(object) });
            ILGenerator gen = mb.GetILGenerator();
            LocalBuilder other = gen.DeclareLocal(tb);
            Label next = gen.DefineLabel();
            gen.Emit(OpCodes.Ldarg_1);
            gen.Emit(OpCodes.Isinst, tb);
            gen.Emit(OpCodes.Stloc, other);
            gen.Emit(OpCodes.Ldloc, other);
            gen.Emit(OpCodes.Brtrue_S, next);
            gen.Emit(OpCodes.Ldc_I4_0);
            gen.Emit(OpCodes.Ret);
            gen.MarkLabel(next);
            foreach (FieldInfo field in fields)
            {
                Type ft = field.FieldType;
                Type ct = typeof(EqualityComparer<>).MakeGenericType(ft);
                next = gen.DefineLabel();
                gen.EmitCall(OpCodes.Call, ct.GetMethod("get_Default"), null);
                gen.Emit(OpCodes.Ldarg_0);
                gen.Emit(OpCodes.Ldfld, field);
                gen.Emit(OpCodes.Ldloc, other);
                gen.Emit(OpCodes.Ldfld, field);
                gen.EmitCall(OpCodes.Callvirt, ct.GetMethod("Equals", new Type[] { ft, ft }), null);
                gen.Emit(OpCodes.Brtrue_S, next);
                gen.Emit(OpCodes.Ldc_I4_0);
                gen.Emit(OpCodes.Ret);
                gen.MarkLabel(next);
            }
            gen.Emit(OpCodes.Ldc_I4_1);
            gen.Emit(OpCodes.Ret);
        }

        private void GenerateGetHashCode(TypeBuilder tb, FieldInfo[] fields)
        {
            MethodBuilder mb = tb.DefineMethod("GetHashCode",
                MethodAttributes.Public | MethodAttributes.ReuseSlot |
                MethodAttributes.Virtual | MethodAttributes.HideBySig,
                typeof(int), Type.EmptyTypes);
            ILGenerator gen = mb.GetILGenerator();
            gen.Emit(OpCodes.Ldc_I4_0);
            foreach (FieldInfo field in fields)
            {
                Type ft = field.FieldType;
                Type ct = typeof(EqualityComparer<>).MakeGenericType(ft);
                gen.EmitCall(OpCodes.Call, ct.GetMethod("get_Default"), null);
                gen.Emit(OpCodes.Ldarg_0);
                gen.Emit(OpCodes.Ldfld, field);
                gen.EmitCall(OpCodes.Callvirt, ct.GetMethod("GetHashCode", new Type[] { ft }), null);
                gen.Emit(OpCodes.Xor);
            }
            gen.Emit(OpCodes.Ret);
        }
    }

    public sealed class ParseException : Exception
    {
        private int position;

        public ParseException(string message, int position)
            : base(message)
        {
            this.position = position;
        }

        public int Position
        {
            get { return position; }
        }

        public override string ToString()
        {
            return string.Format(Res.ParseExceptionFormat, Message, position);
        }
    }

    internal class ExpressionParser
    {
        private struct Token
        {
            public TokenId id;
            public string text;
            public int pos;
        }

        private enum TokenId
        {
            Unknown,
            End,
            Identifier,
            StringLiteral,
            IntegerLiteral,
            RealLiteral,
            Exclamation,
            Percent,
            Amphersand,
            OpenParen,
            CloseParen,
            Asterisk,
            Plus,
            Comma,
            Minus,
            Dot,
            Slash,
            Colon,
            LessThan,
            Equal,
            GreaterThan,
            Question,
            OpenBracket,
            CloseBracket,
            Bar,
            ExclamationEqual,
            DoubleAmphersand,
            LessThanEqual,
            LessGreater,
            DoubleEqual,
            GreaterThanEqual,
            DoubleBar
        }

        private interface ILogicalSignatures
        {
            void F(bool x, bool y);

            void F(bool? x, bool? y);
        }

        private interface IArithmeticSignatures
        {
            void F(int x, int y);

            void F(uint x, uint y);

            void F(long x, long y);

            void F(ulong x, ulong y);

            void F(float x, float y);

            void F(double x, double y);

            void F(decimal x, decimal y);

            void F(int? x, int? y);

            void F(uint? x, uint? y);

            void F(long? x, long? y);

            void F(ulong? x, ulong? y);

            void F(float? x, float? y);

            void F(double? x, double? y);

            void F(decimal? x, decimal? y);
        }

        private interface IRelationalSignatures : IArithmeticSignatures
        {
            void F(string x, string y);

            void F(char x, char y);

            void F(DateTime x, DateTime y);

            void F(TimeSpan x, TimeSpan y);

            void F(char? x, char? y);

            void F(DateTime? x, DateTime? y);

            void F(TimeSpan? x, TimeSpan? y);
        }

        private interface IEqualitySignatures : IRelationalSignatures
        {
            void F(bool x, bool y);

            void F(bool? x, bool? y);
        }

        private interface IAddSignatures : IArithmeticSignatures
        {
            void F(DateTime x, TimeSpan y);

            void F(TimeSpan x, TimeSpan y);

            void F(DateTime? x, TimeSpan? y);

            void F(TimeSpan? x, TimeSpan? y);
        }

        private interface ISubtractSignatures : IAddSignatures
        {
            void F(DateTime x, DateTime y);

            void F(DateTime? x, DateTime? y);
        }

        private interface INegationSignatures
        {
            void F(int x);

            void F(long x);

            void F(float x);

            void F(double x);

            void F(decimal x);

            void F(int? x);

            void F(long? x);

            void F(float? x);

            void F(double? x);

            void F(decimal? x);
        }

        private interface INotSignatures
        {
            void F(bool x);

            void F(bool? x);
        }

        private interface IEnumerableSignatures
        {
            void Where(bool predicate);

            void Any();

            void Any(bool predicate);

            void All(bool predicate);

            void Count();

            void Count(bool predicate);

            void Min(object selector);

            void Max(object selector);

            void Sum(int selector);

            void Sum(int? selector);

            void Sum(long selector);

            void Sum(long? selector);

            void Sum(float selector);

            void Sum(float? selector);

            void Sum(double selector);

            void Sum(double? selector);

            void Sum(decimal selector);

            void Sum(decimal? selector);

            void Average(int selector);

            void Average(int? selector);

            void Average(long selector);

            void Average(long? selector);

            void Average(float selector);

            void Average(float? selector);

            void Average(double selector);

            void Average(double? selector);

            void Average(decimal selector);

            void Average(decimal? selector);
        }

        private static readonly Type[] predefinedTypes = {
            typeof(Object),
            typeof(Boolean),
            typeof(Char),
            typeof(String),
            typeof(SByte),
            typeof(Byte),
            typeof(Int16),
            typeof(UInt16),
            typeof(Int32),
            typeof(UInt32),
            typeof(Int64),
            typeof(UInt64),
            typeof(Single),
            typeof(Double),
            typeof(Decimal),
            typeof(DateTime),
            typeof(TimeSpan),
            typeof(Guid),
            typeof(Math),
            typeof(Convert)
        };

        private static readonly Expression trueLiteral = Expression.Constant(true);
        private static readonly Expression falseLiteral = Expression.Constant(false);
        private static readonly Expression nullLiteral = Expression.Constant(null);

        private static readonly string keywordIt = "it";
        private static readonly string keywordIif = "iif";
        private static readonly string keywordNew = "new";

        private Dictionary<string, object> keywords;

        private Dictionary<string, object> symbols;
        private IDictionary<string, object> externals;
        private Dictionary<Expression, string> literals;
        private ParameterExpression it;
        private string text;
        private int textPos;
        private int textLen;
        private char ch;
        private Token token;

        public ExpressionParser(ParameterExpression[] parameters, string expression, object[] values)
        {
            if (expression == null) throw new ArgumentNullException("expression");
            if (keywords == null) keywords = CreateKeywords();
            symbols = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            literals = new Dictionary<Expression, string>();
            if (parameters != null) ProcessParameters(parameters);
            if (values != null) ProcessValues(values);
            text = expression;
            textLen = text.Length;
            SetTextPos(0);
            NextToken();
        }

        private void ProcessParameters(ParameterExpression[] parameters)
        {
            foreach (ParameterExpression pe in parameters)
                if (!String.IsNullOrEmpty(pe.Name))
                    AddSymbol(pe.Name, pe);
            if (parameters.Length == 1 && String.IsNullOrEmpty(parameters[0].Name))
                it = parameters[0];
        }

        private void ProcessValues(object[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                object value = values[i];
                if (i == values.Length - 1 && value is IDictionary<string, object>)
                {
                    externals = (IDictionary<string, object>)value;
                }
                else
                {
                    AddSymbol("@" + i.ToString(System.Globalization.CultureInfo.InvariantCulture), value);
                }
            }
        }

        private void AddSymbol(string name, object value)
        {
            if (symbols.ContainsKey(name))
                throw ParseError(Res.DuplicateIdentifier, name);
            symbols.Add(name, value);
        }

        public Expression Parse(Type resultType)
        {
            int exprPos = token.pos;
            Expression expr = ParseExpression();
            if (resultType != null)
                if ((expr = PromoteExpression(expr, resultType, true)) == null)
                    throw ParseError(exprPos, Res.ExpressionTypeMismatch, GetTypeName(resultType));
            ValidateToken(TokenId.End, Res.SyntaxError);
            return expr;
        }

#pragma warning disable 0219

        public IEnumerable<DynamicOrdering> ParseOrdering()
        {
            List<DynamicOrdering> orderings = new List<DynamicOrdering>();
            while (true)
            {
                Expression expr = ParseExpression();
                bool ascending = true;
                if (TokenIdentifierIs("asc") || TokenIdentifierIs("ascending"))
                {
                    NextToken();
                }
                else if (TokenIdentifierIs("desc") || TokenIdentifierIs("descending"))
                {
                    NextToken();
                    ascending = false;
                }
                orderings.Add(new DynamicOrdering { Selector = expr, Ascending = ascending });
                if (token.id != TokenId.Comma) break;
                NextToken();
            }
            ValidateToken(TokenId.End, Res.SyntaxError);
            return orderings;
        }

#pragma warning restore 0219

        // ?: operator
        private Expression ParseExpression()
        {
            int errorPos = token.pos;
            Expression expr = ParseLogicalOr();
            if (token.id == TokenId.Question)
            {
                NextToken();
                Expression expr1 = ParseExpression();
                ValidateToken(TokenId.Colon, Res.ColonExpected);
                NextToken();
                Expression expr2 = ParseExpression();
                expr = GenerateConditional(expr, expr1, expr2, errorPos);
            }
            return expr;
        }

        // ||, or operator
        private Expression ParseLogicalOr()
        {
            Expression left = ParseLogicalAnd();
            while (token.id == TokenId.DoubleBar || TokenIdentifierIs("or"))
            {
                Token op = token;
                NextToken();
                Expression right = ParseLogicalAnd();
                CheckAndPromoteOperands(typeof(ILogicalSignatures), op.text, ref left, ref right, op.pos);
                left = Expression.OrElse(left, right);
            }
            return left;
        }

        // &&, and operator
        private Expression ParseLogicalAnd()
        {
            Expression left = ParseComparison();
            while (token.id == TokenId.DoubleAmphersand || TokenIdentifierIs("and"))
            {
                Token op = token;
                NextToken();
                Expression right = ParseComparison();
                CheckAndPromoteOperands(typeof(ILogicalSignatures), op.text, ref left, ref right, op.pos);
                left = Expression.AndAlso(left, right);
            }
            return left;
        }

        // =, ==, !=, <>, >, >=, <, <= operators
        private Expression ParseComparison()
        {
            Expression left = ParseAdditive();
            while (token.id == TokenId.Equal || token.id == TokenId.DoubleEqual ||
                token.id == TokenId.ExclamationEqual || token.id == TokenId.LessGreater ||
                token.id == TokenId.GreaterThan || token.id == TokenId.GreaterThanEqual ||
                token.id == TokenId.LessThan || token.id == TokenId.LessThanEqual)
            {
                Token op = token;
                NextToken();
                Expression right = ParseAdditive();
                bool isEquality = op.id == TokenId.Equal || op.id == TokenId.DoubleEqual ||
                    op.id == TokenId.ExclamationEqual || op.id == TokenId.LessGreater;
                if (isEquality && !left.Type.IsValueType && !right.Type.IsValueType)
                {
                    if (left.Type != right.Type)
                    {
                        if (left.Type.IsAssignableFrom(right.Type))
                        {
                            right = Expression.Convert(right, left.Type);
                        }
                        else if (right.Type.IsAssignableFrom(left.Type))
                        {
                            left = Expression.Convert(left, right.Type);
                        }
                        else
                        {
                            throw IncompatibleOperandsError(op.text, left, right, op.pos);
                        }
                    }
                }
                else if (IsEnumType(left.Type) || IsEnumType(right.Type))
                {
                    if (left.Type != right.Type)
                    {
                        Expression e;
                        if ((e = PromoteExpression(right, left.Type, true)) != null)
                        {
                            right = e;
                        }
                        else if ((e = PromoteExpression(left, right.Type, true)) != null)
                        {
                            left = e;
                        }
                        else
                        {
                            throw IncompatibleOperandsError(op.text, left, right, op.pos);
                        }
                    }
                }
                else
                {
                    CheckAndPromoteOperands(isEquality ? typeof(IEqualitySignatures) : typeof(IRelationalSignatures),
                        op.text, ref left, ref right, op.pos);
                }
                switch (op.id)
                {
                    case TokenId.Equal:
                    case TokenId.DoubleEqual:
                        left = GenerateEqual(left, right);
                        break;

                    case TokenId.ExclamationEqual:
                    case TokenId.LessGreater:
                        left = GenerateNotEqual(left, right);
                        break;

                    case TokenId.GreaterThan:
                        left = GenerateGreaterThan(left, right);
                        break;

                    case TokenId.GreaterThanEqual:
                        left = GenerateGreaterThanEqual(left, right);
                        break;

                    case TokenId.LessThan:
                        left = GenerateLessThan(left, right);
                        break;

                    case TokenId.LessThanEqual:
                        left = GenerateLessThanEqual(left, right);
                        break;
                }
            }
            return left;
        }

        // +, -, & operators
        private Expression ParseAdditive()
        {
            Expression left = ParseMultiplicative();
            while (token.id == TokenId.Plus || token.id == TokenId.Minus ||
                token.id == TokenId.Amphersand)
            {
                Token op = token;
                NextToken();
                Expression right = ParseMultiplicative();
                switch (op.id)
                {
                    case TokenId.Plus:
                        if (left.Type == typeof(string) || right.Type == typeof(string))
                            goto case TokenId.Amphersand;
                        CheckAndPromoteOperands(typeof(IAddSignatures), op.text, ref left, ref right, op.pos);
                        left = GenerateAdd(left, right);
                        break;

                    case TokenId.Minus:
                        CheckAndPromoteOperands(typeof(ISubtractSignatures), op.text, ref left, ref right, op.pos);
                        left = GenerateSubtract(left, right);
                        break;

                    case TokenId.Amphersand:
                        left = GenerateStringConcat(left, right);
                        break;
                }
            }
            return left;
        }

        // *, /, %, mod operators
        private Expression ParseMultiplicative()
        {
            Expression left = ParseUnary();
            while (token.id == TokenId.Asterisk || token.id == TokenId.Slash ||
                token.id == TokenId.Percent || TokenIdentifierIs("mod"))
            {
                Token op = token;
                NextToken();
                Expression right = ParseUnary();
                CheckAndPromoteOperands(typeof(IArithmeticSignatures), op.text, ref left, ref right, op.pos);
                switch (op.id)
                {
                    case TokenId.Asterisk:
                        left = Expression.Multiply(left, right);
                        break;

                    case TokenId.Slash:
                        left = Expression.Divide(left, right);
                        break;

                    case TokenId.Percent:
                    case TokenId.Identifier:
                        left = Expression.Modulo(left, right);
                        break;
                }
            }
            return left;
        }

        // -, !, not unary operators
        private Expression ParseUnary()
        {
            if (token.id == TokenId.Minus || token.id == TokenId.Exclamation ||
                TokenIdentifierIs("not"))
            {
                Token op = token;
                NextToken();
                if (op.id == TokenId.Minus && (token.id == TokenId.IntegerLiteral ||
                    token.id == TokenId.RealLiteral))
                {
                    token.text = "-" + token.text;
                    token.pos = op.pos;
                    return ParsePrimary();
                }
                Expression expr = ParseUnary();
                if (op.id == TokenId.Minus)
                {
                    CheckAndPromoteOperand(typeof(INegationSignatures), op.text, ref expr, op.pos);
                    expr = Expression.Negate(expr);
                }
                else
                {
                    CheckAndPromoteOperand(typeof(INotSignatures), op.text, ref expr, op.pos);
                    expr = Expression.Not(expr);
                }
                return expr;
            }
            return ParsePrimary();
        }

        private Expression ParsePrimary()
        {
            Expression expr = ParsePrimaryStart();
            while (true)
            {
                if (token.id == TokenId.Dot)
                {
                    NextToken();
                    expr = ParseMemberAccess(null, expr);
                }
                else if (token.id == TokenId.OpenBracket)
                {
                    expr = ParseElementAccess(expr);
                }
                else
                {
                    break;
                }
            }
            return expr;
        }

        private Expression ParsePrimaryStart()
        {
            switch (token.id)
            {
                case TokenId.Identifier:
                    return ParseIdentifier();

                case TokenId.StringLiteral:
                    return ParseStringLiteral();

                case TokenId.IntegerLiteral:
                    return ParseIntegerLiteral();

                case TokenId.RealLiteral:
                    return ParseRealLiteral();

                case TokenId.OpenParen:
                    return ParseParenExpression();

                default:
                    throw ParseError(Res.ExpressionExpected);
            }
        }

        private Expression ParseStringLiteral()
        {
            ValidateToken(TokenId.StringLiteral);
            char quote = token.text[0];
            string s = token.text.Substring(1, token.text.Length - 2);
            int start = 0;
            while (true)
            {
                int i = s.IndexOf(quote, start);
                if (i < 0) break;
                s = s.Remove(i, 1);
                start = i + 1;
            }
            if (quote == '\'')
            {
                if (s.Length != 1)
                    throw ParseError(Res.InvalidCharacterLiteral);
                NextToken();
                return CreateLiteral(s[0], s);
            }
            NextToken();
            return CreateLiteral(s, s);
        }

        private Expression ParseIntegerLiteral()
        {
            ValidateToken(TokenId.IntegerLiteral);
            string text = token.text;
            if (text[0] != '-')
            {
                ulong value;
                if (!UInt64.TryParse(text, out value))
                    throw ParseError(Res.InvalidIntegerLiteral, text);
                NextToken();
                if (value <= (ulong)Int32.MaxValue) return CreateLiteral((int)value, text);
                if (value <= (ulong)UInt32.MaxValue) return CreateLiteral((uint)value, text);
                if (value <= (ulong)Int64.MaxValue) return CreateLiteral((long)value, text);
                return CreateLiteral(value, text);
            }
            else
            {
                long value;
                if (!Int64.TryParse(text, out value))
                    throw ParseError(Res.InvalidIntegerLiteral, text);
                NextToken();
                if (value >= Int32.MinValue && value <= Int32.MaxValue)
                    return CreateLiteral((int)value, text);
                return CreateLiteral(value, text);
            }
        }

        private Expression ParseRealLiteral()
        {
            ValidateToken(TokenId.RealLiteral);
            string text = token.text;
            object value = null;
            char last = text[text.Length - 1];
            if (last == 'F' || last == 'f')
            {
                float f;
                if (Single.TryParse(text.Substring(0, text.Length - 1), out f)) value = f;
            }
            else
            {
                double d;
                if (Double.TryParse(text, out d)) value = d;
            }
            if (value == null) throw ParseError(Res.InvalidRealLiteral, text);
            NextToken();
            return CreateLiteral(value, text);
        }

        private Expression CreateLiteral(object value, string text)
        {
            ConstantExpression expr = Expression.Constant(value);
            literals.Add(expr, text);
            return expr;
        }

        private Expression ParseParenExpression()
        {
            ValidateToken(TokenId.OpenParen, Res.OpenParenExpected);
            NextToken();
            Expression e = ParseExpression();
            ValidateToken(TokenId.CloseParen, Res.CloseParenOrOperatorExpected);
            NextToken();
            return e;
        }

        private Expression ParseIdentifier()
        {
            ValidateToken(TokenId.Identifier);
            object value;
            if (keywords.TryGetValue(token.text, out value))
            {
                if (value is Type) return ParseTypeAccess((Type)value);
                if (value == (object)keywordIt) return ParseIt();
                if (value == (object)keywordIif) return ParseIif();
                if (value == (object)keywordNew) return ParseNew();
                NextToken();
                return (Expression)value;
            }
            if (symbols.TryGetValue(token.text, out value) ||
                externals != null && externals.TryGetValue(token.text, out value))
            {
                Expression expr = value as Expression;
                if (expr == null)
                {
                    expr = Expression.Constant(value);
                }
                else
                {
                    LambdaExpression lambda = expr as LambdaExpression;
                    if (lambda != null) return ParseLambdaInvocation(lambda);
                }
                NextToken();
                return expr;
            }
            if (it != null) return ParseMemberAccess(null, it);
            throw ParseError(Res.UnknownIdentifier, token.text);
        }

        private Expression ParseIt()
        {
            if (it == null)
                throw ParseError(Res.NoItInScope);
            NextToken();
            return it;
        }

        private Expression ParseIif()
        {
            int errorPos = token.pos;
            NextToken();
            Expression[] args = ParseArgumentList();
            if (args.Length != 3)
                throw ParseError(errorPos, Res.IifRequiresThreeArgs);
            return GenerateConditional(args[0], args[1], args[2], errorPos);
        }

        private Expression GenerateConditional(Expression test, Expression expr1, Expression expr2, int errorPos)
        {
            if (test.Type != typeof(bool))
                throw ParseError(errorPos, Res.FirstExprMustBeBool);
            if (expr1.Type != expr2.Type)
            {
                Expression expr1as2 = expr2 != nullLiteral ? PromoteExpression(expr1, expr2.Type, true) : null;
                Expression expr2as1 = expr1 != nullLiteral ? PromoteExpression(expr2, expr1.Type, true) : null;
                if (expr1as2 != null && expr2as1 == null)
                {
                    expr1 = expr1as2;
                }
                else if (expr2as1 != null && expr1as2 == null)
                {
                    expr2 = expr2as1;
                }
                else
                {
                    string type1 = expr1 != nullLiteral ? expr1.Type.Name : "null";
                    string type2 = expr2 != nullLiteral ? expr2.Type.Name : "null";
                    if (expr1as2 != null && expr2as1 != null)
                        throw ParseError(errorPos, Res.BothTypesConvertToOther, type1, type2);
                    throw ParseError(errorPos, Res.NeitherTypeConvertsToOther, type1, type2);
                }
            }
            return Expression.Condition(test, expr1, expr2);
        }

        private Expression ParseNew()
        {
            NextToken();
            ValidateToken(TokenId.OpenParen, Res.OpenParenExpected);
            NextToken();
            List<DynamicProperty> properties = new List<DynamicProperty>();
            List<Expression> expressions = new List<Expression>();
            while (true)
            {
                int exprPos = token.pos;
                Expression expr = ParseExpression();
                string propName;
                if (TokenIdentifierIs("as"))
                {
                    NextToken();
                    propName = GetIdentifier();
                    NextToken();
                }
                else
                {
                    MemberExpression me = expr as MemberExpression;
                    if (me == null) throw ParseError(exprPos, Res.MissingAsClause);
                    propName = me.Member.Name;
                }
                expressions.Add(expr);
                properties.Add(new DynamicProperty(propName, expr.Type));
                if (token.id != TokenId.Comma) break;
                NextToken();
            }
            ValidateToken(TokenId.CloseParen, Res.CloseParenOrCommaExpected);
            NextToken();
            Type type = DynamicExpression.CreateClass(properties);
            MemberBinding[] bindings = new MemberBinding[properties.Count];
            for (int i = 0; i < bindings.Length; i++)
                bindings[i] = Expression.Bind(type.GetProperty(properties[i].Name), expressions[i]);
            return Expression.MemberInit(Expression.New(type), bindings);
        }

        private Expression ParseLambdaInvocation(LambdaExpression lambda)
        {
            int errorPos = token.pos;
            NextToken();
            Expression[] args = ParseArgumentList();
            MethodBase method;
            if (FindMethod(lambda.Type, "Invoke", false, args, out method) != 1)
                throw ParseError(errorPos, Res.ArgsIncompatibleWithLambda);
            return Expression.Invoke(lambda, args);
        }

        private Expression ParseTypeAccess(Type type)
        {
            int errorPos = token.pos;
            NextToken();
            if (token.id == TokenId.Question)
            {
                if (!type.IsValueType || IsNullableType(type))
                    throw ParseError(errorPos, Res.TypeHasNoNullableForm, GetTypeName(type));
                type = typeof(Nullable<>).MakeGenericType(type);
                NextToken();
            }
            if (token.id == TokenId.OpenParen)
            {
                Expression[] args = ParseArgumentList();
                MethodBase method;
                switch (FindBestMethod(type.GetConstructors(), args, out method))
                {
                    case 0:
                        if (args.Length == 1)
                            return GenerateConversion(args[0], type, errorPos);
                        throw ParseError(errorPos, Res.NoMatchingConstructor, GetTypeName(type));
                    case 1:
                        return Expression.New((ConstructorInfo)method, args);

                    default:
                        throw ParseError(errorPos, Res.AmbiguousConstructorInvocation, GetTypeName(type));
                }
            }
            ValidateToken(TokenId.Dot, Res.DotOrOpenParenExpected);
            NextToken();
            return ParseMemberAccess(type, null);
        }

        private Expression GenerateConversion(Expression expr, Type type, int errorPos)
        {
            Type exprType = expr.Type;
            if (exprType == type) return expr;
            if (exprType.IsValueType && type.IsValueType)
            {
                if ((IsNullableType(exprType) || IsNullableType(type)) &&
                    GetNonNullableType(exprType) == GetNonNullableType(type))
                    return Expression.Convert(expr, type);
                if ((IsNumericType(exprType) || IsEnumType(exprType)) &&
                    (IsNumericType(type)) || IsEnumType(type))
                    return Expression.ConvertChecked(expr, type);
            }
            if (exprType.IsAssignableFrom(type) || type.IsAssignableFrom(exprType) ||
                exprType.IsInterface || type.IsInterface)
                return Expression.Convert(expr, type);
            throw ParseError(errorPos, Res.CannotConvertValue,
                GetTypeName(exprType), GetTypeName(type));
        }

        private Expression ParseMemberAccess(Type type, Expression instance)
        {
            if (instance != null) type = instance.Type;
            int errorPos = token.pos;
            string id = GetIdentifier();
            NextToken();
            if (token.id == TokenId.OpenParen)
            {
                if (instance != null && type != typeof(string))
                {
                    Type enumerableType = FindGenericType(typeof(IEnumerable<>), type);
                    if (enumerableType != null)
                    {
                        Type elementType = enumerableType.GetGenericArguments()[0];
                        return ParseAggregate(instance, elementType, id, errorPos);
                    }
                }
                Expression[] args = ParseArgumentList();
                MethodBase mb;
                switch (FindMethod(type, id, instance == null, args, out mb))
                {
                    case 0:
                        throw ParseError(errorPos, Res.NoApplicableMethod,
                            id, GetTypeName(type));
                    case 1:
                        MethodInfo method = (MethodInfo)mb;
                        if (!IsPredefinedType(method.DeclaringType))
                            throw ParseError(errorPos, Res.MethodsAreInaccessible, GetTypeName(method.DeclaringType));
                        if (method.ReturnType == typeof(void))
                            throw ParseError(errorPos, Res.MethodIsVoid,
                                id, GetTypeName(method.DeclaringType));
                        return Expression.Call(instance, (MethodInfo)method, args);

                    default:
                        throw ParseError(errorPos, Res.AmbiguousMethodInvocation,
                            id, GetTypeName(type));
                }
            }
            else
            {
                MemberInfo member = FindPropertyOrField(type, id, instance == null);
                if (member == null)
                    throw ParseError(errorPos, Res.UnknownPropertyOrField,
                        id, GetTypeName(type));
                return member is PropertyInfo ?
                    Expression.Property(instance, (PropertyInfo)member) :
                    Expression.Field(instance, (FieldInfo)member);
            }
        }

        private static Type FindGenericType(Type generic, Type type)
        {
            while (type != null && type != typeof(object))
            {
                if (type.IsGenericType && type.GetGenericTypeDefinition() == generic) return type;
                if (generic.IsInterface)
                {
                    foreach (Type intfType in type.GetInterfaces())
                    {
                        Type found = FindGenericType(generic, intfType);
                        if (found != null) return found;
                    }
                }
                type = type.BaseType;
            }
            return null;
        }

        private Expression ParseAggregate(Expression instance, Type elementType, string methodName, int errorPos)
        {
            ParameterExpression outerIt = it;
            ParameterExpression innerIt = Expression.Parameter(elementType, "");
            it = innerIt;
            Expression[] args = ParseArgumentList();
            it = outerIt;
            MethodBase signature;
            if (FindMethod(typeof(IEnumerableSignatures), methodName, false, args, out signature) != 1)
                throw ParseError(errorPos, Res.NoApplicableAggregate, methodName);
            Type[] typeArgs;
            if (signature.Name == "Min" || signature.Name == "Max")
            {
                typeArgs = new Type[] { elementType, args[0].Type };
            }
            else
            {
                typeArgs = new Type[] { elementType };
            }
            if (args.Length == 0)
            {
                args = new Expression[] { instance };
            }
            else
            {
                args = new Expression[] { instance, Expression.Lambda(args[0], innerIt) };
            }
            return Expression.Call(typeof(Enumerable), signature.Name, typeArgs, args);
        }

        private Expression[] ParseArgumentList()
        {
            ValidateToken(TokenId.OpenParen, Res.OpenParenExpected);
            NextToken();
            Expression[] args = token.id != TokenId.CloseParen ? ParseArguments() : new Expression[0];
            ValidateToken(TokenId.CloseParen, Res.CloseParenOrCommaExpected);
            NextToken();
            return args;
        }

        private Expression[] ParseArguments()
        {
            List<Expression> argList = new List<Expression>();
            while (true)
            {
                argList.Add(ParseExpression());
                if (token.id != TokenId.Comma) break;
                NextToken();
            }
            return argList.ToArray();
        }

        private Expression ParseElementAccess(Expression expr)
        {
            int errorPos = token.pos;
            ValidateToken(TokenId.OpenBracket, Res.OpenParenExpected);
            NextToken();
            Expression[] args = ParseArguments();
            ValidateToken(TokenId.CloseBracket, Res.CloseBracketOrCommaExpected);
            NextToken();
            if (expr.Type.IsArray)
            {
                if (expr.Type.GetArrayRank() != 1 || args.Length != 1)
                    throw ParseError(errorPos, Res.CannotIndexMultiDimArray);
                Expression index = PromoteExpression(args[0], typeof(int), true);
                if (index == null)
                    throw ParseError(errorPos, Res.InvalidIndex);
                return Expression.ArrayIndex(expr, index);
            }
            else
            {
                MethodBase mb;
                switch (FindIndexer(expr.Type, args, out mb))
                {
                    case 0:
                        throw ParseError(errorPos, Res.NoApplicableIndexer,
                            GetTypeName(expr.Type));
                    case 1:
                        return Expression.Call(expr, (MethodInfo)mb, args);

                    default:
                        throw ParseError(errorPos, Res.AmbiguousIndexerInvocation,
                            GetTypeName(expr.Type));
                }
            }
        }

        private static bool IsPredefinedType(Type type)
        {
            foreach (Type t in predefinedTypes) if (t == type) return true;
            return false;
        }

        private static bool IsNullableType(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }

        private static Type GetNonNullableType(Type type)
        {
            return IsNullableType(type) ? type.GetGenericArguments()[0] : type;
        }

        private static string GetTypeName(Type type)
        {
            Type baseType = GetNonNullableType(type);
            string s = baseType.Name;
            if (type != baseType) s += '?';
            return s;
        }

        private static bool IsNumericType(Type type)
        {
            return GetNumericTypeKind(type) != 0;
        }

        private static bool IsSignedIntegralType(Type type)
        {
            return GetNumericTypeKind(type) == 2;
        }

        private static bool IsUnsignedIntegralType(Type type)
        {
            return GetNumericTypeKind(type) == 3;
        }

        private static int GetNumericTypeKind(Type type)
        {
            type = GetNonNullableType(type);
            if (type.IsEnum) return 0;
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Char:
                case TypeCode.Single:
                case TypeCode.Double:
                case TypeCode.Decimal:
                    return 1;

                case TypeCode.SByte:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                    return 2;

                case TypeCode.Byte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    return 3;

                default:
                    return 0;
            }
        }

        private static bool IsEnumType(Type type)
        {
            return GetNonNullableType(type).IsEnum;
        }

        private void CheckAndPromoteOperand(Type signatures, string opName, ref Expression expr, int errorPos)
        {
            Expression[] args = new Expression[] { expr };
            MethodBase method;
            if (FindMethod(signatures, "F", false, args, out method) != 1)
                throw ParseError(errorPos, Res.IncompatibleOperand,
                    opName, GetTypeName(args[0].Type));
            expr = args[0];
        }

        private void CheckAndPromoteOperands(Type signatures, string opName, ref Expression left, ref Expression right, int errorPos)
        {
            Expression[] args = new Expression[] { left, right };
            MethodBase method;
            if (FindMethod(signatures, "F", false, args, out method) != 1)
                throw IncompatibleOperandsError(opName, left, right, errorPos);
            left = args[0];
            right = args[1];
        }

        private Exception IncompatibleOperandsError(string opName, Expression left, Expression right, int pos)
        {
            return ParseError(pos, Res.IncompatibleOperands,
                opName, GetTypeName(left.Type), GetTypeName(right.Type));
        }

        private MemberInfo FindPropertyOrField(Type type, string memberName, bool staticAccess)
        {
            BindingFlags flags = BindingFlags.Public | BindingFlags.DeclaredOnly |
                (staticAccess ? BindingFlags.Static : BindingFlags.Instance);
            foreach (Type t in SelfAndBaseTypes(type))
            {
                MemberInfo[] members = t.FindMembers(MemberTypes.Property | MemberTypes.Field,
                    flags, Type.FilterNameIgnoreCase, memberName);
                if (members.Length != 0) return members[0];
            }
            return null;
        }

        private int FindMethod(Type type, string methodName, bool staticAccess, Expression[] args, out MethodBase method)
        {
            BindingFlags flags = BindingFlags.Public | BindingFlags.DeclaredOnly |
                (staticAccess ? BindingFlags.Static : BindingFlags.Instance);
            foreach (Type t in SelfAndBaseTypes(type))
            {
                MemberInfo[] members = t.FindMembers(MemberTypes.Method,
                    flags, Type.FilterNameIgnoreCase, methodName);
                int count = FindBestMethod(members.Cast<MethodBase>(), args, out method);
                if (count != 0) return count;
            }
            method = null;
            return 0;
        }

        private int FindIndexer(Type type, Expression[] args, out MethodBase method)
        {
            foreach (Type t in SelfAndBaseTypes(type))
            {
                MemberInfo[] members = t.GetDefaultMembers();
                if (members.Length != 0)
                {
                    IEnumerable<MethodBase> methods = members.
                        OfType<PropertyInfo>().
                        Select(p => (MethodBase)p.GetGetMethod()).
                        Where(m => m != null);
                    int count = FindBestMethod(methods, args, out method);
                    if (count != 0) return count;
                }
            }
            method = null;
            return 0;
        }

        private static IEnumerable<Type> SelfAndBaseTypes(Type type)
        {
            if (type.IsInterface)
            {
                List<Type> types = new List<Type>();
                AddInterface(types, type);
                return types;
            }
            return SelfAndBaseClasses(type);
        }

        private static IEnumerable<Type> SelfAndBaseClasses(Type type)
        {
            while (type != null)
            {
                yield return type;
                type = type.BaseType;
            }
        }

        private static void AddInterface(List<Type> types, Type type)
        {
            if (!types.Contains(type))
            {
                types.Add(type);
                foreach (Type t in type.GetInterfaces()) AddInterface(types, t);
            }
        }

        private class MethodData
        {
            public MethodBase MethodBase;
            public ParameterInfo[] Parameters;
            public Expression[] Args;
        }

        private int FindBestMethod(IEnumerable<MethodBase> methods, Expression[] args, out MethodBase method)
        {
            MethodData[] applicable = methods.
                Select(m => new MethodData { MethodBase = m, Parameters = m.GetParameters() }).
                Where(m => IsApplicable(m, args)).
                ToArray();
            if (applicable.Length > 1)
            {
                applicable = applicable.
                    Where(m => applicable.All(n => m == n || IsBetterThan(args, m, n))).
                    ToArray();
            }
            if (applicable.Length == 1)
            {
                MethodData md = applicable[0];
                for (int i = 0; i < args.Length; i++) args[i] = md.Args[i];
                method = md.MethodBase;
            }
            else
            {
                method = null;
            }
            return applicable.Length;
        }

        private bool IsApplicable(MethodData method, Expression[] args)
        {
            if (method.Parameters.Length != args.Length) return false;
            Expression[] promotedArgs = new Expression[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                ParameterInfo pi = method.Parameters[i];
                if (pi.IsOut) return false;
                Expression promoted = PromoteExpression(args[i], pi.ParameterType, false);
                if (promoted == null) return false;
                promotedArgs[i] = promoted;
            }
            method.Args = promotedArgs;
            return true;
        }

        private Expression PromoteExpression(Expression expr, Type type, bool exact)
        {
            if (expr.Type == type) return expr;
            if (expr is ConstantExpression)
            {
                ConstantExpression ce = (ConstantExpression)expr;
                if (ce == nullLiteral)
                {
                    if (!type.IsValueType || IsNullableType(type))
                        return Expression.Constant(null, type);
                }
                else
                {
                    string text;
                    if (literals.TryGetValue(ce, out text))
                    {
                        Type target = GetNonNullableType(type);
                        Object value = null;
                        switch (Type.GetTypeCode(ce.Type))
                        {
                            case TypeCode.Int32:
                            case TypeCode.UInt32:
                            case TypeCode.Int64:
                            case TypeCode.UInt64:
                                value = ParseNumber(text, target);
                                break;

                            case TypeCode.Double:
                                if (target == typeof(decimal)) value = ParseNumber(text, target);
                                break;

                            case TypeCode.String:
                                value = ParseEnum(text, target);
                                break;
                        }
                        if (value != null)
                            return Expression.Constant(value, type);
                    }
                }
            }
            if (IsCompatibleWith(expr.Type, type))
            {
                if (type.IsValueType || exact) return Expression.Convert(expr, type);
                return expr;
            }
            return null;
        }

        private static object ParseNumber(string text, Type type)
        {
            switch (Type.GetTypeCode(GetNonNullableType(type)))
            {
                case TypeCode.SByte:
                    sbyte sb;
                    if (sbyte.TryParse(text, out sb)) return sb;
                    break;

                case TypeCode.Byte:
                    byte b;
                    if (byte.TryParse(text, out b)) return b;
                    break;

                case TypeCode.Int16:
                    short s;
                    if (short.TryParse(text, out s)) return s;
                    break;

                case TypeCode.UInt16:
                    ushort us;
                    if (ushort.TryParse(text, out us)) return us;
                    break;

                case TypeCode.Int32:
                    int i;
                    if (int.TryParse(text, out i)) return i;
                    break;

                case TypeCode.UInt32:
                    uint ui;
                    if (uint.TryParse(text, out ui)) return ui;
                    break;

                case TypeCode.Int64:
                    long l;
                    if (long.TryParse(text, out l)) return l;
                    break;

                case TypeCode.UInt64:
                    ulong ul;
                    if (ulong.TryParse(text, out ul)) return ul;
                    break;

                case TypeCode.Single:
                    float f;
                    if (float.TryParse(text, out f)) return f;
                    break;

                case TypeCode.Double:
                    double d;
                    if (double.TryParse(text, out d)) return d;
                    break;

                case TypeCode.Decimal:
                    decimal e;
                    if (decimal.TryParse(text, out e)) return e;
                    break;
            }
            return null;
        }

        private static object ParseEnum(string name, Type type)
        {
            if (type.IsEnum)
            {
                MemberInfo[] memberInfos = type.FindMembers(MemberTypes.Field,
                    BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Static,
                    Type.FilterNameIgnoreCase, name);
                if (memberInfos.Length != 0) return ((FieldInfo)memberInfos[0]).GetValue(null);
            }
            return null;
        }

        private static bool IsCompatibleWith(Type source, Type target)
        {
            if (source == target) return true;
            if (!target.IsValueType) return target.IsAssignableFrom(source);
            Type st = GetNonNullableType(source);
            Type tt = GetNonNullableType(target);
            if (st != source && tt == target) return false;
            TypeCode sc = st.IsEnum ? TypeCode.Object : Type.GetTypeCode(st);
            TypeCode tc = tt.IsEnum ? TypeCode.Object : Type.GetTypeCode(tt);
            switch (sc)
            {
                case TypeCode.SByte:
                    switch (tc)
                    {
                        case TypeCode.SByte:
                        case TypeCode.Int16:
                        case TypeCode.Int32:
                        case TypeCode.Int64:
                        case TypeCode.Single:
                        case TypeCode.Double:
                        case TypeCode.Decimal:
                            return true;
                    }
                    break;

                case TypeCode.Byte:
                    switch (tc)
                    {
                        case TypeCode.Byte:
                        case TypeCode.Int16:
                        case TypeCode.UInt16:
                        case TypeCode.Int32:
                        case TypeCode.UInt32:
                        case TypeCode.Int64:
                        case TypeCode.UInt64:
                        case TypeCode.Single:
                        case TypeCode.Double:
                        case TypeCode.Decimal:
                            return true;
                    }
                    break;

                case TypeCode.Int16:
                    switch (tc)
                    {
                        case TypeCode.Int16:
                        case TypeCode.Int32:
                        case TypeCode.Int64:
                        case TypeCode.Single:
                        case TypeCode.Double:
                        case TypeCode.Decimal:
                            return true;
                    }
                    break;

                case TypeCode.UInt16:
                    switch (tc)
                    {
                        case TypeCode.UInt16:
                        case TypeCode.Int32:
                        case TypeCode.UInt32:
                        case TypeCode.Int64:
                        case TypeCode.UInt64:
                        case TypeCode.Single:
                        case TypeCode.Double:
                        case TypeCode.Decimal:
                            return true;
                    }
                    break;

                case TypeCode.Int32:
                    switch (tc)
                    {
                        case TypeCode.Int32:
                        case TypeCode.Int64:
                        case TypeCode.Single:
                        case TypeCode.Double:
                        case TypeCode.Decimal:
                            return true;
                    }
                    break;

                case TypeCode.UInt32:
                    switch (tc)
                    {
                        case TypeCode.UInt32:
                        case TypeCode.Int64:
                        case TypeCode.UInt64:
                        case TypeCode.Single:
                        case TypeCode.Double:
                        case TypeCode.Decimal:
                            return true;
                    }
                    break;

                case TypeCode.Int64:
                    switch (tc)
                    {
                        case TypeCode.Int64:
                        case TypeCode.Single:
                        case TypeCode.Double:
                        case TypeCode.Decimal:
                            return true;
                    }
                    break;

                case TypeCode.UInt64:
                    switch (tc)
                    {
                        case TypeCode.UInt64:
                        case TypeCode.Single:
                        case TypeCode.Double:
                        case TypeCode.Decimal:
                            return true;
                    }
                    break;

                case TypeCode.Single:
                    switch (tc)
                    {
                        case TypeCode.Single:
                        case TypeCode.Double:
                            return true;
                    }
                    break;

                default:
                    if (st == tt) return true;
                    break;
            }
            return false;
        }

        private static bool IsBetterThan(Expression[] args, MethodData m1, MethodData m2)
        {
            bool better = false;
            for (int i = 0; i < args.Length; i++)
            {
                int c = CompareConversions(args[i].Type,
                    m1.Parameters[i].ParameterType,
                    m2.Parameters[i].ParameterType);
                if (c < 0) return false;
                if (c > 0) better = true;
            }
            return better;
        }

        // Return 1 if s -> t1 is a better conversion than s -> t2
        // Return -1 if s -> t2 is a better conversion than s -> t1
        // Return 0 if neither conversion is better
        private static int CompareConversions(Type s, Type t1, Type t2)
        {
            if (t1 == t2) return 0;
            if (s == t1) return 1;
            if (s == t2) return -1;
            bool t1t2 = IsCompatibleWith(t1, t2);
            bool t2t1 = IsCompatibleWith(t2, t1);
            if (t1t2 && !t2t1) return 1;
            if (t2t1 && !t1t2) return -1;
            if (IsSignedIntegralType(t1) && IsUnsignedIntegralType(t2)) return 1;
            if (IsSignedIntegralType(t2) && IsUnsignedIntegralType(t1)) return -1;
            return 0;
        }

        private Expression GenerateEqual(Expression left, Expression right)
        {
            return Expression.Equal(left, right);
        }

        private Expression GenerateNotEqual(Expression left, Expression right)
        {
            return Expression.NotEqual(left, right);
        }

        private Expression GenerateGreaterThan(Expression left, Expression right)
        {
            if (left.Type == typeof(string))
            {
                return Expression.GreaterThan(
                    GenerateStaticMethodCall("Compare", left, right),
                    Expression.Constant(0)
                );
            }
            return Expression.GreaterThan(left, right);
        }

        private Expression GenerateGreaterThanEqual(Expression left, Expression right)
        {
            if (left.Type == typeof(string))
            {
                return Expression.GreaterThanOrEqual(
                    GenerateStaticMethodCall("Compare", left, right),
                    Expression.Constant(0)
                );
            }
            return Expression.GreaterThanOrEqual(left, right);
        }

        private Expression GenerateLessThan(Expression left, Expression right)
        {
            if (left.Type == typeof(string))
            {
                return Expression.LessThan(
                    GenerateStaticMethodCall("Compare", left, right),
                    Expression.Constant(0)
                );
            }
            return Expression.LessThan(left, right);
        }

        private Expression GenerateLessThanEqual(Expression left, Expression right)
        {
            if (left.Type == typeof(string))
            {
                return Expression.LessThanOrEqual(
                    GenerateStaticMethodCall("Compare", left, right),
                    Expression.Constant(0)
                );
            }
            return Expression.LessThanOrEqual(left, right);
        }

        private Expression GenerateAdd(Expression left, Expression right)
        {
            if (left.Type == typeof(string) && right.Type == typeof(string))
            {
                return GenerateStaticMethodCall("Concat", left, right);
            }
            return Expression.Add(left, right);
        }

        private Expression GenerateSubtract(Expression left, Expression right)
        {
            return Expression.Subtract(left, right);
        }

        private Expression GenerateStringConcat(Expression left, Expression right)
        {
            return Expression.Call(
                null,
                typeof(string).GetMethod("Concat", new[] { typeof(object), typeof(object) }),
                new[] { left, right });
        }

        private MethodInfo GetStaticMethod(string methodName, Expression left, Expression right)
        {
            return left.Type.GetMethod(methodName, new[] { left.Type, right.Type });
        }

        private Expression GenerateStaticMethodCall(string methodName, Expression left, Expression right)
        {
            return Expression.Call(null, GetStaticMethod(methodName, left, right), new[] { left, right });
        }

        private void SetTextPos(int pos)
        {
            textPos = pos;
            ch = textPos < textLen ? text[textPos] : '\0';
        }

        private void NextChar()
        {
            if (textPos < textLen) textPos++;
            ch = textPos < textLen ? text[textPos] : '\0';
        }

        private void NextToken()
        {
            while (Char.IsWhiteSpace(ch)) NextChar();
            TokenId t;
            int tokenPos = textPos;
            switch (ch)
            {
                case '!':
                    NextChar();
                    if (ch == '=')
                    {
                        NextChar();
                        t = TokenId.ExclamationEqual;
                    }
                    else
                    {
                        t = TokenId.Exclamation;
                    }
                    break;

                case '%':
                    NextChar();
                    t = TokenId.Percent;
                    break;

                case '&':
                    NextChar();
                    if (ch == '&')
                    {
                        NextChar();
                        t = TokenId.DoubleAmphersand;
                    }
                    else
                    {
                        t = TokenId.Amphersand;
                    }
                    break;

                case '(':
                    NextChar();
                    t = TokenId.OpenParen;
                    break;

                case ')':
                    NextChar();
                    t = TokenId.CloseParen;
                    break;

                case '*':
                    NextChar();
                    t = TokenId.Asterisk;
                    break;

                case '+':
                    NextChar();
                    t = TokenId.Plus;
                    break;

                case ',':
                    NextChar();
                    t = TokenId.Comma;
                    break;

                case '-':
                    NextChar();
                    t = TokenId.Minus;
                    break;

                case '.':
                    NextChar();
                    t = TokenId.Dot;
                    break;

                case '/':
                    NextChar();
                    t = TokenId.Slash;
                    break;

                case ':':
                    NextChar();
                    t = TokenId.Colon;
                    break;

                case '<':
                    NextChar();
                    if (ch == '=')
                    {
                        NextChar();
                        t = TokenId.LessThanEqual;
                    }
                    else if (ch == '>')
                    {
                        NextChar();
                        t = TokenId.LessGreater;
                    }
                    else
                    {
                        t = TokenId.LessThan;
                    }
                    break;

                case '=':
                    NextChar();
                    if (ch == '=')
                    {
                        NextChar();
                        t = TokenId.DoubleEqual;
                    }
                    else
                    {
                        t = TokenId.Equal;
                    }
                    break;

                case '>':
                    NextChar();
                    if (ch == '=')
                    {
                        NextChar();
                        t = TokenId.GreaterThanEqual;
                    }
                    else
                    {
                        t = TokenId.GreaterThan;
                    }
                    break;

                case '?':
                    NextChar();
                    t = TokenId.Question;
                    break;

                case '[':
                    NextChar();
                    t = TokenId.OpenBracket;
                    break;

                case ']':
                    NextChar();
                    t = TokenId.CloseBracket;
                    break;

                case '|':
                    NextChar();
                    if (ch == '|')
                    {
                        NextChar();
                        t = TokenId.DoubleBar;
                    }
                    else
                    {
                        t = TokenId.Bar;
                    }
                    break;

                case '"':
                case '\'':
                    char quote = ch;
                    do
                    {
                        NextChar();
                        while (textPos < textLen && ch != quote) NextChar();
                        if (textPos == textLen)
                            throw ParseError(textPos, Res.UnterminatedStringLiteral);
                        NextChar();
                    } while (ch == quote);
                    t = TokenId.StringLiteral;
                    break;

                default:
                    if (Char.IsLetter(ch) || ch == '@' || ch == '_')
                    {
                        do
                        {
                            NextChar();
                        } while (Char.IsLetterOrDigit(ch) || ch == '_');
                        t = TokenId.Identifier;
                        break;
                    }
                    if (Char.IsDigit(ch))
                    {
                        t = TokenId.IntegerLiteral;
                        do
                        {
                            NextChar();
                        } while (Char.IsDigit(ch));
                        if (ch == '.')
                        {
                            t = TokenId.RealLiteral;
                            NextChar();
                            ValidateDigit();
                            do
                            {
                                NextChar();
                            } while (Char.IsDigit(ch));
                        }
                        if (ch == 'E' || ch == 'e')
                        {
                            t = TokenId.RealLiteral;
                            NextChar();
                            if (ch == '+' || ch == '-') NextChar();
                            ValidateDigit();
                            do
                            {
                                NextChar();
                            } while (Char.IsDigit(ch));
                        }
                        if (ch == 'F' || ch == 'f') NextChar();
                        break;
                    }
                    if (textPos == textLen)
                    {
                        t = TokenId.End;
                        break;
                    }
                    throw ParseError(textPos, Res.InvalidCharacter, ch);
            }
            token.id = t;
            token.text = text.Substring(tokenPos, textPos - tokenPos);
            token.pos = tokenPos;
        }

        private bool TokenIdentifierIs(string id)
        {
            return token.id == TokenId.Identifier && String.Equals(id, token.text, StringComparison.OrdinalIgnoreCase);
        }

        private string GetIdentifier()
        {
            ValidateToken(TokenId.Identifier, Res.IdentifierExpected);
            string id = token.text;
            if (id.Length > 1 && id[0] == '@') id = id.Substring(1);
            return id;
        }

        private void ValidateDigit()
        {
            if (!Char.IsDigit(ch)) throw ParseError(textPos, Res.DigitExpected);
        }

        private void ValidateToken(TokenId t, string errorMessage)
        {
            if (token.id != t) throw ParseError(errorMessage);
        }

        private void ValidateToken(TokenId t)
        {
            if (token.id != t) throw ParseError(Res.SyntaxError);
        }

        private Exception ParseError(string format, params object[] args)
        {
            return ParseError(token.pos, format, args);
        }

        private Exception ParseError(int pos, string format, params object[] args)
        {
            return new ParseException(string.Format(System.Globalization.CultureInfo.CurrentCulture, format, args), pos);
        }

        private static Dictionary<string, object> CreateKeywords()
        {
            Dictionary<string, object> d = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            d.Add("true", trueLiteral);
            d.Add("false", falseLiteral);
            d.Add("null", nullLiteral);
            d.Add(keywordIt, keywordIt);
            d.Add(keywordIif, keywordIif);
            d.Add(keywordNew, keywordNew);
            foreach (Type type in predefinedTypes) d.Add(type.Name, type);
            return d;
        }
    }

    internal static class Res
    {
        public const string DuplicateIdentifier = "The identifier '{0}' was defined more than once";
        public const string ExpressionTypeMismatch = "Expression of type '{0}' expected";
        public const string ExpressionExpected = "Expression expected";
        public const string InvalidCharacterLiteral = "Character literal must contain exactly one character";
        public const string InvalidIntegerLiteral = "Invalid integer literal '{0}'";
        public const string InvalidRealLiteral = "Invalid real literal '{0}'";
        public const string UnknownIdentifier = "Unknown identifier '{0}'";
        public const string NoItInScope = "No 'it' is in scope";
        public const string IifRequiresThreeArgs = "The 'iif' function requires three arguments";
        public const string FirstExprMustBeBool = "The first expression must be of type 'Boolean'";
        public const string BothTypesConvertToOther = "Both of the types '{0}' and '{1}' convert to the other";
        public const string NeitherTypeConvertsToOther = "Neither of the types '{0}' and '{1}' converts to the other";
        public const string MissingAsClause = "Expression is missing an 'as' clause";
        public const string ArgsIncompatibleWithLambda = "Argument list incompatible with lambda expression";
        public const string TypeHasNoNullableForm = "Type '{0}' has no nullable form";
        public const string NoMatchingConstructor = "No matching constructor in type '{0}'";
        public const string AmbiguousConstructorInvocation = "Ambiguous invocation of '{0}' constructor";
        public const string CannotConvertValue = "A value of type '{0}' cannot be converted to type '{1}'";
        public const string NoApplicableMethod = "No applicable method '{0}' exists in type '{1}'";
        public const string MethodsAreInaccessible = "Methods on type '{0}' are not accessible";
        public const string MethodIsVoid = "Method '{0}' in type '{1}' does not return a value";
        public const string AmbiguousMethodInvocation = "Ambiguous invocation of method '{0}' in type '{1}'";
        public const string UnknownPropertyOrField = "No property or field '{0}' exists in type '{1}'";
        public const string NoApplicableAggregate = "No applicable aggregate method '{0}' exists";
        public const string CannotIndexMultiDimArray = "Indexing of multi-dimensional arrays is not supported";
        public const string InvalidIndex = "Array index must be an integer expression";
        public const string NoApplicableIndexer = "No applicable indexer exists in type '{0}'";
        public const string AmbiguousIndexerInvocation = "Ambiguous invocation of indexer in type '{0}'";
        public const string IncompatibleOperand = "Operator '{0}' incompatible with operand type '{1}'";
        public const string IncompatibleOperands = "Operator '{0}' incompatible with operand types '{1}' and '{2}'";
        public const string UnterminatedStringLiteral = "Unterminated string literal";
        public const string InvalidCharacter = "Syntax error '{0}'";
        public const string DigitExpected = "Digit expected";
        public const string SyntaxError = "Syntax error";
        public const string TokenExpected = "{0} expected";
        public const string ParseExceptionFormat = "{0} (at index {1})";
        public const string ColonExpected = "':' expected";
        public const string OpenParenExpected = "'(' expected";
        public const string CloseParenOrOperatorExpected = "')' or operator expected";
        public const string CloseParenOrCommaExpected = "')' or ',' expected";
        public const string DotOrOpenParenExpected = "'.' or '(' expected";
        public const string OpenBracketExpected = "'[' expected";
        public const string CloseBracketOrCommaExpected = "']' or ',' expected";
        public const string IdentifierExpected = "Identifier expected";
    }
}
````

## File: Infraestructura/Core/EntityMapping.cs
````csharp
namespace Infraestructura.Core
{
    public class EntityMapping
    {
        public Type EntityType { get; set; }
        public string TableName { get; set; }
        public string TransactionTableName { get; set; }
    }
}
````

## File: Infraestructura/Core/Exception/ThrowIf.cs
````csharp
using Dominio.Core.Extensions;

namespace Infraestructura.Core.Exception
{
     /// <summary>
    /// Exception Helper Class for Parameter Checking.
    /// </summary>
    public static class ThrowIf
    {
        public static class Argument
        {
            /// <summary>
            /// Argument Null Checking
            /// </summary>
            /// <param name="argument">The argument to check.</param>
            /// <param name="argumentName">The argument's name.</param>
            public static void IsNull(object argument, string argumentName) 
            {
                if (argument.IsNull()) throw new ArgumentNullException(argumentName);
            }

            /// <summary>
            /// Argument Null or WhiteSpace Checking
            /// </summary>
            /// <param name="argument">The argument to check.</param>
            /// <param name="argumentName">The argument's name.</param>
            public static void IsNullOrWhiteSpace(string argument, string argumentName)
            {
                if (argument.IsMissingValue()) throw new ArgumentNullException("Argument should not be null or white space", argumentName);
            }

            public static void IsZeroOrNegative(decimal argument, string argumentName)
            {
                if (argument <= 0)
                {
                    throw new ArgumentException("Argument should neither zero nor negative", argumentName);
                }
            }
        }
    }
}
````

## File: Infraestructura/Core/Identity/TransactionIdentity.cs
````csharp
namespace Infraestructura.Core.Identity
{
    public class TransactionIdentity
    {
        /// <summary>
        /// Identity's transaction.
        /// </summary>
        public Guid TransactionId { get; set; }

        /// <summary>
        /// Server's Date and Time
        /// </summary>
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// UTC date and time for the transaction.
        /// </summary>
        public DateTime TransactionUtcDate { get; set; }
    }
}
````

## File: Infraestructura/Core/IQueryableUnitOfWork.cs
````csharp
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Core
{
    /// <summary>
    /// The UnitOfWork contract for EF implementation
    /// <remarks>
    /// This contract extend IUnitOfWork for use with EF code
    /// </remarks>
    /// </summary>
    public interface IQueryableUnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Returns a IDbSet instance for access to entities of the given type in the context,
        /// the ObjectStateManager, and the underlying store.
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        DbSet<TEntity> CreateSet<TEntity>() where TEntity : class;

        /// <summary>
        /// Attach this item into "ObjectStateManager"
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        void Attach<TEntity>(TEntity entity) where TEntity : class;

        /// <summary>
        /// Se object as modified
        /// </summary>
        /// <typeparam name="TEntity">The type of entity</typeparam>
        /// <param name="item">The entity item to se as modified</param>
        void SetModified<TEntity>(TEntity item) where TEntity : class;

        /// <summary>
        /// Apply current values in <paramref name="original"/>
        /// </summary>
        /// <typeparam name="TEntity">The type of entity</typeparam>
        /// <param name="original">The original entity</param>
        /// <param name="current">The current entity</param>
        void ApplyCurrentValues<TEntity>(TEntity original, TEntity current) where TEntity : class;

        /// <summary>
        /// Execute arbitrary command into underliying persistence store
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// Command to execute
        /// <example>
        /// Select idCustomer, Name From dbo.[Customers] where idCustomer > {0}
        /// </example>
        /// <param name="parameters">A vector of parameters values</param>
        /// <returns>The number of affected records</returns>
        int ExecuteCommand(string sqlCommand, params object[] parameters);

        /// <summary>
        /// Execute specific query with underliying persistence store
        /// </summary>
        /// <typeparam name="TEntity">Entity type to map query results</typeparam>
        /// <param name="sqlCommand">
        /// Dialect Query
        /// <example>
        /// Select idCustomer, Name From dbo.[Customers] where idCustomer > {0}
        /// </example>
        /// </param>
        /// <param name="parameters">A vector of parameters values</param>
        /// <returns>
        /// Enumerable results
        /// </returns>
        IEnumerable<TEntity> ExecuteQuery<TEntity>(string sqlCommand, params object[] parameters);

        TType ExecuteScalarFunction<TType>(string scalarFunction, params object[] parameters);

        /// <summary>
        /// Execute specific query with underliying persistence store
        /// </summary>
        /// <typeparam name="TEntity">Entity type to map query results</typeparam>
        /// <param name="sqlCommand">
        /// Dialect sqlCommand
        /// <example>
        /// Select idCustomer, Name From dbo.[Customers] where idCustomer > {0}
        /// </example>
        /// </param>
        /// <param name="parameters">A vector of parameters values</param>
        /// <returns>
        /// Enumerable results
        /// </returns>
        Task<IEnumerable<TEntity>> ExecuteQueryAsync<TEntity>(string sqlCommand, params object[] parameters) where TEntity: class;
    }
}
````

## File: Infraestructura/Core/IUnitOfWork.cs
````csharp
using Dominio.Core;

namespace Infraestructura.Core
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Commit all changes made in a container.
        /// </summary>
        ///<remarks>
        ///If the entity have fixed properties and any optimistic concurrency problem exist,
        ///then and exception is thrown.
        ///</remarks> 
        void Commit();

        /// <summary>
        /// Commit all changes made a container.
        /// </summary>
        /// <remarks>
        /// If the entity have fixed properties and any optimistic concurrency problem exist,
        /// then an exception is thrown.
        /// Also log information for the transaction
        /// </remarks>
        /// <param name="transactionInfo">Client's information to add to the transaction's info</param>
        void Commit(TransactionInfo transactionInfo);
    }
}
````

## File: Infraestructura/Core/Logging/Transaction.cs
````csharp
namespace Infraestructura.Core.Logging
{
    public class Transaction
    {
        public Transaction()
        {
            TransactionDetail = new List<TransactionDetail>();
        }

        public Guid TransactionId { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public string ModifiedBy { get; set; }
        public string TransactionOrigen { get; set; }
        public List<TransactionDetail> TransactionDetail { get; set; }

        public void AddDetail(string tableName, string crudOperation, string transactionType)
        {
            if (TransactionDetail.FirstOrDefault(t => t.TableName == tableName) == null)
            {
                TransactionDetail.Add(
                    new TransactionDetail
                    {
                        TransactionId = TransactionId,
                        TableName = tableName,
                        CrudOperation = crudOperation,
                        TransactionType = transactionType
                    });
            }
        }
    }
}
````

## File: Infraestructura/Core/Logging/TransactionDetail.cs
````csharp
namespace Infraestructura.Core.Logging
{
    public class TransactionDetail
    {
        public Guid TransactionId { get; set; }
        public string TableName { get; set; }
        public string CrudOperation { get; set; }
        public string TransactionType { get; set; }
    }
}
````

## File: Infraestructura/Core/ModifiedEntityEntry.cs
````csharp
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Infraestructura.Core
{
    internal class ModifiedEntityEntry
    {
        public EntityEntry EntityEntry
        {
            get { return _entityEntry; }
        }

        private EntityEntry _entityEntry;

        public string State
        {
            get { return _state; }
        }
        private string _state;

        public ModifiedEntityEntry(EntityEntry entityEntry, string state)
        {
            _entityEntry = entityEntry;
            _state = state;
        }
    }
}
````

## File: Infraestructura/Core/RestClient/HttpRestClientFactory.cs
````csharp
using Infraestructura.Core.Exception;
using System.Net.Http.Headers;

namespace Infraestructura.Core.RestClient
{
    public sealed class HttpRestClientFactory : IRestClientFactory
    {
        private readonly Dictionary<string, HttpClient> _httpClients = new Dictionary<string, HttpClient>();

        public IRestClient Create(string baseAddress)
        {
            ThrowIf.Argument.IsNullOrWhiteSpace(baseAddress, nameof(baseAddress));

            HttpClient httpClient;

            if (_httpClients.ContainsKey(baseAddress) && _httpClients[baseAddress] != null)
            {
                httpClient = _httpClients[baseAddress];
            }
            else
            {
                httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(baseAddress);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(@"application/json"));

                if (_httpClients.ContainsKey(baseAddress))
                {
                    _httpClients.Remove(baseAddress);
                }

                _httpClients.Add(baseAddress, httpClient);
            }

            return new HttpRestClient(httpClient);
        }
    }
}
````

## File: Infraestructura/Core/RestClient/IRestClient.cs
````csharp
namespace Infraestructura.Core.RestClient
{
    /// <summary>
    /// HTTP rest client contract to interact with REST APIS.
    /// </summary>
    public interface IRestClient
    {
        /// <summary>
        /// Sends a GET request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <param name="uri">The Uri the request is sent to.</param>
        /// <remarks>
        /// This operation will not block. The returned task object will complete after the whole response (including content) is read.
        /// </remarks>
        /// <returns>The task object of type <see cref="TResponse"/> representing the asynchronous operation.</returns>
        Task<TResponse> GetAsync<TResponse>(string uri) where TResponse : class;

        /// <summary>
        /// Sends a POST request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// <typeparam name="TContent">The HTTP request content type.</typeparam>
        /// <typeparam name="TResponse">The HTTP request response type.</typeparam>
        /// <param name="uri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <remarks>This operation will not block. The returned task object will complete after the whole response (including content) is read.</remarks>
        /// <returns>The task object of type <see cref="TResponse"/> representing the asynchronous operation.</returns>
        Task<TResponse> PostAsync<TContent, TResponse>(string uri, TContent content)
            where TContent : class
            where TResponse : class;

        /// <summary>
        /// Sends a PUT request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// <typeparam name="TContent">The HTTP request content type.</typeparam>
        /// <typeparam name="TResponse">The HTTP request response type.</typeparam>
        /// <param name="uri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <remarks>This operation will not block. The returned task object will complete after the whole response (including content) is read.</remarks>
        /// <returns>The task object of type <see cref="TResponse"/> representing the asynchronous operation.</returns>
        Task<TResponse> PutAsync<TContent, TResponse>(string uri, TContent content)
            where TContent : class
            where TResponse : class;

        /// <summary>
        /// Sends a PATCH request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// <typeparam name="TContent">The HTTP request content type.</typeparam>
        /// <typeparam name="TResponse">The HTTP request response type.</typeparam>
        /// <param name="uri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <remarks>This operation will not block. The returned task object will complete after the whole response (including content) is read.</remarks>
        /// <returns>The task object of type <see cref="TResponse"/> representing the asynchronous operation.</returns>
        Task<TResponse> PatchAsync<TContent, TResponse>(string uri, TContent content)
            where TContent : class
            where TResponse : class;

        /// <summary>
        /// Sends a DELETE request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// <typeparam name="TContent">The HTTP request content type.</typeparam>
        /// <typeparam name="TResponse">The HTTP request response type.</typeparam>
        /// <param name="uri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <remarks>This operation will not block. The returned task object will complete after the whole response (including content) is read.</remarks>
        /// <returns>The task object of type <see cref="TResponse"/> representing the asynchronous operation.</returns>
        Task<TResponse> DeleteAsync<TContent, TResponse>(string uri, TContent content)
            where TContent : class
            where TResponse : class;
    }
}
````

## File: Infraestructura/Core/RestClient/IRestClientFactory.cs
````csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Core.RestClient
{
    public interface IRestClientFactory
    {
        /// <summary>
        /// Gets a <see cref="IRestClient"/> client.
        /// </summary>
        /// <param name="baseAddress">The base API address to consume.</param>
        /// <returns>The <see cref="IRestClient"/>.</returns>
        IRestClient Create(string baseAddress);
    }
}
````

## File: Infraestructura/Core/SqlCommandInfo.cs
````csharp
namespace Infraestructura.Core
{
    public class SqlCommandInfo
    {
        public SqlCommandInfo(string sql, object[] parameters)
        {
            Sql = sql;
            Parameters = parameters;
        }

        public string Sql { get; set; }
        public object[] Parameters { get; set; }
    }
}
````

## File: Infraestructura/Core/TransactionScopeFactory.cs
````csharp
using System.Transactions;

namespace Infraestructura.Core
{
    public static class TransactionScopeFactory
    {
        public static TransactionScope GetTransactionScope()
        {
            var transactionOptions = new TransactionOptions
            {
                IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted,
                Timeout = TransactionManager.MaximumTimeout
            };

            return new TransactionScope(TransactionScopeOption.Required, transactionOptions);
        }
    }
}
````

## File: Infraestructura/Migrations/20260529013725_AddRefreshToken.cs
````csharp
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class AddRefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "comunes");

            migrationBuilder.EnsureSchema(
                name: "Comunes");

            migrationBuilder.EnsureSchema(
                name: "Seguridad");

            migrationBuilder.CreateTable(
                name: "Configuraciones",
                schema: "comunes",
                columns: table => new
                {
                    ConfiguracionId = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ModificadoPor = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    FechaTransaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescripcionTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TransaccionUId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuraciones", x => x.ConfiguracionId);
                });

            migrationBuilder.CreateTable(
                name: "Pantalla",
                schema: "Seguridad",
                columns: table => new
                {
                    PantallaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    ModificadoPor = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    FechaTransaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescripcionTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TransaccionUId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pantalla", x => x.PantallaId);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                schema: "Seguridad",
                columns: table => new
                {
                    RolId = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    ModificadoPor = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    FechaTransaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescripcionTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TransaccionUId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "ConfiguracionesDetalle",
                schema: "Comunes",
                columns: table => new
                {
                    ConfiguracionId = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Atributo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Valor = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModificadoPor = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    FechaTransaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescripcionTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TransaccionUId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracionesDetalle", x => new { x.ConfiguracionId, x.Atributo });
                    table.ForeignKey(
                        name: "FK_ConfiguracionesDetalle_Configuraciones_ConfiguracionId",
                        column: x => x.ConfiguracionId,
                        principalSchema: "comunes",
                        principalTable: "Configuraciones",
                        principalColumn: "ConfiguracionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                schema: "Seguridad",
                columns: table => new
                {
                    RolId = table.Column<string>(type: "varchar(25)", nullable: false),
                    PantallaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ver = table.Column<bool>(type: "bit", nullable: false),
                    Editar = table.Column<bool>(type: "bit", nullable: false),
                    Eliminar = table.Column<bool>(type: "bit", nullable: false),
                    ModificadoPor = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    FechaTransaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescripcionTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TransaccionUId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => new { x.RolId, x.PantallaId });
                    table.ForeignKey(
                        name: "FK_Permisos_Rol_RolId",
                        column: x => x.RolId,
                        principalSchema: "Seguridad",
                        principalTable: "Rol",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                schema: "Seguridad",
                columns: table => new
                {
                    UsuarioId = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    RolId = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModificadoPor = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    FechaTransaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescripcionTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TransaccionUId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_Rol_RolId",
                        column: x => x.RolId,
                        principalSchema: "Seguridad",
                        principalTable: "Rol",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_RolId",
                schema: "Seguridad",
                table: "Usuario",
                column: "RolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfiguracionesDetalle",
                schema: "Comunes");

            migrationBuilder.DropTable(
                name: "Pantalla",
                schema: "Seguridad");

            migrationBuilder.DropTable(
                name: "Permisos",
                schema: "Seguridad");

            migrationBuilder.DropTable(
                name: "Usuario",
                schema: "Seguridad");

            migrationBuilder.DropTable(
                name: "Configuraciones",
                schema: "comunes");

            migrationBuilder.DropTable(
                name: "Rol",
                schema: "Seguridad");
        }
    }
}
````

## File: Infraestructura/Migrations/20260529013725_AddRefreshToken.Designer.cs
````csharp
// <auto-generated />
using System;
using Infraestructura.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infraestructura.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20260529013725_AddRefreshToken")]
    partial class AddRefreshToken
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dominio.Context.Entidades.ConfiguracionesAgg.Configuraciones", b =>
                {
                    b.Property<string>("ConfiguracionId")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("ConfiguracionId");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Descripcion");

                    b.Property<string>("DescripcionTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("DescripcionTransaccion");

                    b.Property<DateTime>("FechaTransaccion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaTransaccion");

                    b.Property<string>("ModificadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("ModificadoPor");

                    b.Property<byte[]>("RowVersion")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("RowVersion");

                    b.Property<string>("TipoTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TipoTransaccion");

                    b.Property<Guid>("TransaccionUId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TransaccionUId");

                    b.HasKey("ConfiguracionId");

                    b.ToTable("Configuraciones", "comunes");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.ConfiguracionesAgg.ConfiguracionesDetalle", b =>
                {
                    b.Property<string>("ConfiguracionId")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("ConfiguracionId");

                    b.Property<string>("Atributo")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Atributo");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Descripcion");

                    b.Property<string>("DescripcionTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("DescripcionTransaccion");

                    b.Property<DateTime>("FechaTransaccion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaTransaccion");

                    b.Property<string>("ModificadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("ModificadoPor");

                    b.Property<byte[]>("RowVersion")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("RowVersion");

                    b.Property<string>("TipoTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TipoTransaccion");

                    b.Property<Guid>("TransaccionUId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TransaccionUId");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Valor");

                    b.HasKey("ConfiguracionId", "Atributo");

                    b.ToTable("ConfiguracionesDetalle", "Comunes");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.Seguridad.Pantalla", b =>
                {
                    b.Property<string>("PantallaId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("PantallaId");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("Descripcion");

                    b.Property<string>("DescripcionTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("DescripcionTransaccion");

                    b.Property<DateTime>("FechaTransaccion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaTransaccion");

                    b.Property<string>("ModificadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("ModificadoPor");

                    b.Property<byte[]>("RowVersion")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("RowVersion");

                    b.Property<string>("TipoTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TipoTransaccion");

                    b.Property<Guid>("TransaccionUId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TransaccionUId");

                    b.HasKey("PantallaId");

                    b.ToTable("Pantalla", "Seguridad");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.Seguridad.Permisos", b =>
                {
                    b.Property<string>("RolId")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("RolId");

                    b.Property<string>("PantallaId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("PantallaId");

                    b.Property<string>("DescripcionTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("DescripcionTransaccion");

                    b.Property<bool>("Editar")
                        .HasColumnType("bit")
                        .HasColumnName("Editar");

                    b.Property<bool>("Eliminar")
                        .HasColumnType("bit")
                        .HasColumnName("Eliminar");

                    b.Property<DateTime>("FechaTransaccion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaTransaccion");

                    b.Property<string>("ModificadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("ModificadoPor");

                    b.Property<byte[]>("RowVersion")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("RowVersion");

                    b.Property<string>("TipoTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TipoTransaccion");

                    b.Property<Guid>("TransaccionUId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TransaccionUId");

                    b.Property<bool>("Ver")
                        .HasColumnType("bit")
                        .HasColumnName("Ver");

                    b.HasKey("RolId", "PantallaId");

                    b.ToTable("Permisos", "Seguridad");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.Seguridad.Rol", b =>
                {
                    b.Property<string>("RolId")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("RolId");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("Descripcion");

                    b.Property<string>("DescripcionTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("DescripcionTransaccion");

                    b.Property<DateTime>("FechaTransaccion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaTransaccion");

                    b.Property<string>("ModificadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("ModificadoPor");

                    b.Property<byte[]>("RowVersion")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("RowVersion");

                    b.Property<string>("TipoTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TipoTransaccion");

                    b.Property<Guid>("TransaccionUId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TransaccionUId");

                    b.HasKey("RolId");

                    b.ToTable("Rol", "Seguridad");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.Seguridad.Usuario", b =>
                {
                    b.Property<string>("UsuarioId")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("UsuarioId");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit")
                        .HasColumnName("Activo");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Apellido");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("Contrasena");

                    b.Property<string>("DescripcionTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("DescripcionTransaccion");

                    b.Property<DateTime>("FechaTransaccion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaTransaccion");

                    b.Property<string>("ModificadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("ModificadoPor");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombre");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("RolId")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("RolId");

                    b.Property<byte[]>("RowVersion")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("RowVersion");

                    b.Property<string>("TipoTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TipoTransaccion");

                    b.Property<Guid>("TransaccionUId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TransaccionUId");

                    b.HasKey("UsuarioId");

                    b.HasIndex("RolId");

                    b.ToTable("Usuario", "Seguridad");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.ConfiguracionesAgg.ConfiguracionesDetalle", b =>
                {
                    b.HasOne("Dominio.Context.Entidades.ConfiguracionesAgg.Configuraciones", "Configuraciones")
                        .WithMany("ConfiguracionesDetalle")
                        .HasForeignKey("ConfiguracionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Configuraciones");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.Seguridad.Permisos", b =>
                {
                    b.HasOne("Dominio.Context.Entidades.Seguridad.Rol", "Rol")
                        .WithMany("Permisos")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.Seguridad.Usuario", b =>
                {
                    b.HasOne("Dominio.Context.Entidades.Seguridad.Rol", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.ConfiguracionesAgg.Configuraciones", b =>
                {
                    b.Navigation("ConfiguracionesDetalle");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.Seguridad.Rol", b =>
                {
                    b.Navigation("Permisos");

                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
````

## File: Infraestructura/Migrations/MyContextModelSnapshot.cs
````csharp
// <auto-generated />
using System;
using Infraestructura.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infraestructura.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dominio.Context.Entidades.ConfiguracionesAgg.Configuraciones", b =>
                {
                    b.Property<string>("ConfiguracionId")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("ConfiguracionId");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Descripcion");

                    b.Property<string>("DescripcionTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("DescripcionTransaccion");

                    b.Property<DateTime>("FechaTransaccion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaTransaccion");

                    b.Property<string>("ModificadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("ModificadoPor");

                    b.Property<byte[]>("RowVersion")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("RowVersion");

                    b.Property<string>("TipoTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TipoTransaccion");

                    b.Property<Guid>("TransaccionUId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TransaccionUId");

                    b.HasKey("ConfiguracionId");

                    b.ToTable("Configuraciones", "comunes");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.ConfiguracionesAgg.ConfiguracionesDetalle", b =>
                {
                    b.Property<string>("ConfiguracionId")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("ConfiguracionId");

                    b.Property<string>("Atributo")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Atributo");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Descripcion");

                    b.Property<string>("DescripcionTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("DescripcionTransaccion");

                    b.Property<DateTime>("FechaTransaccion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaTransaccion");

                    b.Property<string>("ModificadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("ModificadoPor");

                    b.Property<byte[]>("RowVersion")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("RowVersion");

                    b.Property<string>("TipoTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TipoTransaccion");

                    b.Property<Guid>("TransaccionUId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TransaccionUId");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Valor");

                    b.HasKey("ConfiguracionId", "Atributo");

                    b.ToTable("ConfiguracionesDetalle", "Comunes");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.Seguridad.Pantalla", b =>
                {
                    b.Property<string>("PantallaId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("PantallaId");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("Descripcion");

                    b.Property<string>("DescripcionTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("DescripcionTransaccion");

                    b.Property<DateTime>("FechaTransaccion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaTransaccion");

                    b.Property<string>("ModificadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("ModificadoPor");

                    b.Property<byte[]>("RowVersion")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("RowVersion");

                    b.Property<string>("TipoTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TipoTransaccion");

                    b.Property<Guid>("TransaccionUId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TransaccionUId");

                    b.HasKey("PantallaId");

                    b.ToTable("Pantalla", "Seguridad");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.Seguridad.Permisos", b =>
                {
                    b.Property<string>("RolId")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("RolId");

                    b.Property<string>("PantallaId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("PantallaId");

                    b.Property<string>("DescripcionTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("DescripcionTransaccion");

                    b.Property<bool>("Editar")
                        .HasColumnType("bit")
                        .HasColumnName("Editar");

                    b.Property<bool>("Eliminar")
                        .HasColumnType("bit")
                        .HasColumnName("Eliminar");

                    b.Property<DateTime>("FechaTransaccion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaTransaccion");

                    b.Property<string>("ModificadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("ModificadoPor");

                    b.Property<byte[]>("RowVersion")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("RowVersion");

                    b.Property<string>("TipoTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TipoTransaccion");

                    b.Property<Guid>("TransaccionUId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TransaccionUId");

                    b.Property<bool>("Ver")
                        .HasColumnType("bit")
                        .HasColumnName("Ver");

                    b.HasKey("RolId", "PantallaId");

                    b.ToTable("Permisos", "Seguridad");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.Seguridad.Rol", b =>
                {
                    b.Property<string>("RolId")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("RolId");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("Descripcion");

                    b.Property<string>("DescripcionTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("DescripcionTransaccion");

                    b.Property<DateTime>("FechaTransaccion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaTransaccion");

                    b.Property<string>("ModificadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("ModificadoPor");

                    b.Property<byte[]>("RowVersion")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("RowVersion");

                    b.Property<string>("TipoTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TipoTransaccion");

                    b.Property<Guid>("TransaccionUId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TransaccionUId");

                    b.HasKey("RolId");

                    b.ToTable("Rol", "Seguridad");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.Seguridad.Usuario", b =>
                {
                    b.Property<string>("UsuarioId")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("UsuarioId");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit")
                        .HasColumnName("Activo");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Apellido");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("Contrasena");

                    b.Property<string>("DescripcionTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("DescripcionTransaccion");

                    b.Property<DateTime>("FechaTransaccion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaTransaccion");

                    b.Property<string>("ModificadoPor")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("ModificadoPor");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombre");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("RolId")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("RolId");

                    b.Property<byte[]>("RowVersion")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("RowVersion");

                    b.Property<string>("TipoTransaccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TipoTransaccion");

                    b.Property<Guid>("TransaccionUId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TransaccionUId");

                    b.HasKey("UsuarioId");

                    b.HasIndex("RolId");

                    b.ToTable("Usuario", "Seguridad");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.ConfiguracionesAgg.ConfiguracionesDetalle", b =>
                {
                    b.HasOne("Dominio.Context.Entidades.ConfiguracionesAgg.Configuraciones", "Configuraciones")
                        .WithMany("ConfiguracionesDetalle")
                        .HasForeignKey("ConfiguracionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Configuraciones");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.Seguridad.Permisos", b =>
                {
                    b.HasOne("Dominio.Context.Entidades.Seguridad.Rol", "Rol")
                        .WithMany("Permisos")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.Seguridad.Usuario", b =>
                {
                    b.HasOne("Dominio.Context.Entidades.Seguridad.Rol", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.ConfiguracionesAgg.Configuraciones", b =>
                {
                    b.Navigation("ConfiguracionesDetalle");
                });

            modelBuilder.Entity("Dominio.Context.Entidades.Seguridad.Rol", b =>
                {
                    b.Navigation("Permisos");

                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
````

## File: RESULT_PATTERN_GUIDE.md
````markdown
# Patrón Result - Guía de Implementación

## Descripción General

El **Patrón Result** encapsula el resultado de una operación (éxito o fallo) en un objeto type-safe. Reemplaza la necesidad de retornar DTOs con propiedades de mensaje o lanzar excepciones para casos de error esperados.

## Estructura

### 1. **IResult** (Interfaz Base)
```csharp
public interface IResult
{
    bool IsSuccess { get; }           // ¿Operación exitosa?
    string Message { get; }            // Mensaje de resultado
    string? ErrorCode { get; }         // Código de error (opcional)
    IReadOnlyCollection<string> Errors { get; } // Errores detallados
}
```

### 2. **Result** (Clase Base)
Resultados sin valor genérico, para operaciones que no retornan datos.

```csharp
// Crear resultado exitoso
var success = Result.Success("Operación completada");

// Crear resultado fallido
var failure = Result.Failure("Algo falló", errorCode: "ERR_001");

// Crear resultado con múltiples errores
var validation = Result.ValidationFailure(
    "Validación fallida",
    new[] { "Campo 1 requerido", "Campo 2 inválido" },
    errorCode: "VALIDATION_ERROR"
);
```

### 3. **Result<T>** (Clase Genérica)
Para operaciones que retornan un valor de tipo `T`.

```csharp
// Crear resultado exitoso con datos
var success = Result<Usuario>.Success(usuario, "Usuario creado");

// Crear resultado fallido (sin datos)
var failure = Result<Usuario>.Failure("Usuario no encontrado", "USER_NOT_FOUND");

// Crear resultado con errores de validación
var validation = Result<Usuario>.ValidationFailure(
    "Datos inválidos",
    new[] { "Email duplicado", "Contraseña muy corta" }
);
```

## Uso en Servicios

### Antes (Antipatrón)
```csharp
public UsuarioDTO CrearUsuario(EdicionUsuarioRequest request)
{
    if (usuarioExiste)
    {
        return new UsuarioDTO { Message = "Usuario ya existe", UsuarioId = "" };
    }
    
    return new UsuarioDTO { UsuarioId = nuevoUsuario.Id, Message = "Éxito" };
}
```

### Después (Patrón Result)
```csharp
public Result<UsuarioDTO> CrearUsuario(EdicionUsuarioRequest request)
{
    if (usuarioExiste)
    {
        return Result<UsuarioDTO>.Failure("Usuario ya existe", "USER_EXISTS");
    }
    
    var usuarioDto = _mapper.Map<UsuarioDTO>(nuevoUsuario);
    return Result<UsuarioDTO>.Success(usuarioDto, "Usuario creado exitosamente");
}
```

## Uso en Controladores

### Con Result<T>
```csharp
[HttpPost("create")]
public IActionResult Create([FromBody] EdicionUsuarioRequest request)
{
    var result = _securityService.CrearUsuario(request);
    
    // Verificación simplificada
    if (!result.IsSuccess)
    {
        if (result.Errors.Any())
        {
            return BadRequest(new { message = result.Message, errors = result.Errors });
        }
        return BadRequest(new { message = result.Message });
    }
    
    return Created($"/users/{result.Data.UsuarioId}", result.Data);
}
```

## Métodos Auxiliares

### **Map<TNew>** - Transformación de Datos
Transforma el valor exitoso sin afectar el estado de error.

```csharp
var usuarioResult = _service.ObtenerUsuario(id);

var dtoResult = usuarioResult.Map(usuario => new UsuarioResumenDTO
{
    Id = usuario.Id,
    NombreCompleto = $"{usuario.Nombre} {usuario.Apellido}"
});

if (dtoResult.IsSuccess)
{
    return Ok(dtoResult.Data); // UsuarioResumenDTO
}
```

### **Bind<TNew>** - Encadenamiento de Operaciones
Encadena operaciones que retornan otro `Result<T>`.

```csharp
public Result<PermisoDTO> ObtenerPermisosDeUsuario(int usuarioId)
{
    return ObtenerUsuario(usuarioId)           // Result<Usuario>
        .Bind(usuario => ObtenerRol(usuario.RolId))  // Result<Rol>
        .Bind(rol => ObtenerPermisos(rol.Id))        // Result<List<Permiso>>
        .Map(permisos => new PermisoDTO { ... });    // Result<PermisoDTO>
}
```

## Manejo de Errores de Validación

```csharp
public Result<UsuarioDTO> EditarUsuario(EdicionUsuarioRequest request)
{
    var erroresValidacion = new List<string>();
    
    if (request.Usuario is null)
        erroresValidacion.Add("El usuario es obligatorio");
    
    if (string.IsNullOrEmpty(request.Usuario?.UsuarioId))
        erroresValidacion.Add("ID de usuario es obligatorio");
    
    if (erroresValidacion.Any())
    {
        return Result<UsuarioDTO>.ValidationFailure(
            "Validación fallida",
            erroresValidacion,
            "VALIDATION_ERROR"
        );
    }
    
    // Resto de la lógica...
    return Result<UsuarioDTO>.Success(usuarioDto);
}
```

## Beneficios

| Aspecto | Benefit |
|--------|---------|
| **Type-Safe** | El compilador fuerza revisión de errores |
| **Explícito** | Los errores son parte del contrato del método |
| **Sin Excepciones** | Evita overhead para casos esperados |
| **Composable** | Map y Bind para composición funcional |
| **Testeable** | Fácil de testear sin mocking complejo |
| **Mantenible** | Código más limpio y predecible |

## Plan de Migración (Gradual)

1. ✅ **Implementar clases Result** (Done)
2. 🔄 **Refactorizar SecurityApplicationService** (Próximo)
   - CrearUsuario
   - EditarUsuario
   - IniciarSesion
   - RefreshToken
3. 🔄 **Actualizar Controladores** (Después)
4. 🔄 **Extender a otros servicios** (Opcional)

## Ejemplos de Códigos de Error

```
USER_NOT_FOUND       → Usuario no existe
INVALID_PASSWORD     → Contraseña incorrecta
USER_ALREADY_EXISTS  → Usuario duplicado
ROLE_NOT_FOUND       → Rol no existe
VALIDATION_ERROR     → Error de validación
UNAUTHORIZED         → No autorizado
FORBIDDEN            → Acceso denegado
INTERNAL_ERROR       → Error interno del servidor
```

## Referencias

- Patrón Result: https://github.com/nlkl/Optional
- Railway-Oriented Programming: https://fsharpforfunandprofit.com/posts/recipe-part2/
- C# Result Pattern: https://github.com/MbarkT3SL/SimpleResult
````

## File: WebServices/appsettings.Development.json
````json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  }
}
````

## File: WebServices/WeatherForecast.cs
````csharp
namespace WebServices
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
````

## File: WebServices/WebServices.http
````
@WebServices_HostAddress = http://localhost:5283

GET {{WebServices_HostAddress}}/weatherforecast/
Accept: application/json

###
````

## File: Aplicacion/DTOs/RequestBase.cs
````csharp
namespace Aplicacion.DTOs
{
    public class RequestBase
    {
        public RequestUserInfo? RequestUserInfo { get; set; }
        public QueryInfo? QueryInfo { get; set; }
    }
}
````

## File: Aplicacion/DTOs/RequestUserInfo.cs
````csharp
namespace Aplicacion.DTOs
{
    public class RequestUserInfo
    {
        public string? UsuarioId { get; set; }
    }
}
````

## File: Aplicacion/DTOs/Seguridad/TokenRequest.cs
````csharp
namespace Aplicacion.DTOs.Seguridad
{
    public class TokenRequest : RequestBase
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
    }
}
````

## File: Aplicacion/Helpers/DynamicFilterFactory.cs
````csharp
using Aplicacion.DTOs;
using Dominio.Core;

namespace Aplicacion.Helpers
{
    public static class DynamicFilterFactory
    {
        public static DynamicFilter CreateDynamicFilter(QueryInfo queryInfo)
        {
            var newQueryInfo = new QueryInfo();

            if (queryInfo != null)
            {
                newQueryInfo.Includes = queryInfo.Includes;
                newQueryInfo.SortFields = queryInfo.SortFields;
                newQueryInfo.Ascending = queryInfo.Ascending;
                newQueryInfo.Predicate = queryInfo.Predicate;
                newQueryInfo.ParamValues = CreateParam(queryInfo.ParamValues);

                if (queryInfo.PageIndex >= 0) newQueryInfo.PageIndex = queryInfo.PageIndex;
                if (queryInfo.PageSize > 0) newQueryInfo.PageSize = queryInfo.PageSize;
            }

            return new DynamicFilter(newQueryInfo.PageIndex, newQueryInfo.PageSize, newQueryInfo.SortFields,
                newQueryInfo.Ascending, newQueryInfo.Includes, newQueryInfo.Predicate, newQueryInfo.ParamValues);
        }
        private static object[] CreateParam(object[]? paramValues)
        {
            object[]? param = new object[paramValues.Length];
            for (int i = 0; i < paramValues.Length; i++)
            {
                param[i] = paramValues[i].ToString();
            }

            return param;
        }
    }
}
````

## File: Aplicacion/Services/ConfiguracionesApp/ConfiguracionesApplicationService.cs
````csharp
using Aplicacion.DTOs;
using Aplicacion.DTOs.ConfiguracionesDTO;
using Aplicacion.Helpers;
using Dominio.Context.Entidades.ConfiguracionesAgg;
using Dominio.Core;
using Dominio.Core.Extensions;
using Dominio.Core.Result;
using Infraestructura.Context;

namespace Aplicacion.Services.ConfiguracionesApp
{
    public class ConfiguracionesApplicationService : IConfiguracionesApplicationService
    {
        private readonly IGenericRepository<IDataContext> _genericRepository;

        public ConfiguracionesApplicationService(IGenericRepository<IDataContext> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<Result<ConfiguracionesDTO>> CrearConfiguracion(ConfiguracionesRequest request)
        {
            var validationResult = ValidateConfiguracionRequest(request);
            if (validationResult is not null)
            {
                return validationResult;
            }

            var configuracionRequest = request.Configuraciones!;
            var existingConfiguracion = await _genericRepository.GetSingleAsync<Configuraciones>(x => x.ConfiguracionId == configuracionRequest.ConfiguracionId);
            if (existingConfiguracion.IsNotNull())
            {
                return Result<ConfiguracionesDTO>.Failure($"Ya existe una configuracion con el ID {existingConfiguracion.ConfiguracionId}", "CONFIGURATION_EXISTS");
            }

            var configuracion = new Configuraciones
            {
                ConfiguracionId = configuracionRequest.ConfiguracionId,
                Descripcion = configuracionRequest.Descripcion
            };

            await _genericRepository.AddAsync(configuracion);
            TransactionInfo transactionInfo = request.RequestUserInfo!.CrearTransactionInfo("CrearConfiguracion");
            _genericRepository.UnitOfWork.Commit(transactionInfo);

            return Result<ConfiguracionesDTO>.Success(MapConfiguracionesDTO(configuracion), "Configuracion creada exitosamente");
        }

        public async Task<Result<ConfiguracionesDetalleDTO>> EditarConfiguracionesDetalle(ConfiguracionesRequest request)
        {
            var validationResult = ValidateConfiguracionDetalleRequest(request);
            if (validationResult is not null)
            {
                return validationResult;
            }

            var detalleRequest = request.ConfiguracionesDetalle!;
            var existingConfiguracionDetalle = await _genericRepository.GetSingleAsync<ConfiguracionesDetalle>(x => x.ConfiguracionId == detalleRequest.ConfiguracionId && x.Atributo == detalleRequest.Atributo);
            if (existingConfiguracionDetalle.IsNull())
            {
                return Result<ConfiguracionesDetalleDTO>.Failure($"No existe un detalle de configuracion con el ID {detalleRequest.ConfiguracionId} y el atributo {detalleRequest.Atributo}", "CONFIGURATION_DETAIL_NOT_FOUND");
            }

            existingConfiguracionDetalle.Descripcion = detalleRequest.Descripcion;
            existingConfiguracionDetalle.Valor = detalleRequest.Valor;

            TransactionInfo transactionInfo = request.RequestUserInfo!.CrearTransactionInfo("EditarConfiguracionDetalle");
            _genericRepository.UnitOfWork.Commit(transactionInfo);

            return Result<ConfiguracionesDetalleDTO>.Success(MapConfiguracionesDetalleDTO(existingConfiguracionDetalle), "Detalle de configuracion actualizado exitosamente");
        }

        public async Task<Result<ConfiguracionesDTO>> EditarConfiguracion(ConfiguracionesRequest request)
        {
            var validationResult = ValidateConfiguracionRequest(request);
            if (validationResult is not null)
            {
                return validationResult;
            }

            var configuracionRequest = request.Configuraciones!;
            var existingConfiguracion = await _genericRepository.GetSingleAsync<Configuraciones>(x => x.ConfiguracionId == configuracionRequest.ConfiguracionId);
            if (existingConfiguracion.IsNull())
            {
                return Result<ConfiguracionesDTO>.Failure($"No existe una configuracion con el ID {configuracionRequest.ConfiguracionId}", "CONFIGURATION_NOT_FOUND");
            }

            existingConfiguracion.Descripcion = configuracionRequest.Descripcion;

            TransactionInfo transactionInfo = request.RequestUserInfo!.CrearTransactionInfo("EditarConfiguracion");
            _genericRepository.UnitOfWork.Commit(transactionInfo);

            return Result<ConfiguracionesDTO>.Success(MapConfiguracionesDTO(existingConfiguracion), "Configuracion actualizada exitosamente");
        }

        public async Task<Result<ConfiguracionesDetalleDTO>> CrearConfiguracionDetalle(ConfiguracionesRequest request)
        {
            var validationResult = ValidateConfiguracionDetalleRequest(request);
            if (validationResult is not null)
            {
                return validationResult;
            }

            var detalleRequest = request.ConfiguracionesDetalle!;
            var existingConfiguracion = await _genericRepository.GetSingleAsync<Configuraciones>(x => x.ConfiguracionId == detalleRequest.ConfiguracionId);
            if (existingConfiguracion.IsNull())
            {
                return Result<ConfiguracionesDetalleDTO>.Failure($"La configuracion con el ID {detalleRequest.ConfiguracionId} no existe", "CONFIGURATION_NOT_FOUND");
            }

            var configuracionesDetalle = new ConfiguracionesDetalle
            {
                ConfiguracionId = detalleRequest.ConfiguracionId,
                Atributo = detalleRequest.Atributo,
                Descripcion = detalleRequest.Descripcion,
                Valor = detalleRequest.Valor,
            };

            await _genericRepository.AddAsync(configuracionesDetalle);
            TransactionInfo transactionInfo = request.RequestUserInfo!.CrearTransactionInfo("CrearConfiguracionDetalle");
            _genericRepository.UnitOfWork.Commit(transactionInfo);

            return Result<ConfiguracionesDetalleDTO>.Success(MapConfiguracionesDetalleDTO(configuracionesDetalle), "Detalle de configuracion creado exitosamente");
        }

        public async Task<Result<SearchResult<ConfiguracionesDTO>>> ObtenerConfiguracionesPaginado(ConfiguracionesRequest request)
        {
            if (request is null)
            {
                return Result<SearchResult<ConfiguracionesDTO>>.Failure("Solicitud es obligatoria", "NULL_REQUEST", ResultStatus.ValidationError);
            }

            var dynamicFilter = DynamicFilterFactory.CreateDynamicFilter(request.QueryInfo);
            var configuraciones = await _genericRepository.GetPagedAndFilteredAsync<Configuraciones>(dynamicFilter);
            var result = new SearchResult<ConfiguracionesDTO>
            {
                ItemCount = configuraciones.ItemCount,
                PageCount = configuraciones.PageCount,
                PageIndex = configuraciones.PageIndex,
                TotalItems = configuraciones.TotalItems,
                Items = (from query in configuraciones.Items as IEnumerable<Configuraciones> select MapConfiguracionesDTO(query)).ToList()
            };

            return Result<SearchResult<ConfiguracionesDTO>>.Success(result);
        }

        private static Result<ConfiguracionesDTO>? ValidateConfiguracionRequest(ConfiguracionesRequest request)
        {
            if (request is null || request.Configuraciones is null)
            {
                return Result<ConfiguracionesDTO>.Failure("Configuracion es obligatoria", "NULL_CONFIGURACION", ResultStatus.ValidationError);
            }

            if (request.RequestUserInfo is null)
            {
                return Result<ConfiguracionesDTO>.Failure("Informacion de usuario es obligatoria", "NULL_REQUEST_USER_INFO", ResultStatus.ValidationError);
            }

            return null;
        }

        private static Result<ConfiguracionesDetalleDTO>? ValidateConfiguracionDetalleRequest(ConfiguracionesRequest request)
        {
            if (request is null || request.ConfiguracionesDetalle is null)
            {
                return Result<ConfiguracionesDetalleDTO>.Failure("Detalle de configuracion es obligatorio", "NULL_CONFIGURACION_DETALLE", ResultStatus.ValidationError);
            }

            if (request.RequestUserInfo is null)
            {
                return Result<ConfiguracionesDetalleDTO>.Failure("Informacion de usuario es obligatoria", "NULL_REQUEST_USER_INFO", ResultStatus.ValidationError);
            }

            return null;
        }

        private static ConfiguracionesDetalleDTO MapConfiguracionesDetalleDTO(ConfiguracionesDetalle configuracionesDetalle)
        {
            return new ConfiguracionesDetalleDTO
            {
                ConfiguracionId = configuracionesDetalle.ConfiguracionId,
                Atributo = configuracionesDetalle.Atributo,
                Descripcion = configuracionesDetalle.Descripcion,
                Valor = configuracionesDetalle.Valor,
            };
        }

        private static ConfiguracionesDTO MapConfiguracionesDTO(Configuraciones query)
        {
            return new ConfiguracionesDTO
            {
                ConfiguracionId = query.ConfiguracionId,
                Descripcion = query.Descripcion,
                ConfiguracionesDetalle = query.ConfiguracionesDetalle?
                    .Select(detalle => MapConfiguracionesDetalleDTO(detalle))
                    .ToList() ?? new List<ConfiguracionesDetalleDTO>()
            };
        }
    }
}
````

## File: Aplicacion/Services/ConfiguracionesApp/IConfiguracionesApplicationService.cs
````csharp
using Aplicacion.DTOs;
using Aplicacion.DTOs.ConfiguracionesDTO;
using Dominio.Core.Result;

namespace Aplicacion.Services.ConfiguracionesApp
{
    public interface IConfiguracionesApplicationService
    {
        Task<Result<SearchResult<ConfiguracionesDTO>>> ObtenerConfiguracionesPaginado(ConfiguracionesRequest request);
        Task<Result<ConfiguracionesDTO>> CrearConfiguracion(ConfiguracionesRequest request);
        Task<Result<ConfiguracionesDTO>> EditarConfiguracion(ConfiguracionesRequest request);
        Task<Result<ConfiguracionesDetalleDTO>> CrearConfiguracionDetalle(ConfiguracionesRequest request);
        Task<Result<ConfiguracionesDetalleDTO>> EditarConfiguracionesDetalle(ConfiguracionesRequest request);
    }
}
````

## File: Aplicacion/Services/Seguridad/ISecurityApplicationService.cs
````csharp
using Aplicacion.DTOs;
using Aplicacion.DTOs.Seguridad;
using Dominio.Core.Result;

namespace Aplicacion.Services.Seguridad
{
    public interface ISecurityApplicationService
    {
        Task<Result<UsuarioDTO>> EditarUsuario(EdicionUsuarioRequest request);
        Task<Result<List<PantallaDTO>>> ObtenerPantallas();
        Task<Result<RolDTO>> EdicionPermisos(EdicionPermisosRequest request);
        Task<Result<UsuarioDTO>> CrearUsuario(EdicionUsuarioRequest request);
        Task<Result<UsuarioDTO>> IniciarSesion(UserRequest request);
        Task<Result<UsuarioDTO>> RefreshToken(TokenRequest request);
        Task<Result<SearchResult<UsuarioDTO>>> ObtenerUsuario(GetUserRequest request);
        Task<Result<RolDTO>> CrearRol(EdicionRolRequest request);
        Task<Result<RolDTO>> EditarRol(EdicionRolRequest request);
        Task<Result<List<RolDTO>>> ObtenerRoles();
    }
}
````

## File: CrossCutting/Configuration/AppSettingsManager.cs
````csharp
using Dominio.Core.Extensions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Configuration
{
    /// <summary>
    /// Administrador centralizado de configuraciones de la aplicación.
    /// Actúa como singleton lógico mediante clase estática.
    ///
    /// Estructura del índice en memoria:
    ///   Dictionary&lt;ConfiguracionId, Dictionary&lt;Atributo, Valor&gt;&gt;
    ///
    /// Esto permite búsquedas O(1) tanto por grupo como por atributo individual.
    /// </summary>
    public static class AppSettingsManager
    {
        // ── Estado interno ───────────────────────────────────────────────────

        /// <summary>
        /// Índice principal: ConfiguracionId → (Atributo → Valor)
        /// </summary>
        private static Dictionary<string, Dictionary<string, string>> _index
            = new(StringComparer.OrdinalIgnoreCase);

        private static string _connectionString = string.Empty;
        private static bool _isLoaded = false;
        private static readonly object _lock = new();

        // ── Inicialización ───────────────────────────────────────────────────

        /// <summary>
        /// Inicializa el manager con la cadena de conexión y carga la tabla.
        /// Debe llamarse una sola vez al arranque de la aplicación (Program.cs).
        /// Las llamadas posteriores son ignoradas salvo que <paramref name="forceReload"/> sea true.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión a SQL Server.</param>
        /// <param name="forceReload">Si es true fuerza la recarga aunque ya esté inicializado.</param>
        public static void Initialize(string connectionString, bool forceReload = false)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(nameof(connectionString),
                    "La cadena de conexión no puede estar vacía.");

            lock (_lock)
            {
                if (_isLoaded && !forceReload)
                    return; // Salida temprana — patrón singleton lógico

                _connectionString = connectionString;
                LoadSettings();
            }
        }

        /// <summary>
        /// Recarga las configuraciones desde la base de datos en tiempo de ejecución
        /// sin reiniciar la aplicación (recarga en caliente).
        /// </summary>
        public static void Reload()
        {
            lock (_lock)
            {
                if (string.IsNullOrWhiteSpace(_connectionString))
                    throw new InvalidOperationException(
                        "AppSettingsManager no ha sido inicializado. Llame a Initialize() primero.");

                LoadSettings();
            }
        }

        // ── Carga interna ────────────────────────────────────────────────────

        /// <summary>
        /// Ejecuta la lectura con ADO.NET puro para mantener el desacoplamiento
        /// de capas de Data/Infrastructure. Construye el índice en memoria.
        /// El swap final es atómico: si la carga falla, el índice anterior se preserva.
        /// </summary>
        private static void LoadSettings()
        {
            // Diccionario temporal — se asigna al campo solo si la carga es exitosa
            var tempIndex = new Dictionary<string, Dictionary<string, string>>(
                StringComparer.OrdinalIgnoreCase);

            try
            {
                using var connection = new SqlConnection(_connectionString);
                connection.Open();

                const string query = @"
                    SELECT [ConfiguracionId],
                           [Atributo],
                           [Valor]
                    FROM   [Comunes].[ConfiguracionesDetalle]
                    WHERE  [ConfiguracionId] IS NOT NULL
                      AND  [Atributo]        IS NOT NULL";

                using var command = new SqlCommand(query, connection);
                using var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    string configId = reader["ConfiguracionId"]?.ToStringValue() ?? string.Empty;
                    string atributo = reader["Atributo"]?.ToStringValue() ?? string.Empty;
                    string valor = reader["Valor"]?.ToStringValue() ?? string.Empty;

                    if (string.IsNullOrEmpty(configId) || string.IsNullOrEmpty(atributo))
                        continue;

                    // Crea el grupo si aún no existe
                    if (!tempIndex.ContainsKey(configId))
                        tempIndex[configId] = new Dictionary<string, string>(
                            StringComparer.OrdinalIgnoreCase);

                    tempIndex[configId][atributo] = valor; // última fila gana si hay duplicados
                }

                // ✅ Swap atómico — solo reemplaza si la carga fue exitosa
                _index = tempIndex;
                _isLoaded = true;
            }
            catch (SqlException ex)
            {
                throw new AppSettingsException(
                    "Error al cargar configuraciones desde la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new AppSettingsException(
                    "Error inesperado al cargar configuraciones.", ex);
            }
        }

        // ── Métodos de acceso públicos ───────────────────────────────────────

        /// <summary>
        /// Retorna todos los atributos y valores que pertenecen a un ConfiguracionId.
        /// </summary>
        /// <param name="configurationId">Identificador del grupo de configuraciones.</param>
        /// <returns>
        /// Diccionario de solo lectura Atributo → Valor,
        /// o un diccionario vacío si el grupo no existe.
        /// </returns>
        public static IReadOnlyDictionary<string, string> GetConfigurationById(
            string configurationId)
        {
            EnsureLoaded();
            ValidateParam(configurationId, nameof(configurationId));

            return _index.TryGetValue(configurationId, out var group)
                ? group
                : new Dictionary<string, string>();
        }

        /// <summary>
        /// Retorna el valor de un atributo específico dentro de un grupo.
        /// </summary>
        /// <param name="configurationId">Identificador del grupo.</param>
        /// <param name="attribute">Nombre del atributo.</param>
        /// <returns>
        /// El valor como string, o <see cref="string.Empty"/> si no se encuentra.
        /// </returns>
        public static string GetConfigurationByIdAndAttribute(
            string configurationId,
            string attribute)
        {
            EnsureLoaded();
            ValidateParam(configurationId, nameof(configurationId));
            ValidateParam(attribute, nameof(attribute));

            if (_index.TryGetValue(configurationId, out var group) &&
                group.TryGetValue(attribute, out string? value))
                return value;

            return string.Empty;
        }

        /// <summary>
        /// Evalúa si una configuración está "activa" (encendida).
        /// Acepta como verdadero: "true", "1", "yes", "si", "sí", "on", "activo".
        /// </summary>
        /// <param name="configurationId">Identificador del grupo.</param>
        /// <param name="attributeId">Nombre del atributo bandera.</param>
        /// <returns>
        /// <c>true</c> si el valor se interpreta como activo, <c>false</c> en cualquier otro caso.
        /// </returns>
        public static bool IsConfigurationOn(
            string configurationId,
            string attributeId)
        {
            string valor = GetConfigurationByIdAndAttribute(configurationId, attributeId);

            return valor.ToLowerInvariant() switch
            {
                "true" or "1" or "yes" or "si" or "sí" or "on" or "activo" => true,
                _ => false
            };
        }

        // ── Métodos auxiliares de conversión tipada ──────────────────────────

        /// <summary>
        /// Obtiene un atributo y lo convierte a int.
        /// Retorna <paramref name="defaultValue"/> si no existe o la conversión falla.
        /// </summary>
        public static int GetInt(string configurationId, string attribute, int defaultValue = 0)
        {
            string raw = GetConfigurationByIdAndAttribute(configurationId, attribute);
            return int.TryParse(raw, out int result) ? result : defaultValue;
        }

        /// <summary>
        /// Obtiene un atributo y lo convierte a decimal.
        /// </summary>
        public static decimal GetDecimal(string configurationId, string attribute, decimal defaultValue = 0m)
        {
            string raw = GetConfigurationByIdAndAttribute(configurationId, attribute);
            return decimal.TryParse(raw,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out decimal result) ? result : defaultValue;
        }

        /// <summary>
        /// Retorna una instantánea (snapshot) de todo el índice.
        /// Útil para diagnóstico o endpoints de administración.
        /// </summary>
        public static IReadOnlyDictionary<string, IReadOnlyDictionary<string, string>> GetSnapshot()
        {
            EnsureLoaded();
            var snapshot = new Dictionary<string, IReadOnlyDictionary<string, string>>(
                StringComparer.OrdinalIgnoreCase);

            foreach (var (key, group) in _index)
                snapshot[key] = group;

            return snapshot;
        }

        // ── Guardianes internos ──────────────────────────────────────────────

        private static void EnsureLoaded()
        {
            if (!_isLoaded)
                throw new InvalidOperationException(
                    "AppSettingsManager no ha sido inicializado. " +
                    "Llame a AppSettingsManager.Initialize(connectionString) al inicio de la aplicación.");
        }

        private static void ValidateParam(string value, string paramName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(paramName,
                    $"El parámetro '{paramName}' no puede ser nulo o vacío.");
        }
    }

}
````

## File: CrossCutting/CrossCutting.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.Data.SqlClient" Version="7.0.0" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\Dominio\Dominio.csproj" />
  </ItemGroup>

</Project>
````

## File: Dominio/Context/Entidades/PasswordEncryptor.cs
````csharp
namespace Dominio.Context.Entidades
{
    public static class PasswordEncryptor
    {
        public static string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return string.Empty;
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerifyPassword(string password, string hash)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(hash)) return false;
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
    }
}
````

## File: Dominio/Core/DynamicFilter.cs
````csharp
namespace Dominio.Core
{
    public class DynamicFilter
    {
        public DynamicFilter(int pageIndex, int pageSize, List<string> sortFields = null, bool ascending = true,
            List<string> includes = null, string predicate = null, object[] paramValues = null)
        {
            
            PageIndex = pageIndex;
            PageSize = pageSize;
            Ascending = ascending;
            SortFields = sortFields;
            Filtro = predicate;
            Valores = paramValues;
            Includes = includes;
        }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public List<string> SortFields { get; set; }
        public bool Ascending { get; set; }
        public string Filtro { get; set; }
        public object[] Valores { get; set; }
        public List<string> Includes { get; set; }
    }
}
````

## File: Dominio/Core/Extensions/DomainListExtensions.cs
````csharp
namespace Dominio.Core.Extensions
{
    public static class DomainListExtensions
    {
        /// <summary>
        /// Devuelve los elementos de <paramref name="newList"/> que no se encuentran en <paramref name="comparerList"/>,
        /// comparando cada objeto por su clave de igualdad.
        /// </summary>
        /// <param name="newList">La lista principal de elementos a evaluar.</param>
        /// <param name="comparerList">La lista de referencia cuyos elementos se usarán para comparar.</param>
        /// <returns>
        /// Una lista de objetos <see cref="IEqualityKey"/> que están en <paramref name="newList"/> pero no en <paramref name="comparerList"/>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// // Supongamos que IEqualityKey implementa GetEqualityKey() devolviendo un string único.
        /// List<IEqualityKey> listaNueva = new List<IEqualityKey>
        /// {
        ///     new Persona("Ana"),
        ///     new Persona("Luis"),
        ///     new Persona("Carlos")
        /// };
        ///
        /// List<IEqualityKey> listaComparadora = new List<IEqualityKey>
        /// {
        ///     new Persona("Luis"),
        ///     new Persona("Maria")
        /// };
        ///
        /// List<IEqualityKey> resultado = listaNueva.NotIn(listaComparadora);
        ///
        /// // resultado contendrá: Ana y Carlos
        /// foreach (var item in resultado)
        /// {
        ///     Console.WriteLine(item.GetEqualityKey());
        /// }
        /// </code>
        /// </example>
        public static List<IEqualityKey> NotIn(this IEnumerable<IEqualityKey> newList, IEnumerable<IEqualityKey> comparerList)
        {
            var comparerKeys = comparerList.Items().Select(c => c.GetEqualityKey()).ToList();

            return newList.Items().Where(c => !comparerKeys.Contains(c.GetEqualityKey())).ToList();
        }
    }

    public interface IEqualityKey
    {
        string GetEqualityKey();
    }
}
````

## File: Dominio/Core/Extensions/ListExtensions.cs
````csharp
using System.Data;

namespace Dominio.Core.Extensions
{
    public static class ListExtensions
    {
        /// <summary>
        /// Convierte una colección de cadenas en una sola cadena,
        /// separando cada elemento con una coma y un espacio.
        /// </summary>
        /// <param name="list">La colección de cadenas que se desea unir.</param>
        /// <returns>
        /// Una cadena que contiene los elementos de la colección separados por ", ".
        /// Si la colección es nula o está vacía, devuelve una cadena vacía.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// var nombres = new List<string> { "Ana", "Luis", "Carlos" };
        ///
        /// string resultado = nombres.ToStringList();
        /// Console.WriteLine(resultado);
        ///
        /// // Salida:
        /// // Ana, Luis, Carlos
        /// </code>
        /// </example>
        public static string ToStringList(this IEnumerable<string> list)
        {
            if (list.HasItems())
            {
                return string.Join(", ", list);
            }

            return string.Empty;
        }

        /// <summary>
        /// Convierte una colección de cadenas en una sola cadena,
        /// separando cada elemento con el delimitador especificado.
        /// </summary>
        /// <param name="list">La colección de cadenas que se desea unir.</param>
        /// <param name="separator">El separador que se usará entre los elementos.</param>
        /// <returns>
        /// Una cadena que contiene los elementos de la colección separados por <paramref name="separator"/>.
        /// Si la colección es nula o está vacía, devuelve una cadena vacía.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// var nombres = new List<string> { "Ana", "Luis", "Carlos" };
        ///
        /// string resultado1 = nombres.ToStringList(", ");
        /// Console.WriteLine(resultado1);
        /// // Salida: Ana, Luis, Carlos
        ///
        /// string resultado2 = nombres.ToStringList(" | ");
        /// Console.WriteLine(resultado2);
        /// // Salida: Ana | Luis | Carlos
        /// </code>
        /// </example>
        public static string ToStringList(this IEnumerable<string> list, string separator)
        {
            if (list.HasItems())
            {
                return string.Join(separator, list);
            }

            return string.Empty;
        }

        /// <summary>
        /// Determina si dos colecciones de cadenas contienen exactamente los mismos elementos,
        /// independientemente del orden.
        /// </summary>
        /// <param name="list">La primera colección de cadenas.</param>
        /// <param name="list2">La segunda colección de cadenas.</param>
        /// <returns>
        /// <c>true</c> si ambas colecciones son nulas o vacías, o si contienen los mismos elementos;
        /// en caso contrario, <c>false</c>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// var lista1 = new List<string> { "Ana", "Luis", "Carlos" };
        /// var lista2 = new List<string> { "Carlos", "Luis", "Ana" };
        /// var lista3 = new List<string> { "Ana", "Luis" };
        ///
        /// bool iguales1 = lista1.HasEqualsAllItems(lista2); // True
        /// bool iguales2 = lista1.HasEqualsAllItems(lista3); // False
        ///
        /// Console.WriteLine($"Lista1 y Lista2 iguales: {iguales1}");
        /// Console.WriteLine($"Lista1 y Lista3 iguales: {iguales2}");
        /// </code>
        /// </example>
        public static bool HasEqualsAllItems(this IEnumerable<string> list, IEnumerable<string> list2)
        {
            if (!list.HasItems() && !list2.HasItems())
            {
                return true;
            }

            var differenceInSourceList = list.Except(list2);
            var differenceInTargetList = list2.Except(list);

            if (!differenceInSourceList.Any() && !differenceInTargetList.Any())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Determina si todos los elementos de una colección están contenidos en otra colección.
        /// </summary>
        /// <param name="sourceList">La colección en la que se buscarán los elementos.</param>
        /// <param name="list">La colección cuyos elementos deben estar presentes en <paramref name="sourceList"/>.</param>
        /// <returns>
        /// <c>true</c> si todos los elementos de <paramref name="list"/> están contenidos en <paramref name="sourceList"/>; 
        /// en caso contrario, <c>false</c>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// var lista1 = new List<string> { "Ana", "Luis", "Carlos" };
        /// var lista2 = new List<string> { "Luis", "Ana" };
        /// var lista3 = new List<string> { "Pedro", "Ana" };
        ///
        /// bool contiene1 = lista1.HasEqualSomeItemsOf(lista2); // True
        /// bool contiene2 = lista1.HasEqualSomeItemsOf(lista3); // False
        ///
        /// Console.WriteLine($"Lista1 contiene todos los de Lista2: {contiene1}");
        /// Console.WriteLine($"Lista1 contiene todos los de Lista3: {contiene2}");
        /// </code>
        /// </example>
        public static bool HasEqualSomeItemsOf(this IEnumerable<string> sourceList, IEnumerable<string> list)
        {
            if (list.All(sourceList.Contains))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Convierte una colección de cadenas en un <see cref="DataTable"/> con una única columna.
        /// </summary>
        /// <param name="collection">La colección de cadenas que se desea transformar en tabla.</param>
        /// <param name="fieldId">El nombre de la columna que se creará en el <see cref="DataTable"/>.</param>
        /// <returns>
        /// Un <see cref="DataTable"/> con una columna llamada <paramref name="fieldId"/> 
        /// y una fila por cada elemento de la colección.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// var estilos = new List<string> { "Clásico", "Moderno", "Minimalista" };
        ///
        /// DataTable tabla = estilos.ToDataTable("Estilo");
        ///
        /// foreach (DataRow fila in tabla.Rows)
        /// {
        ///     Console.WriteLine(fila["Estilo"]);
        /// }
        ///
        /// // Salida:
        /// // Clásico
        /// // Modernista
        /// // Minimalista
        /// </code>
        /// </example>
        public static DataTable ToDataTable(this IEnumerable<string> collection, string fieldId)
        {
            var tabla = new DataTable();
            tabla.Columns.Add(fieldId, typeof(string));
            foreach (var estilo in collection)
            {
                var dr = tabla.NewRow();
                dr[fieldId] = estilo;
                tabla.Rows.Add(dr);
            }
            return tabla;
        }
    }
}
````

## File: Dominio/Core/Extensions/NumericExtensions.cs
````csharp
namespace Dominio.Core.Extensions
{
    public static class NumericExtensions
    {
        /// <summary>
        /// Convierte un número de tipo <see cref="double"/> en su valor absoluto
        /// y lo transforma en un entero.
        /// </summary>
        /// <param name="number">El número de tipo <see cref="double"/> que se desea convertir.</param>
        /// <returns>
        /// El valor absoluto del número convertido a <see cref="int"/>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// double valor1 = -12.7;
        /// double valor2 = 8.9;
        ///
        /// int resultado1 = valor1.ToAbsInt(); // 12
        /// int resultado2 = valor2.ToAbsInt(); // 8
        ///
        /// Console.WriteLine($"Resultado1: {resultado1}");
        /// Console.WriteLine($"Resultado2: {resultado2}");
        /// </code>
        /// </example>
        public static int ToAbsInt(this double number)
        {
            return (int)Abs(number);
        }

        /// <summary>
        /// Convierte un número de tipo <see cref="double"/> en un entero,
        /// aplicando la función de techo (<see cref="Math.Ceiling"/>).
        /// </summary>
        /// <param name="number">El número de tipo <see cref="double"/> que se desea convertir.</param>
        /// <returns>
        /// El valor entero resultante de aplicar <see cref="Math.Ceiling"/> al número.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// double valor1 = 12.3;
        /// double valor2 = -7.8;
        ///
        /// int resultado1 = valor1.ToInt(); // 13
        /// int resultado2 = valor2.ToInt(); // -7
        ///
        /// Console.WriteLine($"Resultado1: {resultado1}");
        /// Console.WriteLine($"Resultado2: {resultado2}");
        /// </code>
        /// </example>
        public static int ToInt(this double number)
        {
            return Convert.ToInt32(Math.Ceiling(number));
        }

        /// <summary>
        /// Devuelve el valor absoluto de un número entero.
        /// </summary>
        /// <param name="number">El número entero que se desea evaluar.</param>
        /// <returns>
        /// El valor absoluto de <paramref name="number"/>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// int valor1 = -15;
        /// int valor2 = 20;
        ///
        /// int resultado1 = valor1.Abs(); // 15
        /// int resultado2 = valor2.Abs(); // 20
        ///
        /// Console.WriteLine($"Resultado1: {resultado1}");
        /// Console.WriteLine($"Resultado2: {resultado2}");
        /// </code>
        /// </example>
        public static int Abs(this int number)
        {
            return Math.Abs(number);
        }

        /// <summary>
        /// Devuelve el valor absoluto de un número decimal.
        /// </summary>
        /// <param name="number">El número decimal que se desea evaluar.</param>
        /// <returns>
        /// El valor absoluto de <paramref name="number"/>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// decimal valor1 = -15.75m;
        /// decimal valor2 = 20.10m;
        ///
        /// decimal resultado1 = valor1.Abs(); // 15.75
        /// decimal resultado2 = valor2.Abs(); // 20.10
        ///
        /// Console.WriteLine($"Resultado1: {resultado1}");
        /// Console.WriteLine($"Resultado2: {resultado2}");
        /// </code>
        /// </example>
        public static decimal Abs(this decimal number)
        {
            return Math.Abs(number);
        }

        /// <summary>
        /// Devuelve el valor absoluto de un número de tipo <see cref="double"/>.
        /// </summary>
        /// <param name="number">El número de tipo <see cref="double"/> que se desea evaluar.</param>
        /// <returns>
        /// El valor absoluto de <paramref name="number"/>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// double valor1 = -12.5;
        /// double valor2 = 9.3;
        ///
        /// double resultado1 = valor1.Abs(); // 12.5
        /// double resultado2 = valor2.Abs(); // 9.3
        ///
        /// Console.WriteLine($"Resultado1: {resultado1}");
        /// Console.WriteLine($"Resultado2: {resultado2}");
        /// </code>
        /// </example>
        public static double Abs(this double number)
        {
            return Math.Abs(number);
        }

        /// <summary>
        /// Redondea un número decimal a dos decimales,
        /// útil para representar valores monetarios.
        /// </summary>
        /// <param name="number">El número decimal que se desea redondear.</param>
        /// <returns>
        /// El valor de <paramref name="number"/> redondeado a dos decimales.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// decimal precio1 = 123.456m;
        /// decimal precio2 = -78.987m;
        ///
        /// decimal resultado1 = precio1.AsMoney(); // 123.46
        /// decimal resultado2 = precio2.AsMoney(); // -78.99
        ///
        /// Console.WriteLine($"Precio1: {resultado1}");
        /// Console.WriteLine($"Precio2: {resultado2}");
        /// </code>
        /// </example>
        public static decimal AsMoney(this decimal number)
        {
            return Math.Round(number, 2);
        }

        /// <summary>
        /// Convierte un número decimal en su representación porcentual,
        /// dividiéndolo entre 100.
        /// </summary>
        /// <param name="number">El número decimal que se desea convertir.</param>
        /// <returns>
        /// El valor de <paramref name="number"/> dividido entre 100.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// decimal valor1 = 75m;
        /// decimal valor2 = 12.5m;
        ///
        /// decimal resultado1 = valor1.AsDecimalPercentage(); // 0.75
        /// decimal resultado2 = valor2.AsDecimalPercentage(); // 0.125
        ///
        /// Console.WriteLine($"Resultado1: {resultado1}");
        /// Console.WriteLine($"Resultado2: {resultado2}");
        /// </code>
        /// </example>
        public static decimal AsDecimalPercentage(this decimal number)
        {
            return number / 100;
        }

        /// <summary>
        /// Convierte un valor decimal que representa minutos en su equivalente en horas.
        /// </summary>
        /// <param name="value">El valor en minutos que se desea convertir.</param>
        /// <returns>
        /// El valor en horas, calculado como <paramref name="value"/> dividido entre 60.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// decimal minutos1 = 120m;
        /// decimal minutos2 = 90m;
        ///
        /// decimal horas1 = minutos1.ToHours(); // 2
        /// decimal horas2 = minutos2.ToHours(); // 1.5
        ///
        /// Console.WriteLine($"Horas1: {horas1}");
        /// Console.WriteLine($"Horas2: {horas2}");
        /// </code>
        /// </example>
        public static decimal ToHours(this decimal value)
        {
            return value / 60;
        }

        /// <summary>
        /// Ajusta un número decimal para que tenga exactamente la cantidad de decimales especificada,
        /// rellenando con ceros a la derecha si es necesario.
        /// </summary>
        /// <param name="number">El número decimal que se desea ajustar.</param>
        /// <param name="decimalPlaces">La cantidad de posiciones decimales que debe tener el número.</param>
        /// <returns>
        /// El número ajustado con exactamente <paramref name="decimalPlaces"/> decimales.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// decimal valor1 = 12.3m;
        /// decimal valor2 = 45m;
        ///
        /// decimal resultado1 = valor1.PadRightDecimal(4); // 12.3000
        /// decimal resultado2 = valor2.PadRightDecimal(2); // 45.00
        ///
        /// Console.WriteLine($"Resultado1: {resultado1}");
        /// Console.WriteLine($"Resultado2: {resultado2}");
        /// </code>
        /// </example>
        public static decimal PadRightDecimal(this decimal number, int decimalPlaces)
        {
            var regex = new System.Text.RegularExpressions.Regex("(?<=[\\.])[0-9]+");
            var stringNumber = number.ToString();

            string decimalStringNumber = regex.IsMatch(stringNumber) ? regex.Match(stringNumber).Value : "0";
            decimalStringNumber = decimalStringNumber.PadRight(decimalPlaces, '0');

            var decimaNumber = Math.Round(Convert.ToDecimal($".{decimalStringNumber}"), decimalPlaces);

            return Math.Truncate(number) + decimaNumber;
        }

        /// <summary>
        /// Convierte un valor <see cref="decimal?"/> en <see cref="decimal"/>,
        /// devolviendo 0 si el valor es nulo.
        /// </summary>
        /// <param name="number">El valor decimal nullable que se desea evaluar.</param>
        /// <returns>
        /// El valor de <paramref name="number"/> si no es nulo; en caso contrario, 0.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// decimal? valor1 = null;
        /// decimal? valor2 = 25.75m;
        ///
        /// decimal resultado1 = valor1.DecimalValue(); // 0
        /// decimal resultado2 = valor2.DecimalValue(); // 25.75
        ///
        /// Console.WriteLine($"Resultado1: {resultado1}");
        /// Console.WriteLine($"Resultado2: {resultado2}");
        /// </code>
        /// </example>
        public static decimal DecimalValue(this decimal? number)
        {
            return number.IsNull() ? 0 : number.Value;
        }
    }
}
````

## File: Dominio/Core/Extensions/ReflectionManager.cs
````csharp
using System.Reflection;

namespace Dominio.Core.Extensions
{
    public static class ReflectionManager
    {
        /// <summary>
        /// Obtiene el valor de una propiedad de un objeto mediante reflexión
        /// y lo convierte al tipo especificado.
        /// </summary>
        /// <typeparam name="T">El tipo al que se convertirá el valor de la propiedad.</typeparam>
        /// <param name="obj">El objeto del cual se obtendrá la propiedad.</param>
        /// <param name="name">El nombre de la propiedad que se desea obtener.</param>
        /// <returns>
        /// El valor de la propiedad convertido a <typeparamref name="T"/>.
        /// Si la propiedad no existe o su valor es nulo, devuelve el valor por defecto de <typeparamref name="T"/>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// var persona = new { Nombre = "Ana", Edad = 30 };
        ///
        /// string nombre = persona.GetPropValue<string>("Nombre"); // "Ana"
        /// int edad = persona.GetPropValue<int>("Edad"); // 30
        /// int altura = persona.GetPropValue<int>("Altura"); // 0 (propiedad inexistente)
        ///
        /// Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Altura: {altura}");
        /// </code>
        /// </example>
        public static T GetPropValue<T>(this object obj, string name)
        {
            object retval = GetPropValue(obj, name);
            if (retval == null) { return default(T); }

            return (T)retval;
        }

        /// <summary>
        /// Establece el valor de una propiedad de un objeto mediante reflexión.
        /// </summary>
        /// <typeparam name="T">El tipo de la propiedad que se desea asignar.</typeparam>
        /// <param name="obj">El objeto en el cual se establecerá la propiedad.</param>
        /// <param name="name">
        /// El nombre de la propiedad que se desea establecer. 
        /// Se admite notación con puntos para propiedades anidadas.
        /// </param>
        /// <param name="value">El valor que se asignará a la propiedad.</param>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// var persona = new Persona { Nombre = "Ana", Edad = 25 };
        ///
        /// // Cambiar el valor de la propiedad "Nombre"
        /// persona.SetPropValue<string>("Nombre", "Luis");
        ///
        /// Console.WriteLine(persona.Nombre); // Luis
        /// </code>
        /// </example>
        public static void SetPropValue<T>(this object obj, string name, object value)
        {
            foreach (String part in name.Split('.'))
            {
                if (obj == null) { return; }

                Type type = obj.GetType();
                PropertyInfo info = type.GetProperty(part);
                if (info == null) { return; }

                info.SetValue(obj, (T)value, null);
            }
        }

        /// <summary>
        /// Obtiene el valor de una propiedad de un objeto mediante reflexión.
        /// Soporta propiedades anidadas usando notación con puntos.
        /// </summary>
        /// <param name="obj">El objeto del cual se obtendrá la propiedad.</param>
        /// <param name="name">
        /// El nombre de la propiedad que se desea obtener. 
        /// Se admite notación con puntos para acceder a propiedades anidadas.
        /// </param>
        /// <returns>
        /// El valor de la propiedad especificada, o <c>null</c> si el objeto es nulo,
        /// la propiedad no existe, o su valor es nulo.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// var persona = new Persona 
        /// { 
        ///     Nombre = "Ana", 
        ///     Direccion = new Direccion { Ciudad = "Madrid" } 
        /// };
        ///
        /// object nombre = persona.GetPropValue("Nombre"); // "Ana"
        /// object ciudad = persona.GetPropValue("Direccion.Ciudad"); // "Madrid"
        /// object pais = persona.GetPropValue("Direccion.Pais"); // null (propiedad inexistente)
        ///
        /// Console.WriteLine($"Nombre: {nombre}, Ciudad: {ciudad}, País: {pais}");
        /// </code>
        /// </example>
        private static object GetPropValue(this object obj, string name)
        {
            foreach (string part in name.Split('.'))
            {
                if (obj == null) { return null; }

                Type type = obj.GetType();
                PropertyInfo info = type.GetProperty(part);
                if (info == null) { return null; }

                obj = info.GetValue(obj, null);
            }
            return obj;
        }
    }
}
````

## File: Dominio/Core/Jwtoken/JwtSettings.cs
````csharp
namespace Dominio.Core.Jwtoken
{
    public class JwtSettings
    {
        public string Secret { get; set; }
        public int ExpirationInMinutes { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int RefreshTokenExpirationInDays { get; set; }
    }
}
````

## File: Dominio/Core/Result/IResult.cs
````csharp
namespace Dominio.Core.Result
{
    /// <summary>
    /// Define el contrato para un resultado de operación que puede ser exitoso o fallido.
    /// </summary>
    public interface IResult
    {
        /// <summary>
        /// Indica si la operación fue exitosa.
        /// </summary>
        bool IsSuccess { get; }

        /// <summary>
        /// Mensaje de resultado (éxito o error).
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Código de error (solo en caso de fallo).
        /// </summary>
        string? ErrorCode { get; }

        /// <summary>
        /// Errores detallados en caso de validación fallida.
        /// </summary>
        IReadOnlyCollection<string> Errors { get; }

        /// <summary>
        /// Indica el tipo/estado del resultado (validación, excepción, error de aplicación, éxito).
        /// </summary>
        ResultStatus Status { get; }
    }

    /// <summary>
    /// Versión genérica del contrato Result que incluye un valor de datos.
    /// </summary>
    public interface IResult<T> : IResult
    {
        /// <summary>
        /// Valor de datos en caso de operación exitosa.
        /// </summary>
        T? Data { get; }
    }
}
````

## File: Dominio/Core/Result/Result.cs
````csharp
namespace Dominio.Core.Result
{
    public enum ResultStatus
    {
        Success,
        ValidationError,
        ApplicationError,
        Exception
    }

    /// <summary>
    /// Clase base para resultados de operación sin valor genérico.
    /// Implementa <see cref="IResult"/> y proporciona constructores para casos de éxito y fallo.
    /// </summary>
    public class Result : IResult
    {
        /// <summary>
        /// Obtiene un valor que indica si la operación fue exitosa.
        /// </summary>
        public bool IsSuccess { get; protected set; }

        /// <summary>
        /// Obtiene el mensaje asociado al resultado (éxito o error).
        /// </summary>
        public string Message { get; protected set; }

        /// <summary>
        /// Obtiene el código de error (solo en caso de fallo).
        /// </summary>
        public string? ErrorCode { get; protected set; }

        /// <summary>
        /// Obtiene una colección de errores detallados (para validaciones fallidas).
        /// </summary>
        public IReadOnlyCollection<string> Errors { get; protected set; }

        /// <summary>
        /// Estado del resultado (éxito, validación, error de aplicación, excepción).
        /// </summary>
        public ResultStatus Status { get; protected set; }

        /// <summary>
        /// Constructor protegido para inicializar un resultado.
        /// </summary>
        protected Result(bool isSuccess, string message, string? errorCode = null, IEnumerable<string>? errors = null, ResultStatus status = ResultStatus.ApplicationError)
        {
            IsSuccess = isSuccess;
            Message = message;
            ErrorCode = errorCode;
            Errors = errors?.ToList().AsReadOnly() ?? Array.Empty<string>().AsReadOnly();
            Status = status;
        }

        /// <summary>
        /// Crea un resultado exitoso con un mensaje opcional.
        /// </summary>
        public static Result Success(string message = "Operación exitosa")
        {
            return new Result(true, message, null, null, ResultStatus.Success);
        }

        /// <summary>
        /// Crea un resultado fallido con un mensaje de error y código opcional.
        /// </summary>
        public static Result Failure(string message, string? errorCode = null)
        {
            return new Result(false, message, errorCode, null, ResultStatus.ApplicationError);
        }

        /// <summary>
        /// Crea un resultado fallido con múltiples errores de validación.
        /// </summary>
        public static Result ValidationFailure(string message, IEnumerable<string> errors, string? errorCode = null)
        {
            return new Result(false, message, errorCode, errors, ResultStatus.ValidationError);
        }
    }
}
````

## File: Dominio/Core/Result/Result{T}.cs
````csharp
namespace Dominio.Core.Result
{
    /// <summary>
    /// Clase genérica para resultados de operación que devuelven un valor de tipo <typeparamref name="T"/>.
    /// Hereda de <see cref="Result"/> e implementa <see cref="IResult{T}"/>.
    /// </summary>
    /// <typeparam name="T">Tipo del valor de datos que devuelve la operación exitosa.</typeparam>
    public class Result<T> : Result, IResult<T>
    {
        /// <summary>
        /// Obtiene el valor de datos en caso de operación exitosa.
        /// </summary>
        public T? Data { get; private set; }

        /// <summary>
        /// Constructor privado para inicializar un resultado genérico.
        /// </summary>
        private Result(bool isSuccess, T? data, string message, string? errorCode = null, IEnumerable<string>? errors = null, ResultStatus status = ResultStatus.ApplicationError)
            : base(isSuccess, message, errorCode, errors, status)
        {
            Data = data;
        }

        /// <summary>
        /// Crea un resultado exitoso con un valor de datos.
        /// </summary>
        /// <param name="data">El valor que se devuelve en caso de éxito.</param>
        /// <param name="message">Mensaje opcional de éxito.</param>
        /// <returns>Un <see cref="Result{T}"/> exitoso con el valor especificado.</returns>
        public static Result<T> Success(T data, string message = "Operación exitosa")
        {
            return new Result<T>(true, data, message, null, null, ResultStatus.Success);
        }

        /// <summary>
        /// Crea un resultado fallido sin datos.
        /// </summary>
        /// <param name="message">Mensaje de error.</param>
        /// <param name="errorCode">Código de error opcional.</param>
        /// <returns>Un <see cref="Result{T}"/> fallido.</returns>
        public static Result<T> Failure(string message, string? errorCode = null, ResultStatus status = ResultStatus.ApplicationError)
        {
            return new Result<T>(false, default, message, errorCode, null, status);
        }

        /// <summary>
        /// Crea un resultado fallido con múltiples errores de validación.
        /// </summary>
        /// <param name="message">Mensaje de error general.</param>
        /// <param name="errors">Colección de errores detallados.</param>
        /// <param name="errorCode">Código de error opcional.</param>
        /// <returns>Un <see cref="Result{T}"/> con errores de validación.</returns>
        public static Result<T> ValidationFailure(string message, IEnumerable<string> errors, string? errorCode = null)
        {
            return new Result<T>(false, default, message, errorCode, errors, ResultStatus.ValidationError);
        }

        /// <summary>
        /// Transforma el valor exitoso aplicando una función de proyección.
        /// </summary>
        /// <typeparam name="TNew">Tipo del nuevo valor proyectado.</typeparam>
        /// <param name="selector">Función que proyecta el valor actual al nuevo tipo.</param>
        /// <returns>Un nuevo <see cref="Result{TNew}"/> con el valor proyectado, o un fallo si el resultado original fue fallido.</returns>
        public Result<TNew> Map<TNew>(Func<T?, TNew> selector)
        {
            if (!IsSuccess)
            {
                return Result<TNew>.Failure(Message, ErrorCode);
            }

            try
            {
                var newData = selector(Data);
                return Result<TNew>.Success(newData, Message);
            }
            catch (Exception ex)
            {
                return Result<TNew>.Failure($"Error en proyección: {ex.Message}", "PROJECTION_ERROR", ResultStatus.Exception);
            }
        }

        /// <summary>
        /// Encadena una operación que devuelve otro resultado.
        /// </summary>
        /// <typeparam name="TNew">Tipo del valor del resultado encadenado.</typeparam>
        /// <param name="selector">Función que devuelve un nuevo resultado basado en el valor actual.</param>
        /// <returns>El resultado de la función encadenada, o un fallo si el resultado original fue fallido.</returns>
        public Result<TNew> Bind<TNew>(Func<T?, Result<TNew>> selector)
        {
            if (!IsSuccess)
            {
                return Result<TNew>.Failure(Message, ErrorCode);
            }

            try
            {
                return selector(Data);
            }
            catch (Exception ex)
            {
                return Result<TNew>.Failure($"Error en encadenamiento: {ex.Message}", "BIND_ERROR", ResultStatus.Exception);
            }
        }
    }
}
````

## File: Dominio/Dominio.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="BCrypt.Net-Next" Version="4.2.0" />
  </ItemGroup>

</Project>
````

## File: Infraestructura/Context/Mapping/EntityMap.cs
````csharp
using Dominio.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Context.Mapping
{
    internal class EntityMap<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : Entity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(t => t.FechaTransaccion).HasColumnName("FechaTransaccion");
            builder.Property(t => t.DescripcionTransaccion).HasColumnName("DescripcionTransaccion").IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(t => t.ModificadoPor).HasColumnName("ModificadoPor").IsRequired().IsUnicode(false).HasMaxLength(25);
            builder.Property(t => t.RowVersion).HasColumnName("RowVersion").ValueGeneratedOnAddOrUpdate();
            builder.Property(t => t.TipoTransaccion).HasColumnName("TipoTransaccion").IsRequired().IsUnicode(false).HasMaxLength(50);
            builder.Property(t => t.TransaccionUId).HasColumnName("TransaccionUId");
        }
    }
}
````

## File: Infraestructura/Context/Mapping/Seguridad/RolMap.cs
````csharp
using Dominio.Context.Entidades.Seguridad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Context.Mapping.Seguridad
{
    internal class RolMap : EntityMap<Rol>
    {
        public override void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.HasKey(r => r.RolId);
            builder.ToTable("Rol", "Seguridad");
            builder.Property(r => r.RolId).HasColumnName("RolId").IsRequired().IsUnicode(false).HasMaxLength(25);
            builder.Property(r => r.Descripcion).HasColumnName("Descripcion").IsRequired().IsUnicode(false).HasMaxLength(25);


            base.Configure(builder);
        }
    }
}
````

## File: Infraestructura/Core/Jwtoken/ITokenService.cs
````csharp
using Dominio.Context.Entidades.Seguridad;

namespace Infraestructura.Core.Jwtoken
{
    public interface ITokenService
    {
        string Generate(Usuario user);
        string GenerateRefreshToken();
        System.Security.Claims.ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
````

## File: Infraestructura/Core/RestClient/HttpRestClient.cs
````csharp
using Infraestructura.Core.Exception;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Infraestructura.Core.RestClient
{
    public sealed class HttpRestClient : IRestClient
    {
        private readonly HttpClient _httpClient;


        /// <summary>
        /// Creates a new instance of <see cref="HttpRestClient"/>.
        /// </summary>
        /// <param name="httpClient">The client used internally to consume rest API.</param>
        public HttpRestClient(HttpClient httpClient)
        {
            ThrowIf.Argument.IsNull(httpClient, nameof(httpClient));

            _httpClient = httpClient;
        }

        public async Task<TResponse> GetAsync<TResponse>(string uri) where TResponse : class
        {
            return await SendRequestAsync<TResponse>(uri);
        }

        /// <inheritdoc />
        public async Task<TResponse> PostAsync<TContent, TResponse>(string uri, TContent content)
            where TContent : class
            where TResponse : class
        {
            return await SendRequestAsync<TContent, TResponse>(uri, HttpMethod.Post, content);
        }

        /// <inheritdoc />
        public async Task<TResponse> PutAsync<TContent, TResponse>(string uri, TContent content)
            where TContent : class
            where TResponse : class
        {
            return await SendRequestAsync<TContent, TResponse>(uri, HttpMethod.Put, content);
        }

        /// <inheritdoc />
        public async Task<TResponse> PatchAsync<TContent, TResponse>(string uri, TContent content)
            where TContent : class
            where TResponse : class
        {
            return await SendRequestAsync<TContent, TResponse>(uri, HttpMethod.Put, content);
        }

        /// <inheritdoc />
        public async Task<TResponse> DeleteAsync<TContent, TResponse>(string uri, TContent content)
            where TContent : class
            where TResponse : class
        {
            return await SendRequestAsync<TContent, TResponse>(uri, HttpMethod.Delete, content);
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="uri">The Uri the request is sent to.</param>
        /// <returns>The task object of type <see cref="TResponse"/> representing the asynchronous operation.</returns>
        private async Task<TResponse> SendRequestAsync<TResponse>(string uri)
            where TResponse : class
        {
            HttpResponseMessage response = await _httpClient.GetAsync(uri);

            response.EnsureSuccessStatusCode();

            string stringData = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<TResponse>(stringData);
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="TContent"></typeparam>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="uri">The Uri the request is sent to.</param>
        /// <param name="httpMethod"></param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <remarks>This operation will not block. The returned task object will complete after the whole response (including content) is read.</remarks>
        /// <returns>The task object of type <see cref="TResponse"/> representing the asynchronous operation.</returns>
        private async Task<TResponse> SendRequestAsync<TContent, TResponse>(string uri, HttpMethod httpMethod, TContent content)
                        where TContent : class
            where TResponse : class
        {
            ByteArrayContent byteContent = null;

            if (content != null)
            {
                var json = JsonConvert.SerializeObject(content);

                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue(@"application/json");
            }

            HttpResponseMessage response = new HttpResponseMessage();

            switch (httpMethod?.ToString()?.ToUpper())
            {
                case "POST":
                    response = await _httpClient.PostAsync(uri, byteContent);
                    break;

                case "PUT":
                    response = await _httpClient.PutAsync(uri, byteContent);
                    break;

                case "DELETE":
                    response = await _httpClient.DeleteAsync(uri);
                    break;

                default:
                    break;
            }

            response.EnsureSuccessStatusCode();

            string stringData = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<TResponse>(stringData);
        }
    }
}
````

## File: Infraestructura/Core/RestClient/QueryStringBuilder.cs
````csharp
using System.Collections;
using System.Reflection;
using System.Web;

namespace Infraestructura.Core.RestClient
{
    public static class QueryStringBuilder
    {
        /// <summary>
        /// Covert an object into a query string.
        /// </summary>
        /// <typeparam name="T">The object type.</typeparam>
        /// <param name="obj">The object to be converted into a query string.</param>
        /// <returns>The converted query string.</returns>
        public static string GetQueryString<T>(T obj)
        {
            IEnumerable<PropertyInfo> propertyInfos = from p in obj.GetType().GetProperties()
                                                      where p.GetValue(obj, null) != null
                                                      select p;

            List<string> propertiesStringBuilder = new List<string>();

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                Type propertyType = propertyInfo.PropertyType;

                if (IsSimpleType(propertyType))
                {
                    propertiesStringBuilder.Add(GetSimpleTypeValue(obj, propertyInfo));
                }
                else
                {
                    string complexTypeValue = GetComplexTypeValue(obj, propertyInfo);
                    if (!string.IsNullOrWhiteSpace(complexTypeValue))
                    {
                        propertiesStringBuilder.Add(complexTypeValue);
                    }
                }
            }

            return string.Join("&", propertiesStringBuilder.ToArray());
        }

        private static string GetSimpleTypeValue<T>(T obj, PropertyInfo propertyInfo)
        {
            // For primitive types we just need to get the property value.
            return $"{propertyInfo.Name}={HttpUtility.UrlEncode(propertyInfo.GetValue(obj, null).ToString())}";
        }

        private static string GetComplexTypeValue<T>(T obj, PropertyInfo propertyInfo)
        {
            // For complex types first we need to figure out if the property is a collection or not.
            if (typeof(ICollection).IsAssignableFrom(propertyInfo.PropertyType))
            {
                List<string> propertiesStringBuilder = [];
                string collectionPropertyName = propertyInfo.Name;

                Type collectionType = propertyInfo.PropertyType.GetGenericArguments()[0];

                if (IsSimpleType(collectionType))
                {
                    IEnumerable collection = (IEnumerable)propertyInfo.GetValue(obj, null);

                    foreach (var item in collection)
                    {
                        if (item != null)
                        {
                            string collectionItem = $"{collectionPropertyName}={HttpUtility.UrlEncode(item.ToString())}";

                            propertiesStringBuilder.Add(collectionItem);
                        }
                    }
                }

                return string.Join("&", propertiesStringBuilder.ToArray());
            }

            return string.Empty;
        }

        private static bool IsSimpleType(Type type)
        {
            return
                type.IsPrimitive ||
                new Type[] {
                              typeof (Enum),
                              typeof (string),
                              typeof (char),
                              typeof (Guid),
                              typeof (bool),
                              typeof (byte),
                              typeof (short),
                              typeof (int),
                              typeof (long),
                              typeof (float),
                              typeof (double),
                              typeof (decimal),
                              typeof (sbyte),
                              typeof (ushort),
                              typeof (uint),
                              typeof (ulong),
                              typeof (DateTime),
                              typeof (DateTimeOffset),
                              typeof (TimeSpan),
                }.Contains(type) ||
                Convert.GetTypeCode(type) != TypeCode.Object ||
                (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>) && IsSimpleType(type.GetGenericArguments()[0]))
                ;
        }
    }
}
````

## File: Infraestructura/Core/RestClient/RestClientFactory.cs
````csharp
namespace Infraestructura.Core.RestClient
{
    public static class RestClientFactory
    {
        private static IRestClientFactory _currentRestClientFactory;

        /// <summary>
        /// Set the  rest client factory to use.
        /// </summary>
        /// <param name="restClientFactory">Rest client factory to use</param>
        public static void SetCurrent(IRestClientFactory restClientFactory)
        {
            _currentRestClientFactory = restClientFactory;
        }

        /// <summary>
        /// Create a new 
        /// <paramref>
        /// <name>Crosscutting.RestClient.IRestClient</name>
        /// </paramref>
        /// </summary>
        /// <param name="baseAddress">The API base address to connect to.</param>
        /// <returns>Created IRestClient</returns>        
        public static IRestClient CreateClient(string baseAddress)
        {
            return (_currentRestClientFactory != null) ? _currentRestClientFactory.Create(baseAddress) : null;
        }
    }
}
````

## File: TemplateBackEndNetCore.sln
````
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 17
VisualStudioVersion = 17.8.34525.116
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "WebServices", "WebServices\WebServices.csproj", "{27705E8A-5390-4B4D-A2A5-19FB026D2E60}"
EndProject
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "Dominio", "Dominio\Dominio.csproj", "{27BF5AFE-D194-4BC3-BCB8-27F2D8B9959A}"
EndProject
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "Infraestructura", "Infraestructura\Infraestructura.csproj", "{DFF2031D-E784-422E-B7D4-046E73D0DB2B}"
EndProject
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "Aplicacion", "Aplicacion\Aplicacion.csproj", "{9C7F5DC8-AD78-44D5-B276-DE9AD5FC4A9E}"
EndProject
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "CrossCutting", "CrossCutting\CrossCutting.csproj", "{EAB273EC-619A-46C6-AFE1-D2EBA66A14DD}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{27705E8A-5390-4B4D-A2A5-19FB026D2E60}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{27705E8A-5390-4B4D-A2A5-19FB026D2E60}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{27705E8A-5390-4B4D-A2A5-19FB026D2E60}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{27705E8A-5390-4B4D-A2A5-19FB026D2E60}.Release|Any CPU.Build.0 = Release|Any CPU
		{27BF5AFE-D194-4BC3-BCB8-27F2D8B9959A}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{27BF5AFE-D194-4BC3-BCB8-27F2D8B9959A}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{27BF5AFE-D194-4BC3-BCB8-27F2D8B9959A}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{27BF5AFE-D194-4BC3-BCB8-27F2D8B9959A}.Release|Any CPU.Build.0 = Release|Any CPU
		{DFF2031D-E784-422E-B7D4-046E73D0DB2B}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{DFF2031D-E784-422E-B7D4-046E73D0DB2B}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{DFF2031D-E784-422E-B7D4-046E73D0DB2B}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{DFF2031D-E784-422E-B7D4-046E73D0DB2B}.Release|Any CPU.Build.0 = Release|Any CPU
		{9C7F5DC8-AD78-44D5-B276-DE9AD5FC4A9E}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{9C7F5DC8-AD78-44D5-B276-DE9AD5FC4A9E}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{9C7F5DC8-AD78-44D5-B276-DE9AD5FC4A9E}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{9C7F5DC8-AD78-44D5-B276-DE9AD5FC4A9E}.Release|Any CPU.Build.0 = Release|Any CPU
		{EAB273EC-619A-46C6-AFE1-D2EBA66A14DD}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{EAB273EC-619A-46C6-AFE1-D2EBA66A14DD}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{EAB273EC-619A-46C6-AFE1-D2EBA66A14DD}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{EAB273EC-619A-46C6-AFE1-D2EBA66A14DD}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {5AEF57F0-D726-432E-A5E8-A202D08133A8}
	EndGlobalSection
EndGlobal
````

## File: WebServices/Controllers/TestRestClient.cs
````csharp
using Infraestructura.Core.RestClient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestRestClient : Controller
    {
        [AllowAnonymous]
        [Route("")]
        [HttpGet]
        public Principal getData()
        {
            var response = new Principal();
            Task.Run(async () =>
            {
                response = await getExample();
            }).GetAwaiter().GetResult();

            var responsePost = new MethodPostResponse();

            Task.Run(async () =>
            {
                responsePost = await Post();
            }).GetAwaiter().GetResult();

            return response;
        }

        private async Task<Principal> getExample()
        {
            string baseUri = "https://coderbyte.com";
            string uri = "/api/challenges/json/json-cleaning";
            return await RestClientFactory.CreateClient(baseUri).GetAsync<Principal>(uri);
        }


        private async Task<MethodPostResponse> Post()
        {
            var baseUri = "https://postman-echo.com";
            var uri = "/post";
            var request = new MethodPostRequest { Test = "value"};

            return await RestClientFactory.CreateClient(baseUri).PostAsync<MethodPostRequest, MethodPostResponse>(uri, request);
        }
    }

    public class MethodPostRequest
    {
        public string Test { get; set; }
    }

    public class MethodPostResponse
    {
        public Args? Args { get; set; }
        public Args? Data { get; set; }
        public Args? Files { get; set; }
    }

    public class Args 
    {
        public string? Test { get; set; }
        public string? host { get; set; }
        public string? cookie { get; set; }
    }


    public class Principal
    {
        public Name? Name { get; set; }
        public int? Age { get; set; }
    }

    public class Name
    {

        public string? First { get; set; }
        public string? middle { get; set; }
        public string? last { get; set; }
        //{"name":{"first":"Robert","middle":"","last":"Smith"},"age":25,"DOB":"-","hobbies":["running","coding","-"],"education":{"highschool":"N\/A","college":"Yale"}}
    }
}
````

## File: WebServices/Middleware/GlobalExceptionHandlingMiddleware.cs
````csharp
using Dominio.Core.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace WebServices.Middleware
{
    public class GlobalExceptionHandlingMiddleware : IMiddleware
    {
        private readonly ILogger<GlobalExceptionHandlingMiddleware> _logger;

        public GlobalExceptionHandlingMiddleware(ILogger<GlobalExceptionHandlingMiddleware> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception e)
            {

                _logger.LogError(e, "Unhandled exception");

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                ProblemDetails problem = new()
                {
                    Status = (int)HttpStatusCode.InternalServerError,
                    Type = "Server Error",
                    Title = "An internal server error occurred.",
                    Detail = "An internal server error occurred.",
                };

                string json = JsonSerializer.Serialize(problem);

                context.Response.ContentType = "application/json";

                await context.Response.WriteAsync(json);
            }
        }
    }
}
````

## File: WebServices/Properties/launchSettings.json
````json
{
  "$schema": "http://json.schemastore.org/launchsettings.json",
  "iisSettings": {
    "windowsAuthentication": false,
    "anonymousAuthentication": true,
    "iisExpress": {
      "applicationUrl": "http://localhost:1876",
      "sslPort": 44325
    }
  },
  "profiles": {
    "http": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "launchUrl": "scalar/v1",
      "applicationUrl": "http://localhost:5283",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "https": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "launchUrl": "scalar/v1",
      "applicationUrl": "https://localhost:7217;http://localhost:5283",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "launchUrl": "scalar/v1",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "runtimeOptions": {
      "configProperties": {
        "System.Globalization.Invariant": false
      }
    }
  }
}
````

## File: Aplicacion/DTOs/QueryInfo.cs
````csharp
using System.Text;

namespace Aplicacion.DTOs
{
    public sealed class QueryInfo
    {
        public QueryInfo()
        {
            PageIndex = 0;
            PageSize = 10;
            SortFields = [];
            CustomFilters = [];
        }

        /// <summary>
        /// The page index define in the query.
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// The page size define for the query.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// The list of fields to be sorted in the query.
        /// </summary>
        public List<string>? SortFields { get; set; }

        /// <summary>
        /// Indicates if the query will sort the result in ascending order.
        /// </summary>
        public bool Ascending { get; set; }

        /// <summary>
        /// A custom filter to apply to the query.
        /// </summary>
        public string? Predicate { get; set; }

        /// <summary>
        /// The parameters that will be applied to the query.
        /// </summary>
        public object[] ParamValues { get; set; }

        /// <summary>
        /// The names of tables to be included in the query, this is used to eagerly load those tables and avoid to scan the table.
        /// </summary>
        public List<string>? Includes { get; set; }

        /// <summary>
        /// The Custom Query Operation to Perform.
        /// </summary>
        public string? CustomQueryOperation { get; set; }

        public Dictionary<string, object> CustomFilters { get; set; }

        /// <summary>
        /// Gets the Uniform Resource Name that identifies resources.
        /// </summary>
        /// <returns>The Uniform Resource Name for the query request.</returns>
        public string GetUrn()
        {
            var sortFields = string.Join("|", SortFields.ToArray());
            string paramValues = GetParamValues(ParamValues);

            var urn = string.Format("{0}-{1}-{2}-{3}-{4}-{5}", Predicate,
                                    paramValues, PageIndex, PageSize,
                                    Ascending, sortFields);

            return urn;
        }

        private string GetParamValues(object[] paramValues)
        {
            if (paramValues != null)
            {
                var valuesStringBuild = new StringBuilder();

                foreach (var paramValue in paramValues)
                {
                    valuesStringBuild.Append(paramValue);
                }

                return valuesStringBuild.ToString();
            }

            return string.Empty;
        }


    }
}
````

## File: Aplicacion/DTOs/ResponseBase.cs
````csharp
using Dominio.Core.Extensions;

namespace Aplicacion.DTOs
{
    public abstract class ResponseBase
    {
        public string? Message { get; set; }
        public string? ValidationErrorMessage { get; set; }
        public string? SuccessMessage { get; set; }
        public DateTime? FechaTransaccion { get; set; }

        public bool HasValidationMessage()
        {
            return Message.HasValue();
        }

        public bool HasValidationErrorMessage()
        {
            return !string.IsNullOrWhiteSpace(ValidationErrorMessage);
        }

        public void AppendValidationErrorMessage(string message)
        {
            if (HasValidationErrorMessage())
            {
                ValidationErrorMessage = $"{ValidationErrorMessage}, {message}";
                return;
            }

            ValidationErrorMessage = message;
        }
    }
}
````

## File: Dominio/Context/Entidades/Seguridad/Rol.cs
````csharp
using Dominio.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Context.Entidades.Seguridad
{
    public class Rol : Entity
    {
        [ForeignKey("Usuario")]
        public string? RolId { get; set; }
        public string? Descripcion { get; set; }
        public virtual List<Permisos>? Permisos { get; set; }
        public virtual ICollection<Usuario>? Usuarios { get; set; }

    }
}
````

## File: Dominio/Core/Entity.cs
````csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Core
{
    public abstract class Entity
    {
        public string? ModificadoPor { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public string DescripcionTransaccion { get; set; }
        public byte[] RowVersion { get; set; }
        public Guid TransaccionUId { get; set; }
        public string TipoTransaccion { get; set; }
    }
}
````

## File: Dominio/Core/Extensions/DateTimeExtensions.cs
````csharp
using System.Globalization;

namespace Dominio.Core.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Devuelve una representación en cadena de un objeto <see cref="DateTime"/> 
        /// con el formato "yyyy-MMM-dd hh:mm tt".
        /// </summary>
        /// <param name="date">La fecha y hora que se desea formatear.</param>
        /// <returns>
        /// Una cadena que representa la fecha y hora en el formato:
        /// Año-Mes abreviado-Día Hora:minutos AM/PM.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// DateTime fechaActual = DateTime.Now;
        /// string resultado = fechaActual.WeekDateName();
        /// Console.WriteLine(resultado);
        /// // Salida posible: "2026-Apr-02 02:50 PM"
        /// </code>
        /// </example>
        public static string WeekDateName(this DateTime date)
        {
            return date.ToString("yyyy-MMM-dd hh:mm tt");
        }

        /// <summary>
        /// Devuelve la fecha mínima (más antigua) de una colección de objetos <see cref="DateTime"/>.
        /// </summary>
        /// <param name="dates">La colección de fechas de la cual se obtendrá la mínima.</param>
        /// <returns>
        /// El valor <see cref="DateTime"/> más pequeño dentro de la colección.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Se produce si la colección está vacía.
        /// </exception>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// List<DateTime> fechas = new List<DateTime>
        /// {
        ///     new DateTime(2026, 4, 2),
        ///     new DateTime(2025, 12, 25),
        ///     new DateTime(2026, 1, 1)
        /// };
        ///
        /// DateTime fechaMinima = fechas.MinDate();
        /// Console.WriteLine(fechaMinima);
        /// // Salida: 25/12/2025
        /// </code>
        /// </example>
        public static DateTime MinDate(this IEnumerable<DateTime> dates)
        {
            return dates.Items().Min(c => c);
        }

        /// <summary>
        /// Devuelve la fecha máxima (más reciente) de una colección de objetos <see cref="DateTime"/>.
        /// </summary>
        /// <param name="dates">La colección de fechas de la cual se obtendrá la máxima.</param>
        /// <returns>
        /// El valor <see cref="DateTime"/> más grande dentro de la colección.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Se produce si la colección está vacía.
        /// </exception>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// List<DateTime> fechas = new List<DateTime>
        /// {
        ///     new DateTime(2026, 4, 2),
        ///     new DateTime(2025, 12, 25),
        ///     new DateTime(2026, 1, 1)
        /// };
        ///
        /// DateTime fechaMaxima = fechas.MaxDate();
        /// Console.WriteLine(fechaMaxima);
        /// // Salida: 02/04/2026
        /// </code>
        /// </example>
        public static DateTime MaxDate(this IEnumerable<DateTime> dates)
        {
            return dates.Items().Max(c => c);
        }

        /// <summary>
        /// Determina si una fecha ocurre antes de otra fecha dada.
        /// </summary>
        /// <param name="date">La fecha que se desea evaluar.</param>
        /// <param name="startDate">La fecha de referencia para comparar.</param>
        /// <returns>
        /// <c>true</c> si <paramref name="date"/> ocurre antes de <paramref name="startDate"/>; 
        /// en caso contrario, <c>false</c>. 
        /// También devuelve <c>false</c> si cualquiera de las fechas es nula.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// DateTime? fechaEvento = new DateTime(2025, 12, 25);
        /// DateTime? fechaReferencia = new DateTime(2026, 1, 1);
        ///
        /// bool ocurreAntes = fechaEvento.OccursBefore(fechaReferencia);
        /// Console.WriteLine(ocurreAntes);
        /// // Salida: True (porque 25/12/2025 ocurre antes de 01/01/2026)
        /// </code>
        /// </example>
        public static bool OccursBefore(this DateTime? date, DateTime? startDate)
        {
            if (!date.HasValue || !startDate.HasValue) return false;

            return startDate.Value.Ticks > date.Value.Ticks;
        }

        /// <summary>
        /// Determina si una fecha se encuentra dentro de un rango específico.
        /// </summary>
        /// <param name="date">La fecha que se desea evaluar.</param>
        /// <param name="startDate">La fecha inicial del rango.</param>
        /// <param name="endDate">La fecha final del rango.</param>
        /// <returns>
        /// <c>true</c> si <paramref name="date"/> está entre <paramref name="startDate"/> 
        /// (inclusive) y <paramref name="endDate"/> (exclusiva); en caso contrario, <c>false</c>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// DateTime fecha = new DateTime(2026, 4, 2);
        /// DateTime inicio = new DateTime(2026, 4, 1);
        /// DateTime fin = new DateTime(2026, 4, 10);
        ///
        /// bool dentroDelRango = fecha.Between(inicio, fin);
        /// Console.WriteLine(dentroDelRango);
        /// // Salida: True (porque 02/04/2026 está entre 01/04/2026 y 10/04/2026)
        /// </code>
        /// </example>
        public static bool Between(this DateTime date, DateTime startDate, DateTime endDate)
        {
            if (date.IsNull() || startDate.IsNull()) return false;

            return date.Ticks >= startDate.Ticks && date.Ticks < endDate.Ticks;
        }

        /// <summary>
        /// Obtiene el número de semana del año para una fecha determinada,
        /// utilizando la cultura actual del sistema.
        /// </summary>
        /// <param name="date">La fecha de la cual se desea obtener el número de semana.</param>
        /// <returns>
        /// Un entero que representa el número de semana del año en el que cae la fecha.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// DateTime fecha = new DateTime(2026, 4, 2);
        /// int numeroSemana = fecha.GetWeekNumber();
        /// Console.WriteLine(numeroSemana);
        /// // Salida posible: 14 (dependiendo de la configuración cultural del sistema)
        /// </code>
        /// </example>
        public static int GetWeekNumber(this DateTime date)
        {
            CultureInfo cul = CultureInfo.CurrentCulture;

            return cul.Calendar.GetWeekOfYear(
                 date,
                 CalendarWeekRule.FirstDay,
                 DayOfWeek.Sunday);
        }

        /// <summary>
        /// Obtiene el número de la última semana del año actual.
        /// </summary>
        /// <param name="date">
        /// La fecha de referencia (no se utiliza directamente, ya que se reemplaza por el 31 de diciembre del año actual).
        /// </param>
        /// <returns>
        /// Un entero que representa el número de la última semana del año actual.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// DateTime fecha = DateTime.Now;
        /// int ultimaSemana = fecha.GetLastWeekNumberCurrentYear();
        /// Console.WriteLine(ultimaSemana);
        /// // Salida posible: 52 o 53 (dependiendo de cómo se calculen las semanas en la cultura actual)
        /// </code>
        /// </example>
        public static int GetLastWeekNumberCurrentYear(this DateTime date)
        {
            date = new DateTime(DateTime.Now.Year, 12, 31);
            return date.GetWeekNumber();
        }

        /// <summary>
        /// Determina si un objeto <see cref="DateTime"/> tiene el valor por defecto.
        /// </summary>
        /// <param name="dateTime">La fecha que se desea evaluar.</param>
        /// <returns>
        /// <c>true</c> si <paramref name="dateTime"/> es igual a <c>default(DateTime)</c>
        /// (01/01/0001 00:00:00); en caso contrario, <c>false</c>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// DateTime fecha1 = default(DateTime);
        /// DateTime fecha2 = DateTime.Now;
        ///
        /// bool esDefault1 = fecha1.HasDefaultValue(); // True
        /// bool esDefault2 = fecha2.HasDefaultValue(); // False
        ///
        /// Console.WriteLine($"Fecha1 es default: {esDefault1}");
        /// Console.WriteLine($"Fecha2 es default: {esDefault2}");
        /// </code>
        /// </example>
        public static bool HasDefaultValue(this DateTime dateTime)
        {
            return dateTime == default(DateTime);
        }
    }
}
````

## File: Dominio/Core/Extensions/StringExtensions.cs
````csharp
using System.Text.RegularExpressions;

namespace Dominio.Core.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Convierte una cadena en un arreglo de objetos con un único elemento,
        /// asegurando que el valor no sea nulo mediante <c>ValueOrEmpty()</c>.
        /// </summary>
        /// <param name="value">La cadena que se desea convertir.</param>
        /// <returns>
        /// Un arreglo de objetos que contiene un único elemento:
        /// la cadena original o una cadena vacía si es nula.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// string texto1 = "Hola";
        /// string texto2 = null;
        ///
        /// object[] resultado1 = texto1.ToObject(); // { "Hola" }
        /// object[] resultado2 = texto2.ToObject(); // { "" }
        ///
        /// Console.WriteLine($"Resultado1: {resultado1[0]}");
        /// Console.WriteLine($"Resultado2: {resultado2[0]}");
        /// </code>
        /// </example>
        public static object[] ToObject(this string? value)
        {
            return new object[] { value.ValueOrEmpty() };
        }

        /// <summary>
        /// Convierte una cadena en un valor <see cref="decimal"/>.
        /// Si la cadena es nula, vacía o no puede convertirse, devuelve 0.
        /// </summary>
        /// <param name="decimalStringValue">La cadena que representa un número decimal.</param>
        /// <returns>
        /// El valor convertido a <see cref="decimal"/> si la cadena es válida; en caso contrario, 0.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// string texto1 = "123.45";
        /// string texto2 = "abc";
        /// string texto3 = null;
        ///
        /// decimal resultado1 = texto1.ToDecimal(); // 123.45
        /// decimal resultado2 = texto2.ToDecimal(); // 0
        /// decimal resultado3 = texto3.ToDecimal(); // 0
        ///
        /// Console.WriteLine($"Resultado1: {resultado1}");
        /// Console.WriteLine($"Resultado2: {resultado2}");
        /// Console.WriteLine($"Resultado3: {resultado3}");
        /// </code>
        /// </example>
        public static decimal ToDecimal(this string? decimalStringValue)
        {
            decimal decimalValue = 0;
            if (decimalStringValue.HasValue())
            {
                Decimal.TryParse(decimalStringValue, out decimalValue);
            }
            return decimalValue;
        }

        /// <summary>
        /// Convierte una cadena en un valor <see cref="int"/>.
        /// Si la cadena es nula, vacía o no puede convertirse, devuelve 0.
        /// </summary>
        /// <param name="decimalStringValue">La cadena que representa un número entero.</param>
        /// <returns>
        /// El valor convertido a <see cref="int"/> si la cadena es válida; en caso contrario, 0.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// string texto1 = "123";
        /// string texto2 = "abc";
        /// string texto3 = null;
        ///
        /// int resultado1 = texto1.ToInt(); // 123
        /// int resultado2 = texto2.ToInt(); // 0
        /// int resultado3 = texto3.ToInt(); // 0
        ///
        /// Console.WriteLine($"Resultado1: {resultado1}");
        /// Console.WriteLine($"Resultado2: {resultado2}");
        /// Console.WriteLine($"Resultado3: {resultado3}");
        /// </code>
        /// </example>
        public static int ToInt(this string? decimalStringValue)
        {
            int decimalValue = 0;
            if (decimalStringValue.HasValue())
            {
                Int32.TryParse(decimalStringValue, out decimalValue);
            }
            return decimalValue;
        }

        /// <summary>
        /// Extrae todos los caracteres numéricos de una cadena,
        /// devolviendo una nueva cadena compuesta únicamente por dígitos.
        /// </summary>
        /// <param name="decimalStringValue">La cadena de entrada que puede contener números y otros caracteres.</param>
        /// <returns>
        /// Una cadena que contiene únicamente los dígitos presentes en <paramref name="decimalStringValue"/>.
        /// Si la cadena es nula o vacía, devuelve una cadena vacía.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// string texto1 = "Tel: +504-9876-1234";
        /// string texto2 = "Precio: $123.45";
        /// string texto3 = null;
        ///
        /// string resultado1 = texto1.GetNumericValues(); // "50498761234"
        /// string resultado2 = texto2.GetNumericValues(); // "12345"
        /// string resultado3 = texto3.GetNumericValues(); // ""
        ///
        /// Console.WriteLine($"Resultado1: {resultado1}");
        /// Console.WriteLine($"Resultado2: {resultado2}");
        /// Console.WriteLine($"Resultado3: {resultado3}");
        /// </code>
        /// </example>
        public static string GetNumericValues(this string? decimalStringValue)
        {
            string output = string.Empty;
            if (decimalStringValue.HasValue())
            {
                output = new string(decimalStringValue.ToCharArray().Where(c => char.IsDigit(c)).ToArray());
            }
            return output;
        }

        /// <summary>
        /// Verifica si una cadena tiene un valor válido,
        /// es decir, que no sea nula, vacía ni compuesta únicamente por espacios en blanco.
        /// </summary>
        /// <param name="stringValue">La cadena que se desea evaluar.</param>
        /// <returns>
        /// <c>true</c> si la cadena contiene un valor válido; en caso contrario, <c>false</c>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// string texto1 = "Hola";
        /// string texto2 = "";
        /// string texto3 = "   ";
        /// string texto4 = null;
        ///
        /// bool resultado1 = texto1.HasValue(); // true
        /// bool resultado2 = texto2.HasValue(); // false
        /// bool resultado3 = texto3.HasValue(); // false
        /// bool resultado4 = texto4.HasValue(); // false
        ///
        /// Console.WriteLine($"Texto1: {resultado1}, Texto2: {resultado2}, Texto3: {resultado3}, Texto4: {resultado4}");
        /// </code>
        /// </example>
        public static bool HasValue(this string? stringValue)
        {
            return !string.IsNullOrEmpty(stringValue) && !string.IsNullOrWhiteSpace(stringValue);
        }

        /// <summary>
        /// Devuelve la cadena original si contiene un valor válido,
        /// o una cadena vacía si es nula, vacía o compuesta únicamente por espacios.
        /// </summary>
        /// <param name="stringValue">La cadena que se desea evaluar.</param>
        /// <returns>
        /// La cadena original recortada con <see cref="string.Trim"/> si tiene valor;
        /// en caso contrario, <see cref="string.Empty"/>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// string texto1 = " Hola ";
        /// string texto2 = "";
        /// string texto3 = "   ";
        /// string texto4 = null;
        ///
        /// string resultado1 = texto1.ValueOrEmpty(); // "Hola"
        /// string resultado2 = texto2.ValueOrEmpty(); // ""
        /// string resultado3 = texto3.ValueOrEmpty(); // ""
        /// string resultado4 = texto4.ValueOrEmpty(); // ""
        ///
        /// Console.WriteLine($"Texto1: '{resultado1}', Texto2: '{resultado2}', Texto3: '{resultado3}', Texto4: '{resultado4}'");
        /// </code>
        /// </example>
        public static string ValueOrEmpty(this string? stringValue)
        {
            return HasValue(stringValue) ? stringValue.Trim() : string.Empty;
        }

        /// <summary>
        /// Convierte un objeto en su representación de cadena.
        /// Si el objeto es nulo, devuelve una cadena vacía.
        /// </summary>
        /// <param name="stringValue">El objeto que se desea convertir a cadena.</param>
        /// <returns>
        /// La representación en cadena del objeto, recortada con <see cref="string.Trim"/> si no es nulo;
        /// en caso contrario, <see cref="string.Empty"/>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// object valor1 = " Hola ";
        /// object valor2 = 123;
        /// object valor3 = null;
        ///
        /// string resultado1 = valor1.ToStringValue(); // "Hola"
        /// string resultado2 = valor2.ToStringValue(); // "123"
        /// string resultado3 = valor3.ToStringValue(); // ""
        ///
        /// Console.WriteLine($"Resultado1: '{resultado1}', Resultado2: '{resultado2}', Resultado3: '{resultado3}'");
        /// </code>
        /// </example>
        public static string ToStringValue(this object stringValue)
        {
            return stringValue != null ? stringValue.ToString().Trim() : string.Empty;
        }

        /// <summary>
        /// Verifica si una cadena está vacía, es nula o contiene únicamente espacios en blanco.
        /// </summary>
        /// <param name="stringValue">La cadena que se desea evaluar.</param>
        /// <returns>
        /// <c>true</c> si la cadena no tiene un valor válido (es nula, vacía o solo espacios);
        /// en caso contrario, <c>false</c>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// string texto1 = "Hola";
        /// string texto2 = "";
        /// string texto3 = "   ";
        /// string texto4 = null;
        ///
        /// bool resultado1 = texto1.IsMissingValue(); // false
        /// bool resultado2 = texto2.IsMissingValue(); // true
        /// bool resultado3 = texto3.IsMissingValue(); // true
        /// bool resultado4 = texto4.IsMissingValue(); // true
        ///
        /// Console.WriteLine($"Texto1: {resultado1}, Texto2: {resultado2}, Texto3: {resultado3}, Texto4: {resultado4}");
        /// </code>
        /// </example>
        public static bool IsMissingValue(this string? stringValue)
        {
            return !HasValue(stringValue);
        }

        /// <summary>
        /// Divide una cadena en una lista de subcadenas.
        /// Si se proporcionan separadores, utiliza el primero de ellos.
        /// Si no se proporcionan, divide la cadena por saltos de línea.
        /// </summary>
        /// <param name="value">La cadena que se desea dividir.</param>
        /// <param name="separators">
        /// Opcional: uno o más caracteres separadores. 
        /// Si se especifican, se usa el primero para realizar la división.
        /// </param>
        /// <returns>
        /// Una lista de subcadenas obtenidas a partir de <paramref name="value"/>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// string texto1 = "uno,dos,tres";
        /// string texto2 = "linea1\r\nlinea2\r\nlinea3";
        ///
        /// List<string> lista1 = texto1.SplitIntoList(','); 
        /// // { "uno", "dos", "tres" }
        ///
        /// List<string> lista2 = texto2.SplitIntoList(); 
        /// // { "linea1", "linea2", "linea3" }
        ///
        /// Console.WriteLine(string.Join(" | ", lista1));
        /// Console.WriteLine(string.Join(" | ", lista2));
        /// </code>
        /// </example>
        public static List<string> SplitIntoList(this string value, params char[] separators)
        {
            if (separators.HasItems())
            {
                var firstSeparator = separators.First();
                var messagesKeys = value.Split(firstSeparator);
                return messagesKeys.ToList();
            }
            else
            {
                var observaciones = value.Replace("\r\n", "\n");
                var messagesKeys = observaciones.Split('\n');
                return messagesKeys.ToList();
            }
        }

        /// <summary>
        /// Divide una cadena en una lista de subcadenas utilizando separadores,
        /// y opcionalmente elimina caracteres especiales definidos en <paramref name="toExclude"/>.
        /// </summary>
        /// <param name="value">La cadena que se desea dividir.</param>
        /// <param name="toExclude">
        /// Conjunto de caracteres que se deben eliminar de cada subcadena resultante.
        /// Si está vacío o nulo, no se eliminan caracteres adicionales.
        /// </param>
        /// <param name="separators">
        /// Uno o más caracteres separadores. 
        /// Si se especifican, se usa el primero para realizar la división.
        /// Si no se especifican, se divide por saltos de línea.
        /// </param>
        /// <returns>
        /// Una lista de subcadenas obtenidas a partir de <paramref name="value"/>,
        /// con los caracteres excluidos eliminados si corresponde.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// string texto1 = "uno@,dos#,tres$";
        /// var lista1 = texto1.SplitIntoListWithOutSpecialCharacters(new[] { '@', '#', '$' }, ',');
        /// // { "uno", "dos", "tres" }
        ///
        /// string texto2 = "linea1\r\nlinea2\r\nlinea3";
        /// var lista2 = texto2.SplitIntoListWithOutSpecialCharacters(null);
        /// // { "linea1", "linea2", "linea3" }
        ///
        /// Console.WriteLine(string.Join(" | ", lista1));
        /// Console.WriteLine(string.Join(" | ", lista2));
        /// </code>
        /// </example>
        public static List<string> SplitIntoListWithOutSpecialCharacters(this string value, IEnumerable<char> toExclude, params char[] separators)
        {
            if (separators.HasItems())
            {
                var firstSeparator = separators.First();
                var messagesKeys = value.Split(firstSeparator);
                var returnList = messagesKeys.ToList();
                var result = new List<string>();
                if (toExclude.HasItems())
                {
                    foreach (var item in returnList)
                    {
                        var newString = item.Trim();
                        foreach (var forbidenItem in toExclude)
                        {
                            newString.Replace(forbidenItem.ToString(), string.Empty);
                        }
                        result.Add(newString);
                    }
                    return result;
                }
                return returnList;
            }
            else
            {
                var observaciones = value.Replace("\r\n", "\n");
                var messagesKeys = observaciones.Split('\n');
                return messagesKeys.ToList();
            }
        }

        /// <summary>
        /// Convierte una cadena en un valor <see cref="DateTime"/>.
        /// Si la cadena es nula, vacía o no puede convertirse, devuelve <see cref="DateTime.MinValue"/>.
        /// </summary>
        /// <param name="dateStringValue">La cadena que representa una fecha.</param>
        /// <returns>
        /// El valor convertido a <see cref="DateTime"/> si la cadena es válida; 
        /// en caso contrario, <see cref="DateTime.MinValue"/>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// string texto1 = "2026-04-02";
        /// string texto2 = "02/04/2026 16:30";
        /// string texto3 = "fecha inválida";
        /// string texto4 = null;
        ///
        /// DateTime resultado1 = texto1.ToDateTime(); // 2026-04-02 00:00:00
        /// DateTime resultado2 = texto2.ToDateTime(); // 2026-04-02 16:30:00
        /// DateTime resultado3 = texto3.ToDateTime(); // DateTime.MinValue
        /// DateTime resultado4 = texto4.ToDateTime(); // DateTime.MinValue
        ///
        /// Console.WriteLine($"Resultado1: {resultado1}");
        /// Console.WriteLine($"Resultado2: {resultado2}");
        /// Console.WriteLine($"Resultado3: {resultado3}");
        /// Console.WriteLine($"Resultado4: {resultado4}");
        /// </code>
        /// </example>
        public static DateTime ToDateTime(this string? dateStringValue)
        {
            DateTime dateValue = DateTime.MinValue;
            if (dateStringValue.HasValue())
            {
                DateTime.TryParse(dateStringValue, out dateValue);
            }
            return dateValue;
        }

        /// <summary>
        /// Inserta espacios antes de cada letra mayúscula en una cadena,
        /// devolviendo el resultado con un formato más legible.
        /// </summary>
        /// <param name="value">La cadena de entrada que contiene letras mayúsculas.</param>
        /// <returns>
        /// Una nueva cadena con espacios añadidos antes de cada letra mayúscula.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// string texto1 = "HolaMundo";
        /// string texto2 = "XMLParserExtension";
        ///
        /// string resultado1 = texto1.AddSpacesBeforeCapitalLetters(); 
        /// // "Hola Mundo"
        ///
        /// string resultado2 = texto2.AddSpacesBeforeCapitalLetters(); 
        /// // "XML Parser Extension"
        ///
        /// Console.WriteLine(resultado1);
        /// Console.WriteLine(resultado2);
        /// </code>
        /// </example>
        public static string AddSpacesBeforeCapitalLetters(this string? value)
        {
            if (!value.HasValue())
            {
                return string.Empty;
            }

            return string.Concat(value.Select(x => Char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');
        }

        /// <summary>
        /// Verifica si una cadena contiene únicamente caracteres numéricos (dígitos).
        /// </summary>
        /// <param name="str">La cadena que se desea evaluar.</param>
        /// <returns>
        /// <c>true</c> si la cadena contiene solo dígitos.
        /// Si la cadena es nula o vacía, devuelve <c>true</c> por diseño.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// string texto1 = "12345";
        /// string texto2 = "12a45";
        /// string texto3 = "";
        /// string texto4 = null;
        ///
        /// bool resultado1 = texto1.IsNumeric(); // true
        /// bool resultado2 = texto2.IsNumeric(); // false
        /// bool resultado3 = texto3.IsNumeric(); // true
        /// bool resultado4 = texto4.IsNumeric(); // true
        ///
        /// Console.WriteLine($"Texto1: {resultado1}, Texto2: {resultado2}, Texto3: {resultado3}, Texto4: {resultado4}");
        /// </code>
        /// </example>
        public static bool IsNumeric(this string str)
        {
            if (str.HasValue())
            {
                return !str.ToArray().Any(a => !char.IsDigit(a));
            }
            return true;
        }

        /// <summary>
        /// Verifica si una cadena representa un número decimal válido.
        /// Se permiten dígitos y los caracteres ',' y '.' como separadores decimales.
        /// </summary>
        /// <param name="str">La cadena que se desea evaluar.</param>
        /// <returns>
        /// <c>true</c> si la cadena contiene únicamente dígitos y opcionalmente
        /// los caracteres ',' o '.'; en caso contrario, <c>false</c>.
        /// Si la cadena es nula o vacía, devuelve <c>false</c>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// string texto1 = "123.45";
        /// string texto2 = "123,45";
        /// string texto3 = "12a45";
        /// string texto4 = "";
        /// string texto5 = null;
        ///
        /// bool resultado1 = texto1.IsDecimal(); // true
        /// bool resultado2 = texto2.IsDecimal(); // true
        /// bool resultado3 = texto3.IsDecimal(); // false
        /// bool resultado4 = texto4.IsDecimal(); // false
        /// bool resultado5 = texto5.IsDecimal(); // false
        ///
        /// Console.WriteLine($"Texto1: {resultado1}, Texto2: {resultado2}, Texto3: {resultado3}, Texto4: {resultado4}, Texto5: {resultado5}");
        /// </code>
        /// </example>
        public static bool IsDecimal(this string str)
        {
            if (str.IsMissingValue())
            {
                return false;
            }

            List<char> charsToexclude = new List<char> { ',', '.' };
            if (str.HasValue())
            {
                var arr = str.ToArray();
                var chars = arr.Where(w => !char.IsDigit(w) && !charsToexclude.Contains(w));

                return !chars.Any();

            }
            return true;
        }

        /// <summary>
        /// Limita la longitud de una cadena a un máximo especificado.
        /// Si la cadena es más corta o igual al máximo, se devuelve completa.
        /// Si es más larga, se devuelve truncada.
        /// </summary>
        /// <param name="value">La cadena que se desea truncar.</param>
        /// <param name="maxLength">La longitud máxima permitida.</param>
        /// <returns>
        /// La cadena original si su longitud es menor o igual a <paramref name="maxLength"/>; 
        /// en caso contrario, una subcadena de longitud máxima.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// string texto1 = "Hola Mundo";
        /// string texto2 = "Este texto es demasiado largo";
        ///
        /// string resultado1 = texto1.Truncate(20); // "Hola Mundo"
        /// string resultado2 = texto2.Truncate(10); // "Este texto"
        ///
        /// Console.WriteLine($"Resultado1: {resultado1}");
        /// Console.WriteLine($"Resultado2: {resultado2}");
        /// </code>
        /// </example>
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        /// <summary>
        /// Elimina todos los espacios y caracteres de espacio en blanco de una cadena,
        /// devolviendo el resultado sin espacios.
        /// </summary>
        /// <param name="str">La cadena de entrada que se desea limpiar.</param>
        /// <returns>
        /// Una nueva cadena sin espacios ni caracteres de espacio en blanco.
        /// Si la cadena es nula, devuelve <c>null</c>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// string texto1 = "Hola Mundo";
        /// string texto2 = " 123 \t 456 ";
        /// string texto3 = null;
        ///
        /// string resultado1 = texto1.RemoveSpaceEmpty(); // "HolaMundo"
        /// string resultado2 = texto2.RemoveSpaceEmpty(); // "123456"
        /// string resultado3 = texto3.RemoveSpaceEmpty(); // null
        ///
        /// Console.WriteLine($"Resultado1: '{resultado1}'");
        /// Console.WriteLine($"Resultado2: '{resultado2}'");
        /// Console.WriteLine($"Resultado3: '{resultado3}'");
        /// </code>
        /// </example>
        public static string RemoveSpaceEmpty(this string? str)
        {
            return str == null
                ? string.Empty
                : Regex.Replace(str, @"\s", "").Trim();
        }

        /// <summary>
        /// Extensión para cadenas que permite insertar parámetros dinámicos
        /// usando <see cref="string.Format(string, object[])"/>.
        /// </summary>
        /// <param name="str">
        /// Cadena base que contiene placeholders (ej: "Hola {0}, tienes {1} mensajes").
        /// </param>
        /// <param name="parameters">
        /// Arreglo de objetos que reemplazarán los placeholders en la cadena.
        /// </param>
        /// <returns>
        /// Una nueva cadena con los parámetros reemplazados.
        /// </returns>
        /// <example>
        /// Ejemplo 1:
        /// string saludo = "Hola {0}".AddStringParameters(new object[] { "Alexander" });
        /// // Resultado: "Hola Alexander"
        ///
        /// Ejemplo 2:
        /// string info = "El producto {0} cuesta {1:C}".AddStringParameters(new object[] { "Laptop", 1200 });
        /// // Resultado: "El producto Laptop cuesta $1,200.00"
        ///
        /// Ejemplo 3:
        /// string fecha = "Hoy es {0:dddd}, {0:dd/MM/yyyy}".AddStringParameters(new object[] { DateTime.Now });
        /// // Resultado: "Hoy es jueves, 02/04/2026"
        /// </example>
        public static string AddStringParameters(this string str, object[] parameters)
        {
            return string.Format(str, parameters);
        }

        /// <summary>
        /// Extensión para ordenar alfabéticamente los elementos de una cadena
        /// separados por un delimitador específico.
        /// </summary>
        /// <param name="strUnordered">
        /// Cadena original que contiene elementos separados por el delimitador.
        /// Ejemplo: "perro,gato,ave".
        /// </param>
        /// <param name="parameters">
        /// Carácter delimitador que separa los elementos.
        /// Ejemplo: ',' o ';'.
        /// </param>
        /// <returns>
        /// Una nueva cadena con los elementos ordenados alfabéticamente.
        /// Si la cadena está vacía o no contiene el delimitador, se devuelve la original.
        /// </returns>
        /// <example>
        /// Ejemplo 1:
        /// string animales = "perro,gato,ave".OrderStringAscBySeparator(',');
        /// // Resultado: "ave,gato,perro"
        ///
        /// Ejemplo 2:
        /// string frutas = "Mango;manzana;Banana".OrderStringAscBySeparator(';');
        /// // Resultado: "Banana;Mango;manzana"
        ///
        /// Ejemplo 3:
        /// string unico = "ElementoUnico".OrderStringAscBySeparator(',');
        /// // Resultado: "ElementoUnico"
        /// </example>
        public static string OrderStringAscBySeparator(this string strUnordered, char parameters)
        {
            if (!strUnordered.HasItems())
            {
                return string.Empty;
            }

            if (parameters.IsNull())
            {
                return string.Empty;
            }

            var arrayOfComponents = strUnordered.Split(parameters);


            if (arrayOfComponents.First() == strUnordered)
            {
                return strUnordered;
            }

            var elementsOfArray = arrayOfComponents.Count();

            if (elementsOfArray > 1)
            {
                var orderedListOfComponents = arrayOfComponents.OrderBy(e => e.ToUpper());
                var stringOrdered = string.Join(parameters.ToString(), orderedListOfComponents);

                return stringOrdered;
            }

            return strUnordered;
        }
    }
}
````

## File: EstructuraBaseDatos.txt
````
-- Crear esquemas
CREATE SCHEMA Comunes;
CREATE SCHEMA Seguridad;

-- Crear tabla LogTransacciones
CREATE TABLE [Comunes].[LogTransacciones](
    [TransaccionUId] [uniqueidentifier] NOT NULL,
    [TipoTransaccion] [varchar](50) NOT NULL,
    [FechaTransaccion] [datetime] NOT NULL,
    [ModificadoPor] [varchar](25) NOT NULL,
    [OrigenTransaccion] [varchar](50) NOT NULL
) ON [PRIMARY];

-- Crear tabla LogTransaccionesDetalle
CREATE TABLE [Comunes].[LogTransaccionesDetalle](
    [TransaccionUId] [uniqueidentifier] NOT NULL,
    [TipoTransaccion] [varchar](50) NOT NULL,
    [EntidadDominio] [varchar](50) NOT NULL,
    [DescripcionTransaccion] [varchar](50) NOT NULL
) ON [PRIMARY];

-- Crear tabla Pantalla
CREATE TABLE [Seguridad].[Pantalla](
    [PantallaId] [varchar](50) NOT NULL,
    [Descripcion] [varchar](100) NOT NULL,
    [FechaTransaccion] [datetime] NOT NULL,
    [DescripcionTransaccion] [varchar](50) NOT NULL,
    [ModificadoPor] [varchar](20) NOT NULL,
    [RowVersion] [timestamp] NOT NULL,
    [TipoTransaccion] [varchar](50) NOT NULL,
    [TransaccionUId] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_Pantalla] PRIMARY KEY CLUSTERED 
    (
        [PantallaId] ASC
    ) ON [PRIMARY]
) ON [PRIMARY];

-- Crear tabla Pantalla_transacciones
CREATE TABLE [Seguridad].[Pantalla_transacciones](
    [Uid] [int] IDENTITY(1,1) NOT NULL,
    [PantallaId] [varchar](50) NOT NULL,
    [Descripcion] [varchar](100) NOT NULL,
    [FechaTransaccion] [datetime] NOT NULL,
    [DescripcionTransaccion] [varchar](50) NOT NULL,
    [ModificadoPor] [varchar](20) NOT NULL,
    [RowVersion] [timestamp] NOT NULL,
    [TipoTransaccion] [varchar](50) NOT NULL,
    [TransaccionUId] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_Pantalla_transacciones] PRIMARY KEY CLUSTERED 
    (
        [Uid] ASC
    ) ON [PRIMARY]
) ON [PRIMARY];

-- Crear tabla Permisos
CREATE TABLE [Seguridad].[Permisos](
    [RolId] [varchar](25) NOT NULL,
    [PantallaId] [varchar](50) NOT NULL,
    [Ver] [bit] NOT NULL,
    [Editar] [bit] NOT NULL,
    [Eliminar] [bit] NOT NULL,
    [FechaTransaccion] [datetime] NOT NULL,
    [DescripcionTransaccion] [varchar](50) NOT NULL,
    [ModificadoPor] [varchar](20) NOT NULL,
    [TipoTransaccion] [varchar](50) NOT NULL,
    [TransaccionUId] [uniqueidentifier] NOT NULL,
    [RowVersion] [timestamp] NOT NULL,
    CONSTRAINT [PK_Permisos] PRIMARY KEY CLUSTERED 
    (
        [RolId] ASC,
        [PantallaId] ASC
    ) ON [PRIMARY]
) ON [PRIMARY];

-- Crear tabla Permisos_Transacciones
CREATE TABLE [Seguridad].[Permisos_Transacciones](
    [Uid] [int] IDENTITY(1,1) NOT NULL,
    [RolId] [varchar](25) NOT NULL,
    [PantallaId] [varchar](50) NOT NULL,
    [Ver] [bit] NOT NULL,
    [Editar] [bit] NOT NULL,
    [Eliminar] [bit] NOT NULL,
    [FechaTransaccion] [datetime] NOT NULL,
    [DescripcionTransaccion] [varchar](50) NOT NULL,
    [ModificadoPor] [varchar](20) NOT NULL,
    [TipoTransaccion] [varchar](50) NOT NULL,
    [TransaccionUId] [uniqueidentifier] NOT NULL,
    [RowVersion] [timestamp] NOT NULL,
    CONSTRAINT [PK_Permisos_Transacciones] PRIMARY KEY CLUSTERED 
    (
        [Uid] ASC
    ) ON [PRIMARY]
) ON [PRIMARY];

-- Crear tabla Rol
CREATE TABLE [Seguridad].[Rol](
    [RolId] [varchar](25) NOT NULL,
    [Descripcion] [varchar](25) NOT NULL,
    [FechaTransaccion] [datetime] NOT NULL,
    [DescripcionTransaccion] [varchar](50) NOT NULL,
    [ModificadoPor] [varchar](20) NOT NULL,
    [RowVersion] [timestamp] NOT NULL,
    [TipoTransaccion] [varchar](50) NOT NULL,
    [TransaccionUId] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
    (
        [RolId] ASC
    ) ON [PRIMARY]
) ON [PRIMARY];

-- Crear tabla Rol_Transacciones
CREATE TABLE [Seguridad].[Rol_Transacciones](
    [Uid] [int] IDENTITY(1,1) NOT NULL,
    [RolId] [varchar](25) NOT NULL,
    [Descripcion] [varchar](25) NOT NULL,
    [FechaTransaccion] [datetime] NOT NULL,
    [DescripcionTransaccion] [varchar](50) NOT NULL,
    [ModificadoPor] [varchar](20) NOT NULL,
    [RowVersion] [timestamp] NOT NULL,
    [TipoTransaccion] [varchar](50) NOT NULL,
    [TransaccionUId] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_Rol_Transacciones] PRIMARY KEY CLUSTERED 
    (
        [Uid] ASC
    ) ON [PRIMARY]
) ON [PRIMARY];

-- Crear tabla Usuario
CREATE TABLE [Seguridad].[Usuario](
    [UsuarioId] [varchar](25) NOT NULL,
    [Nombre] [varchar](50) NOT NULL,
    [Apellido] [varchar](50) NOT NULL,
    [Contrasena] [varchar](250) NOT NULL,
    [RolId] [varchar](25) NOT NULL,
    [Activo] [bit] NOT NULL,
    [FechaTransaccion] [datetime] NOT NULL,
    [DescripcionTransaccion] [varchar](50) NOT NULL,
    [ModificadoPor] [varchar](20) NOT NULL,
    [RowVersion] [timestamp] NOT NULL,
    [TipoTransaccion] [varchar](50) NOT NULL,
    [TransaccionUId] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
    (
        [UsuarioId] ASC
    ) ON [PRIMARY]
) ON [PRIMARY];

-- Establecer valor por defecto para el campo Activo
ALTER TABLE [Seguridad].[Usuario] ADD CONSTRAINT [DF_Usuario_Activo] DEFAULT ((1)) FOR [Activo];

-- Crear tabla Usuario_Transacciones
CREATE TABLE [Seguridad].[Usuario_Transacciones](
    [Uid] [int] IDENTITY(1,1) NOT NULL,
    [UsuarioId] [varchar](25) NOT NULL,
    [Nombre] [varchar](50) NOT NULL,
    [Apellido] [varchar](50) NOT NULL,
    [Contrasena] [varchar](250) NOT NULL,
    [RolId] [varchar](25) NOT NULL,
    [Activo] [bit] NOT NULL,
    [FechaTransaccion] [datetime] NOT NULL,
    [DescripcionTransaccion] [varchar](50) NOT NULL,
    [ModificadoPor] [varchar](20) NOT NULL,
    [RowVersion] [timestamp] NOT NULL,
    [TipoTransaccion] [varchar](50) NOT NULL,
    [TransaccionUId] [uniqueidentifier] NOT NULL
) ON [PRIMARY];

CREATE TABLE [Comunes].[Configuraciones](
	[ConfiguracionId] [varchar](150) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[FechaTransaccion] [datetime] NOT NULL,
	[DescripcionTransaccion] [varchar](50) NOT NULL,
	[ModificadoPor] [varchar](20) NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[TipoTransaccion] [varchar](50) NOT NULL,
	[TransaccionUId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Configuraciones] PRIMARY KEY CLUSTERED 
(
	[ConfiguracionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [Comunes].[Configuraciones_Transacciones](
	[Uid] [int] IDENTITY(1,1) NOT NULL,
	[ConfiguracionId] [varchar](150) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[FechaTransaccion] [datetime] NOT NULL,
	[DescripcionTransaccion] [varchar](50) NOT NULL,
	[ModificadoPor] [varchar](20) NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[TipoTransaccion] [varchar](50) NOT NULL,
	[TransaccionUId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Configuraciones_Transacciones] PRIMARY KEY CLUSTERED 
(
	[Uid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [Comunes].[ConfiguracionesDetalle](
	[ConfiguracionId] [varchar](150) NOT NULL,
	[Atributo] [varchar](150) NOT NULL,
	[Valor] [varchar](150) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[FechaTransaccion] [datetime] NOT NULL,
	[DescripcionTransaccion] [varchar](50) NOT NULL,
	[ModificadoPor] [varchar](20) NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[TipoTransaccion] [varchar](50) NOT NULL,
	[TransaccionUId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_ConfiguracionesDetalle] PRIMARY KEY CLUSTERED 
(
	[ConfiguracionId] ASC,
	[Atributo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [Comunes].[ConfiguracionesDetalle_Transacciones](
	[Uid] [int] IDENTITY(1,1) NOT NULL,
	[ConfiguracionId] [varchar](150) NOT NULL,
	[Atributo] [varchar](150) NOT NULL,
	[Valor] [varchar](150) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[FechaTransaccion] [datetime] NOT NULL,
	[DescripcionTransaccion] [varchar](50) NOT NULL,
	[ModificadoPor] [varchar](20) NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[TipoTransaccion] [varchar](50) NOT NULL,
	[TransaccionUId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_ConfiguracionesDetalle_Transacciones] PRIMARY KEY CLUSTERED 
(
	[Uid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
````

## File: Infraestructura/Context/DataSeeder.cs
````csharp
using Dominio.Context.Entidades;
using Dominio.Context.Entidades.Seguridad;

namespace Infraestructura.Context
{
    public static class DataSeeder
    {
        public static void Seed(MyContext context, string? adminPassword = null)
        {
            var ahora = DateTime.Now;
            var modificadoPor = "System";
            var transaccionUId = Guid.NewGuid();
            var tipoTransaccion = "cargaInicial";
            var descripcionTransaccion = "Added";
            // Verifica si ya existen registros
            if (!context.Rol.Any())
            {
                context.Rol.AddRange(
                    new Rol 
                    { 
                        RolId = "Admin", 
                        Descripcion = "Administrador del sistema", 
                        DescripcionTransaccion = descripcionTransaccion, 
                        FechaTransaccion = ahora, 
                        ModificadoPor = modificadoPor,
                        TransaccionUId = transaccionUId,
                        TipoTransaccion = tipoTransaccion
                    },
                    new Rol 
                    { 
                        RolId = "User", 
                        Descripcion = "Usuario estándar", 
                        DescripcionTransaccion = descripcionTransaccion, 
                        FechaTransaccion = ahora,
                        ModificadoPor = modificadoPor,
                        TipoTransaccion = tipoTransaccion,
                        TransaccionUId = transaccionUId
                    }
                );
            }

            if (!context.Usuarios.Any() && !string.IsNullOrWhiteSpace(adminPassword))
            {
                context.Usuarios.Add(
                    new Usuario 
                    {
                        UsuarioId = "admin", 
                        Nombre = "Administrador", 
                        Apellido = "Sistema",
                        Contrasena = PasswordEncryptor.HashPassword(adminPassword), 
                        RolId = "Admin",
                        Activo = true,
                        DescripcionTransaccion = descripcionTransaccion, 
                        FechaTransaccion = ahora, 
                        ModificadoPor = modificadoPor,
                        TransaccionUId = transaccionUId,
                        TipoTransaccion = tipoTransaccion,
                    });
            }

            if (!context.Pantalla.Any())
            {   
                context.Pantalla.AddRange(
                    new Pantalla
                    {
                        PantallaId = "Seguridad",
                        Descripcion = "Administracion de la seguridad",
                        DescripcionTransaccion = descripcionTransaccion,
                        FechaTransaccion = ahora,
                        ModificadoPor = modificadoPor,
                        TransaccionUId = transaccionUId,
                        TipoTransaccion = tipoTransaccion,
                        
                    });
            }

            if (!context.Permisos.Any())
            {
                context.Permisos.AddRange(
                    new Permisos
                    {
                        RolId = "Admin",
                        PantallaId = "Seguridad",
                        DescripcionTransaccion = descripcionTransaccion,
                        FechaTransaccion = ahora,
                        ModificadoPor = modificadoPor,
                        Editar = true,
                        Eliminar = true,
                        Ver = true,
                        TransaccionUId = transaccionUId,
                        TipoTransaccion = tipoTransaccion,
                    }
                );
            }
            // Guarda los cambios
            context.SaveChanges();
        }
    }
}
````

## File: Infraestructura/Context/GenericRepository.cs
````csharp
using Dominio.Core;
using Dominio.Core.Extensions;
using Infraestructura.Core;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Text.RegularExpressions;


namespace Infraestructura.Context
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : IQueryableUnitOfWork
    {
        private readonly T _unitOfWork;
        private readonly IConfiguration _configuration;
        private static readonly Regex SqlIdentifierRegex = new(@"^[A-Za-z_][A-Za-z0-9_]*(\.[A-Za-z_][A-Za-z0-9_]*)?$", RegexOptions.Compiled);
        private static readonly Regex SqlParameterNameRegex = new(@"^@[A-Za-z_][A-Za-z0-9_]*$", RegexOptions.Compiled);
        private static readonly string[] UnsafeSqlTokens = [";", "--", "/*", "*/"];
        public GenericRepository(T unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }


        private DbSet<TEntity> GetSet<TEntity>() where TEntity : class
        {
            return _unitOfWork.CreateSet<TEntity>();
        }

        public IUnitOfWork UnitOfWork
        { 
            get { return _unitOfWork; } 
        }

        /// <inheritdoc/>
        public void Add<TEntity>(TEntity entity) where TEntity : Entity
        {
            if (entity.IsNotNull())
            {
                entity.FechaTransaccion = DateTime.Now;
                entity.DescripcionTransaccion = "Insert";
                entity.RowVersion = Array.Empty<Byte>();
                GetSet<TEntity>().Add(entity); //Add new item in this set
            }
        }

        /// <inheritdoc/>
        public async Task AddAsync<TEntity>(TEntity entity) where TEntity : Entity
        {
            if (entity.IsNotNull())
            {
                entity.FechaTransaccion = DateTime.Now;
                entity.DescripcionTransaccion = "Insert";
                entity.RowVersion = Array.Empty<Byte>();
                await GetSet<TEntity>().AddAsync(entity); //Add new item in this set
            }
        }

        /// <inheritdoc/>
        public void AddRange<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : Entity
        {
            if (entities.HasItems())
            {
                GetSet<TEntity>().AddRange(entities);
            }
        }

        /// <inheritdoc/>
        public async Task AddRangeAsync<TEntity>(IEnumerable<TEntity> entities) 
            where TEntity : Entity
        {
            if (entities.HasItems())
            {
                await GetSet<TEntity>().AddRangeAsync(entities);
            }
        }

        public void Dispose()
        {
            if (_unitOfWork.IsNotNull())
            {
                _unitOfWork.Dispose();
            }
        }

        /// <inheritdoc/>
        public IEnumerable<TEntity> GetAll<TEntity>() 
            where TEntity : Entity
        {
            return GetSet<TEntity>().ToList();
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<TEntity>> GetAllAsync<TEntity>()
            where TEntity : Entity
        {
            return await GetSet<TEntity>().ToListAsync();
        }
        
        /// <inheritdoc/>
        public IEnumerable<TEntity> GetAll<TEntity>(List<string> includes) 
            where TEntity : Entity
        {
            IQueryable<TEntity> items = GetSet<TEntity>();

            if (includes.HasItems())
            {
                //Adding Includes to filter.
                items = includes.Aggregate(items, (current, include) => current.Include(include));
            }

            return items.ToList();
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<TEntity>> GetAllAsync<TEntity>(List<string> includes)
            where TEntity : Entity
        {
            IQueryable<TEntity> items = GetSet<TEntity>();

            if (includes.HasItems())
            {
                //Adding Includes to filter.
                items = includes.Aggregate(items, (current, include) => current.Include(include));
            }

            return await items.ToListAsync();
        }

        /// <inheritdoc/>
        public TEntity GetSingle<TEntity>(Expression<Func<TEntity, bool>> predicate) 
            where TEntity : Entity
        {
            return GetSet<TEntity>().FirstOrDefault(predicate);
        }

        /// <inheritdoc/>
        public async Task<TEntity> GetSingleAsync<TEntity>(Expression<Func<TEntity, bool>> predicate) 
            where TEntity : Entity
        {
            return await GetSet<TEntity>().FirstOrDefaultAsync(predicate);
        }


        /// <inheritdoc/>
        public TEntity GetSingle<TEntity>(Expression<Func<TEntity, bool>> predicate, List<string> includes)
            where TEntity : Entity
        {
            IQueryable<TEntity> items = GetSet<TEntity>();

            if (includes.HasItems())
            {
                //Adding include to the filter.
                items = includes.Aggregate(items, (current, include) => current.Include(include));
            }

            return items.FirstOrDefault(predicate);
        }

        /// <inheritdoc/>
        public async Task<TEntity> GetSingleAsync<TEntity>(Expression<Func<TEntity, bool>> predicate, List<string> includes)
            where TEntity : Entity
        {
            IQueryable<TEntity> items = GetSet<TEntity>();

            if (includes.HasItems())
            {
                //Adding include to the filter.
                items = includes.Aggregate(items, (current, include) => current.Include(include));
            }

            return await items.FirstOrDefaultAsync(predicate);
        }

        /// <inheritdoc/>
        public IEnumerable<TEntity> GetFiltered<TEntity>(Expression<Func<TEntity, bool>> predicate)
            where TEntity : Entity
        {
            return GetSet<TEntity>().Where(predicate).ToList();
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<TEntity>> GetFilteredAsync<TEntity>(Expression<Func<TEntity, bool>> predicate)
            where TEntity : Entity
        {
            return await GetSet<TEntity>().Where(predicate).ToListAsync();
        }

        /// <inheritdoc/>
        public IEnumerable<TEntity> GetFiltered<TEntity>(Expression<Func<TEntity, bool>> predicate, List<string> includes)
            where TEntity : Entity
        {
            IQueryable<TEntity> items = GetSet<TEntity>();
            if (includes.HasItems())
            {
                //Adding includes to filter
                items = includes.Aggregate(items, (current, include) => current.Include(include));
            }

            return items.Where(predicate).ToList();
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<TEntity>> GetFilteredAsync<TEntity>(Expression<Func<TEntity, bool>> predicate, List<string> includes)
            where TEntity : Entity
        {
            IQueryable<TEntity> items = GetSet<TEntity>();
            if (includes.HasItems())
            {
                //Adding includes to filter
                items = includes.Aggregate(items, (current, include) => current.Include(include));
            }

            return await items.Where(predicate).ToListAsync();
        }

        public PagedCollection GetPagedAndFiltered<TEntity>(DynamicFilter filterDef)
            where TEntity : Entity
        {
            IQueryable<TEntity> items = !string.IsNullOrWhiteSpace(filterDef.Filtro)
                                            ? GetSet<TEntity>().Where(filterDef.Filtro, filterDef.Valores)
                                            : GetSet<TEntity>();

            if (filterDef.Includes.HasItems())
            {
                //Adding Includes to the filter
                items = filterDef.Includes.Aggregate(items, (current, include) => current.Include(include));
            }

            int totalItems = items.Count();

            if (filterDef.PageSize != 0)
            {
                //Adding sort criteria.
                if (filterDef.SortFields.HasItems())
                {
                    string orderKey = filterDef.Ascending ? "ASC" : "DESC";

                    var order = string.Join(" " + orderKey + ", ", filterDef.SortFields.ToArray());

                    if (!order.EndsWith(orderKey))
                    {
                        order += " " + orderKey;
                    }

                    items = items.OrderBy(order);

                    items = items.Skip(filterDef.PageSize * filterDef.PageIndex);
                }

                items = items.Take(filterDef.PageSize);
            }

            var pagedItems = items.ToList();

            return new PagedCollection(filterDef.PageIndex, filterDef.PageSize, pagedItems, totalItems, pagedItems.Count());
        }

        public async Task<PagedCollection> GetPagedAndFilteredAsync<TEntity>(DynamicFilter filterDef)
            where TEntity : Entity
        {
            IQueryable<TEntity> items = !string.IsNullOrWhiteSpace(filterDef.Filtro)
                                            ? GetSet<TEntity>().Where(filterDef.Filtro, filterDef.Valores)
                                            : GetSet<TEntity>();

            if (filterDef.Includes.HasItems())
            {
                //Adding Includes to the filter
                items = filterDef.Includes.Aggregate(items, (current, include) => current.Include(include));
            }

            int totalItems = items.Count();

            if (filterDef.PageSize != 0)
            {
                //Adding sort criteria.
                if (filterDef.SortFields.HasItems())
                {
                    string orderKey = filterDef.Ascending ? "ASC" : "DESC";

                    var order = string.Join(" " + orderKey + ", ", filterDef.SortFields.ToArray());

                    if (!order.EndsWith(orderKey))
                    {
                        order += " " + orderKey;
                    }

                    items = items.OrderBy(order);

                    items = items.Skip(filterDef.PageSize * filterDef.PageIndex);
                }

                items = items.Take(filterDef.PageSize);
            }

            var pagedItems = await items.ToListAsync();

            return new PagedCollection(filterDef.PageIndex, filterDef.PageSize, pagedItems, totalItems, pagedItems.Count());
        }

        /// <inheritdoc/>
        public void Remove<TEntity>(TEntity entity)
            where TEntity : Entity
        {
            if (entity.IsNotNull())
            {
                //Attach item if not exist
                _unitOfWork.Attach(entity);

                //set as "Remove"
                GetSet<TEntity>().Remove(entity);
            }
        }

        /// <inheritdoc/>
        public void RemoveRange<TEntity>(IEnumerable<TEntity> entities) 
            where TEntity : Entity
        {
            if (entities.HasItems())
            {
                //set as removed
                GetSet<TEntity>().RemoveRange(entities);
            }
        }

        /// <inheritdoc/>
        public void Modify<TEntity>(TEntity item)
            where TEntity : Entity
        {
            if (item.IsNotNull())
            {
                _unitOfWork.SetModified(item);
            }
        }

        public IEnumerable<TType> ExecuteStoredProcedure<TType>(string storedProcedure, Dictionary<string, object> parameters)
        {
            ValidateSqlIdentifier(storedProcedure, nameof(storedProcedure));
            SqlParameter[] sqlParameters = CreateSqlParameters(parameters);
            string paramNames = GetParamNames(parameters);

            return (string.IsNullOrWhiteSpace(paramNames))
                ? _unitOfWork.ExecuteQuery<TType>(string.Format("EXEC {0}", storedProcedure), sqlParameters).ToList()
                : _unitOfWork.ExecuteQuery<TType>(string.Format("EXEC {0} {1}", storedProcedure, paramNames), sqlParameters).ToList();
        }

        public IEnumerable<TType> ExecuteStoredProcedure<TType>(string storedProcedure, SqlParameter[] parameters)
        {
            ValidateSqlIdentifier(storedProcedure, nameof(storedProcedure));
            string paramNames = GetParamNames(parameters);
            return _unitOfWork.ExecuteQuery<TType>(string.Format("EXEC {0} {1}", storedProcedure, paramNames), parameters).ToList();
        }

        public TType ExecuteScalarFunction<TType>(string scalarFunction, Dictionary<string, object> parameters)
        {
            ValidateSqlIdentifier(scalarFunction, nameof(scalarFunction));
            SqlParameter[] sqlParameters = CreateSqlParameters(parameters);
            string paramNames = GetParamNames(parameters);

            var result = (string.IsNullOrWhiteSpace(paramNames))
                ? _unitOfWork.ExecuteScalarFunction<TType>(string.Format("SELECT {0}();", scalarFunction), sqlParameters)
                : _unitOfWork.ExecuteScalarFunction<TType>(string.Format("SELECT {0}({1});", scalarFunction, paramNames), sqlParameters);

            return result;
        }

        private string GetParamNames(Dictionary<string, object> parameters)
        {
            ValidateSqlParameterNames(parameters?.Keys);
            return (parameters != null && parameters.Any())
                ? parameters.Select(p => p.Key).Aggregate((i, j) => i + ", " + j)
                : string.Empty;
        }

        private string GetParamNames(SqlParameter[] parameters)
        {
            ValidateSqlParameterNames(parameters?.Select(p => p.ParameterName));
            return (parameters != null && parameters.Any())
                ? parameters.Select(p => p.ParameterName).Aggregate((i, j) => i + ", " + j)
                : string.Empty;
        }

        public void ExecuteQuery(string sqlQuery, Dictionary<string, object> parameters)
        {
            ValidateSqlCommand(sqlQuery);
            SqlParameter[] sqlParameters = CreateSqlParameters(parameters);
            _unitOfWork.ExecuteCommand(sqlQuery, sqlParameters);
        }

        private SqlParameter[] CreateSqlParameters(Dictionary<string, object> parameters)
        {
            if (parameters != null && parameters.Any())
            {
                ValidateSqlParameterNames(parameters.Keys);
                return (from qry in parameters select new SqlParameter(qry.Key, qry.Value)).ToArray();
            }

            return new SqlParameter[0];
        }

        public void ExecuteQuery(SqlParameter[] parms, string sqlQuery)
        {
            ValidateSqlCommand(sqlQuery);
            ValidateSqlParameterNames(parms?.Select(p => p.ParameterName));
            _unitOfWork.ExecuteCommand(sqlQuery, parms);
        }

        public async Task<bool> IsRunningJobsAsync(string jobName)
        {
            if (string.IsNullOrWhiteSpace(jobName))
            {
                return false;
            }

            string connectionString = _configuration.GetConnectionString("conectionDataBase")
                ?? throw new InvalidOperationException("Connection string 'conectionDataBase' not found in configuration.");
            bool result = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string query = "SELECT COUNT(*) FROM msdb.dbo.sysjobs j " +
                        "INNER JOIN msdb.dbo.sysjobactivity a " +
                        "  ON j.job_id = a.job_id " +
                        "WHERE j.name = @jobName AND a.run_requested_date IS NOT NULL AND a.stop_execution_date IS NULL";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@jobName", jobName));
                        int runningJobCount = (int)(await command.ExecuteScalarAsync() ?? 0);

                        if (runningJobCount > 0)
                        {
                            result = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: { ex.Message }");
            }

            return result;
        }

        public IEnumerable<TEntity> ExecuteQuery<TEntity>(SqlParameter[] parms, string sqlQuery)
        {
            ValidateSqlCommand(sqlQuery);
            ValidateSqlParameterNames(parms?.Select(p => p.ParameterName));
            return _unitOfWork.ExecuteQuery<TEntity>(sqlQuery, parms).ToList();
        }

        private static void ValidateSqlIdentifier(string identifier, string argumentName)
        {
            if (string.IsNullOrWhiteSpace(identifier) || !SqlIdentifierRegex.IsMatch(identifier))
            {
                throw new ArgumentException("Only simple schema-qualified SQL identifiers are allowed.", argumentName);
            }
        }

        private static void ValidateSqlParameterNames(IEnumerable<string>? parameterNames)
        {
            if (parameterNames == null) return;

            foreach (var parameterName in parameterNames)
            {
                if (string.IsNullOrWhiteSpace(parameterName) || !SqlParameterNameRegex.IsMatch(parameterName))
                {
                    throw new ArgumentException("SQL parameter names must start with @ and contain only letters, numbers, or underscores.");
                }
            }
        }

        private static void ValidateSqlCommand(string sqlQuery)
        {
            if (string.IsNullOrWhiteSpace(sqlQuery))
            {
                throw new ArgumentException("SQL query cannot be empty.", nameof(sqlQuery));
            }

            if (UnsafeSqlTokens.Any(token => sqlQuery.Contains(token, StringComparison.Ordinal)))
            {
                throw new ArgumentException("SQL query contains unsupported multi-statement or comment syntax.", nameof(sqlQuery));
            }
        }
    }
}
````

## File: Infraestructura/Context/MyContext.cs
````csharp
using Dominio.Context.Entidades.ConfiguracionesAgg;
using Dominio.Context.Entidades.Seguridad;
using Dominio.Core;
using Infraestructura.Context.Mapping.ConfiguracionesMap;
using Infraestructura.Context.Mapping.Seguridad;
using Infraestructura.Core;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Context
{
    public class MyContext : BCUnitOfWork, IDataContext
    {
        public MyContext(DbContextOptions<MyContext> context)
            : base(context)
        {
            Database.SetCommandTimeout((int)TimeSpan.FromSeconds(1).TotalSeconds);
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Rol> Rol {  get; set; }
        public virtual DbSet<Pantalla> Pantalla { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<Configuraciones> Configuraciones { get; set; }
        public virtual DbSet<ConfiguracionesDetalle> ConfiguracionesDetalle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new RolMap());
            modelBuilder.ApplyConfiguration(new PantallaMap());
            modelBuilder.ApplyConfiguration(new PermisosMap());
            modelBuilder.ApplyConfiguration(new ConfiguracionesMap());
            modelBuilder.ApplyConfiguration(new ConfiguracionesDetalleMap());
            base.OnModelCreating(modelBuilder);
        }


        public override void Commit(TransactionInfo transactionInfo)
        {
            base.Commit(transactionInfo);
        }
    }
}
````

## File: Infraestructura/Core/BCUnitOfWork.cs
````csharp
using Dominio.Core;
using Infraestructura.Context;
using Infraestructura.Core.Identity;
using Infraestructura.Core.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;

namespace Infraestructura.Core
{
    public class BCUnitOfWork : DbContext
    {
        private string Transact { get; set; }
        public BCUnitOfWork(DbContextOptions<MyContext>? context)
            : base(context)
        {
            Database.SetCommandTimeout((int)TimeSpan.FromSeconds(1).TotalSeconds);
        }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        public virtual void Commit(TransactionInfo? transactionInfo)
        {
            Logging.Transaction transaction = BuildTransactionInfo(transactionInfo);
            Commit(transaction, transactionInfo.GenerateTransaction);
        }

        private void Commit(Logging.Transaction transaction, bool generateTransaction)
        {
            try
            {
                base.Database.OpenConnection();
                //Reseteando el detalle de las transacciones.
                transaction.TransactionDetail = [];

                using (var scope = TransactionScopeFactory.GetTransactionScope())
                {
                    var changedEntities = new List<ModifiedEntityEntry>();
                    var tableMapping = new List<EntityMapping>();
                    var sqlCommandInfos = new List<SqlCommandInfo>();

                    IEnumerable<EntityEntry> changeDbEntityEntries = GetChangedDbEntityEntries();

                    foreach (EntityEntry entry in changeDbEntityEntries)
                    {
                        ApplyTransactionInfo(transaction, entry);

                        if (!generateTransaction)
                        {
                            // Get the deleted records info first
                            if (entry.State == EntityState.Deleted)
                            {
                                EntityMapping entityMapping = GetEntityMappingConfiguration(tableMapping, entry);
                                SqlCommandInfo sqlCommandInfo = GetSqlCommandInfo(transaction, entry, entityMapping);
                                if (sqlCommandInfo != null) sqlCommandInfos.Add(sqlCommandInfo);

                                transaction.AddDetail(entityMapping.TableName, entry.State.ToString(), transaction.TransactionType);
                            }
                            else
                            {
                                changedEntities.Add(new ModifiedEntityEntry(entry, entry.State.ToString()));
                            }
                        }

                    }
                    base.SaveChanges();

                    if (!generateTransaction)
                    {
                        // Get the Added and Mdified records after changes, that way we will be able to get the generated .
                        foreach (ModifiedEntityEntry entry in changedEntities)
                        {
                            EntityMapping entityMapping = GetEntityMappingConfiguration(tableMapping, entry.EntityEntry);
                            SqlCommandInfo sqlCommandInfo = GetSqlCommandInfo(transaction, entry.EntityEntry, entityMapping);
                            if (sqlCommandInfo != null) sqlCommandInfos.Add(sqlCommandInfo);
                            
                            transaction.AddDetail(entityMapping.TableName, entry.State, transaction.TransactionType);
                        }

                        // Adding Audit Detail Transaction CommandInfo.
                        sqlCommandInfos.AddRange(GetAuditRecords(transaction));

                        // Insert Transaction and audit records.
                        foreach (SqlCommandInfo sqlCommandInfo in sqlCommandInfos)
                        {
                            Database.ExecuteSqlRaw(sqlCommandInfo.Sql, sqlCommandInfo.Parameters);
                        }

                    }

                    scope.Complete();
                }
            }
            finally
            {

                base.Database.CloseConnection();    
            }
        }

        private IEnumerable<SqlCommandInfo> GetAuditRecords(Logging.Transaction transaction)
        {
            var auditCommands = new List<SqlCommandInfo>
            {
                // Adding Audit Header Transaction CommandInfo.
                GetAuditHeaderCommandInfo(transaction)
            };

            // Adding Audit Detail Transaction CommandInfo
            foreach (var transactionDetail in transaction.TransactionDetail)
            {
                auditCommands.Add(GetAuditDetailCommandInfo(transactionDetail));
            }

            return auditCommands;
        }

        private SqlCommandInfo GetAuditDetailCommandInfo(TransactionDetail transactionDetail)
        {
            const string sqlInsert =
                "insert into  Comunes.LogTransaccionesDetalle(TransaccionUId,TipoTransaccion, EntidadDominio, DescripcionTransaccion) " +
                                       "values({0}, {1}, {2},{3})";

            var param = new object[]
                                 {
                                     transactionDetail.TransactionId,transactionDetail.TransactionType, transactionDetail.TableName, transactionDetail.CrudOperation
                                 };

            return new SqlCommandInfo(sqlInsert, param);
        }

        private SqlCommandInfo GetAuditHeaderCommandInfo(Logging.Transaction transaction)
        {
            const string sqlInsert =
                "insert into  Comunes.LogTransacciones(TransaccionUId, TipoTransaccion, FechaTransaccion, ModificadoPor, OrigenTransaccion) " +
                "values({0}, {1}, {2}, {3}, {4} )";

            var param = new object[]
                                 {
                                     transaction.TransactionId, transaction.TransactionType, transaction.TransactionDate,
                                     transaction.ModifiedBy, transaction.TransactionOrigen
                                 };

            return new SqlCommandInfo(sqlInsert, param);
        }

        private SqlCommandInfo GetSqlCommandInfo(Logging.Transaction transaction, EntityEntry entry, EntityMapping entityMapping)
        {
            if (entityMapping.TableName.Contains("_Transacciones"))
            {
                return null;
            }

            string sqlInsert;
            object[] param;
            CreateTransactionInsertStatement(entityMapping, entry, transaction, out sqlInsert, out param);

            var sqlCommandInfo = new SqlCommandInfo(sqlInsert, param);
            return sqlCommandInfo;
        }

        private void CreateTransactionInsertStatement(EntityMapping entityMapping, EntityEntry entry,
                                                      Logging.Transaction transaction, out string sqlInsert, out object[] objects)
        {
            var insert = new StringBuilder();
            var fields = new StringBuilder();
            var paramNames = new StringBuilder();
            List<object> values = [];

            insert.AppendLine(string.Format("Insert Into {0} ", entityMapping.TransactionTableName));

            int index = 0;
            IEnumerable<string> propertyNames = entry.State == EntityState.Deleted
                                                    ? GetPropertiesEntity(entry, entry.OriginalValues)
                                                    : GetPropertiesEntity(entry, entry.CurrentValues);

            foreach (string property in propertyNames)
            {
                string prop = property;
                if (prop != "RowVersion")
                {
                    if (fields.Length == 0)
                    {
                        fields.Append(string.Format(" ({0}", prop));
                        paramNames.Append(string.Format(" values ({0}{1}{2}", "{", index, "}"));
                    }
                    else
                    {
                        fields.Append(string.Format(", {0}", prop));
                        paramNames.Append(string.Format(", {0}{1}{2}", "{", index, "}"));
                    }

                    values.Add(GetEntityPropertyValue(entry, prop, transaction));
                    index++;
                }
            }

            fields.Append(string.Format(") "));
            paramNames.Append(string.Format(") "));

            insert.AppendLine(fields.ToString());
            insert.AppendLine(paramNames.ToString());

            sqlInsert = insert.ToString();
            objects = values.ToArray();
        }

        private object GetEntityPropertyValue(EntityEntry? entry, string? prop, Logging.Transaction? transaction)
        {
            object value;
            TryGeTransactionInfo(prop, transaction, out value);
            if (value != null)
            {
                return value;
            }

            if (entry.State == EntityState.Deleted || entry.State == EntityState.Detached)
            {
                return prop == "DescripcionTransaccion"
                           ? EntityState.Deleted.ToString()
                           : entry.Property(prop).OriginalValue;
            }
            return entry.Property(prop).CurrentValue;
        }

        private static void TryGeTransactionInfo(string property, Logging.Transaction transaction, out object value)
        {
            switch (property)
            {
                case "TransaccionUId":
                    value = transaction.TransactionId;
                    break;

                case "TipoTransaccion":
                    value = transaction.TransactionType;
                    break;

                case "FechaTransaccion":
                    value = transaction.TransactionDate;
                    break;

                case "ModificadoPor":
                    value = transaction.ModifiedBy;
                    break;

                default:
                    value = null;
                    break;
            }
        }

        private List<string> GetPropertiesEntity(EntityEntry? entry, PropertyValues? originalValues)
        {
            List<string> propertyNames = [];
            var entity = entry.Entity;
            var entityType =  entity.GetType();

            var properties = entry.OriginalValues.Properties;

            foreach (var prop in properties)
            {
                if (entityType.GetProperty(prop.Name) == null)
                    continue;
                var pp = entityType.GetProperty(prop.Name);
                if (pp.GetValue(entity) == null)
                    continue;
                propertyNames.Add(prop.Name);
            }

            return propertyNames;
        }

        private static EntityMapping GetEntityMappingConfiguration(List<EntityMapping> tableMapping, EntityEntry entry)
        {
            var type = GetDomainEntityType(entry);

            var name = entry.Metadata.GetTableName();
            var schema = entry.Metadata.GetSchema();

            var nameTable = string.Format("{0}.{1}", schema, name);

            EntityMapping entityMapping = tableMapping.FirstOrDefault(m => m.EntityType == type);
            if (entityMapping == null)
            {
                entityMapping = CreateTableMapping(type, nameTable);
                tableMapping.Add(entityMapping);
            }
            return entityMapping;
        }

        private static EntityMapping CreateTableMapping(Type type, string tname)
        {
            return new EntityMapping { EntityType = type, TableName = tname, TransactionTableName = GetTransactionTableName(tname) };
        }

        private static string GetTransactionTableName(string tname)
        {
            if (tname.Contains("_Transacciones"))
            {
                return tname;
            }


            string result = string.Format("{0}_Transacciones", tname);
            return result;
        }

        private static Type GetDomainEntityType(EntityEntry entry)
        {
            Type type = entry.Entity.GetType();
            if (type.FullName != null)
            {
                if (type.FullName.Contains("Dominio"))
                {
                    return type;
                }
                if (type.BaseType != null)
                {
                    return type.BaseType;
                }
            }

            return null;
        }

        private static void ApplyTransactionInfo(Logging.Transaction transaction, EntityEntry entry)
        {
            ((Entity)entry.Entity).FechaTransaccion = transaction.TransactionDate;
            ((Entity)entry.Entity).DescripcionTransaccion = entry.State.ToString();
            ((Entity)entry.Entity).ModificadoPor = transaction.ModifiedBy;

            AplicarInformacionTransaccion(entry, "TipoTransaccion", transaction.TransactionType);
            AplicarInformacionTransaccion(entry, "TransaccionUId", transaction.TransactionId);
        }

        private static void AplicarInformacionTransaccion(EntityEntry item, string nombrePropiedad, object valorPropiedad)
        {
            if (item != null && item.Entity != null)
            {
                PropertyInfo propInfoEntity = item.Entity.GetType().GetProperty(nombrePropiedad);
                if (propInfoEntity != null)
                {
                    propInfoEntity.SetValue(item.Entity, valorPropiedad, null);
                }
            }
        }

        private IEnumerable<EntityEntry> GetChangedDbEntityEntries()
        {
            return ChangeTracker.Entries().Where(
                e =>
                (e.Entity is Entity) &&
                (e.State == EntityState.Modified || e.State == EntityState.Added || e.State == EntityState.Deleted));
        }

        private static Logging.Transaction BuildTransactionInfo(TransactionInfo transactionInfo)
        {
            var transaccionId = NewSequentialTransactionIdentity();

            return new Logging.Transaction
            {
                TransactionId = transaccionId.TransactionId,
                TransactionDate = transaccionId.TransactionDate,
                TransactionOrigen = transactionInfo.TipoTransaccion,
                TransactionType = transactionInfo.TipoTransaccion,
                ModifiedBy = transactionInfo.ModificadoPor
            };
        }

        public static TransactionIdentity NewSequentialTransactionIdentity()
        {
            return new TransactionIdentity
            {
                TransactionId = NewSequentialGuid(),
                TransactionDate = DateTime.Now,
                TransactionUtcDate = DateTime.UtcNow
            };
        }

        public static Guid NewSequentialGuid()
        {
            byte[] uid = Guid.NewGuid().ToByteArray();
            byte[] binDate = BitConverter.GetBytes(DateTime.UtcNow.Ticks);

            var secuentialGuid = new byte[uid.Length];

            secuentialGuid[0] = uid[0];
            secuentialGuid[1] = uid[1];
            secuentialGuid[2] = uid[2];
            secuentialGuid[3] = uid[3];
            secuentialGuid[4] = uid[4];
            secuentialGuid[5] = uid[5];
            secuentialGuid[6] = uid[6];
            // set the first part of the 8th byte to '1100' so
            // later we'll be able to validate it was generated by us

            secuentialGuid[7] = (byte)(0xc0 | (0xf & uid[7]));

            // the last 8 bytes are sequential,
            // it minimizes index fragmentation
            // to a degree as long as there are not a large
            // number of Secuential-Guids generated per millisecond

            secuentialGuid[9] = binDate[0];
            secuentialGuid[8] = binDate[1];
            secuentialGuid[15] = binDate[2];
            secuentialGuid[14] = binDate[3];
            secuentialGuid[13] = binDate[4];
            secuentialGuid[12] = binDate[5];
            secuentialGuid[11] = binDate[6];
            secuentialGuid[10] = binDate[7];

            return new Guid(secuentialGuid);
        }

        public void RollbackChanges()
        {
            //Set all entities in change tracker
            //as 'unchanged state'
            ChangeTracker.Entries()
                .ToList().ForEach(e => e.State = EntityState.Unchanged);
        }

        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            return Database.ExecuteSqlRaw(sqlCommand, parameters);
        }

        public IEnumerable<TEntity> ExecuteQuery<TEntity>(string sqlCommand, params object[] parameters) 
        {
            //return Set<TEntity>().FromSqlRaw(sqlCommand, parameters).ToList();

            return Database.SqlQueryRaw<TEntity>(sqlCommand, parameters);
        }

        public TType ExecuteScalarFunction<TType>(string scalarFunction, params object[] parameters)
        {
            var returnValue = Database.SqlQueryRaw<TType>(scalarFunction, parameters);

            return returnValue.FirstOrDefault();
        }

        public async Task<IEnumerable<TEntity>> ExecuteQueryAsync<TEntity>(string sqlCommand, params object[] parameters) where TEntity: class
        {
            return await Set<TEntity>().FromSqlRaw(sqlCommand, parameters).ToListAsync();
        }

        public DbSet<TEntity> CreateSet<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }

        public void Attach<TEntity>(TEntity item) where TEntity : class
        {
            //Attach and set as unchanged
            Entry(item).State = EntityState.Unchanged;
        }

        public void SetModified<TEntity>(TEntity item) where TEntity : class
        {
            //This operation also attach item in object state manager
            Entry(item).State = EntityState.Modified;
        }

        public void ApplyCurrentValues<TEntity>(TEntity original, TEntity current) where TEntity : class
        {
            Entry(original).CurrentValues.SetValues(current);
        }
    }
}
````

## File: Infraestructura/Core/Jwtoken/JwtTokenService.cs
````csharp
using Dominio.Context.Entidades.Seguridad;
using Dominio.Core.Jwtoken;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infraestructura.Core.Jwtoken
{
    public class JwtTokenService : ITokenService
    {
        private readonly JwtSettings _jwtSettings;

        public JwtTokenService(IOptions<JwtSettings> options)
        {
            _jwtSettings = options.Value;
        }

        public string Generate(Usuario user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret));
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Nombre ?? string.Empty),
                new Claim(ClaimTypes.Email, user.UsuarioId ?? string.Empty),
                new Claim(ClaimTypes.NameIdentifier, user.UsuarioId ?? string.Empty)
            };
            // Add role claims if available
            if (!string.IsNullOrWhiteSpace(user.RolId))
            {
                claims.Add(new Claim(ClaimTypes.Role, user.RolId));
            }
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(_jwtSettings.ExpirationInMinutes),
                Issuer = _jwtSettings.Issuer,
                Audience = _jwtSettings.Audience,
                SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[64];
            using var rng = System.Security.Cryptography.RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }

        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = true,
                ValidAudience = _jwtSettings.Audience,
                ValidateIssuer = true,
                ValidIssuer = _jwtSettings.Issuer,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret)),
                ValidateLifetime = false,
                ClockSkew = TimeSpan.Zero
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
            if (securityToken is not JwtSecurityToken jwtSecurityToken || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");

            return principal;
        }
    }
}
````

## File: WebServices/Controllers/ConfiguracionesController.cs
````csharp
using Aplicacion.DTOs.ConfiguracionesDTO;
using Aplicacion.Services.ConfiguracionesApp;
using Dominio.Core.Result;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebServices.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ConfiguracionesController : ControllerBase
    {
        private readonly IConfiguracionesApplicationService _configuracionesAppService;

        public ConfiguracionesController(IConfiguracionesApplicationService configuracionesAppService)
        {
            _configuracionesAppService = configuracionesAppService;
        }

        [HttpPost("crear-configuracion")]
        public async Task<IActionResult> CrearConfiguracion(ConfiguracionesRequest request)
        {
            var configuracion = await _configuracionesAppService.CrearConfiguracion(request);
            return MapResult(configuracion);
        }

        [HttpPost("obtener-configuraciones")]
        public async Task<IActionResult> GetConfiguraciones(ConfiguracionesRequest request)
        {
            var configuraciones = await _configuracionesAppService.ObtenerConfiguracionesPaginado(request);
            return MapResult(configuraciones);
        }

        [HttpPost("crear-configuracion-detalle")]
        public async Task<IActionResult> CrearConfiguracionesDetalle(ConfiguracionesRequest request)
        {
            var configuracionesDetalle = await _configuracionesAppService.CrearConfiguracionDetalle(request);
            return MapResult(configuracionesDetalle);
        }

        [HttpPost("editar-configuracion-detalle")]
        public async Task<IActionResult> EditarConfiguracionesDetalle(ConfiguracionesRequest request)
        {
            var configuracionesDetalle = await _configuracionesAppService.EditarConfiguracionesDetalle(request);
            return MapResult(configuracionesDetalle);
        }

        [HttpPost("editar-configuracion")]
        public async Task<IActionResult> EditarConfiguracion(ConfiguracionesRequest request)
        {
            var configuracion = await _configuracionesAppService.EditarConfiguracion(request);
            return MapResult(configuracion);
        }

        private IActionResult MapResult<T>(Result<T> result)
        {
            if (result == null) return StatusCode(500);

            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return result.Status switch
            {
                ResultStatus.ValidationError => BadRequest(result),
                ResultStatus.ApplicationError => Conflict(result),
                ResultStatus.Exception => StatusCode(500, result),
                _ => BadRequest(result),
            };
        }
    }
}
````

## File: Dominio/Core/Extensions/EntidadExtension.cs
````csharp
using System.Runtime.Serialization;

namespace Dominio.Core.Extensions
{
    public static class EntidadExtension
    {
        /// <summary>
        /// Crea una copia profunda de un objeto utilizando <see cref="DataContractSerializer"/>.
        /// </summary>
        /// <typeparam name="T">El tipo del objeto a copiar. Debe ser serializable mediante DataContract.</typeparam>
        /// <param name="theSource">El objeto fuente que se desea clonar.</param>
        /// <returns>
        /// Una nueva instancia de <typeparamref name="T"/> que representa una copia profunda del objeto original.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// [DataContract]
        /// public class Persona
        /// {
        ///     [DataMember]
        ///     public string Nombre { get; set; }
        ///
        ///     [DataMember]
        ///     public int Edad { get; set; }
        /// }
        ///
        /// Persona original = new Persona { Nombre = "Ana", Edad = 30 };
        /// Persona copia = original.DeepCopy();
        ///
        /// Console.WriteLine($"Original: {original.Nombre}, {original.Edad}");
        /// Console.WriteLine($"Copia: {copia.Nombre}, {copia.Edad}");
        /// // Salida: 
        /// // Original: Ana, 30
        /// // Copia: Ana, 30
        /// </code>
        /// </example>
        public static T DeepCopy<T>(this T theSource) 
            where T : class 
        {
            ArgumentNullException.ThrowIfNull(theSource);

            var theDataContactSerializer = new DataContractSerializer(typeof(T));

            using var memStream = new MemoryStream();

            theDataContactSerializer.WriteObject(memStream, theSource);
            memStream.Position = 0;
            var theCopy = theDataContactSerializer.ReadObject(memStream) as T;

            return theCopy ?? throw new SerializationException($"No se pudo deserializar el objeto como {typeof(T).Name}.");
        }
    }
}
````

## File: Dominio/Core/Extensions/EnumerableExtensions.cs
````csharp
namespace Dominio.Core.Extensions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Devuelve la colección original si no es nula; 
        /// en caso contrario, devuelve una colección vacía.
        /// </summary>
        /// <typeparam name="T">El tipo de elementos contenidos en la colección.</typeparam>
        /// <param name="list">La colección que se desea evaluar.</param>
        /// <returns>
        /// La colección original si no es nula; de lo contrario, una nueva colección vacía.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// IEnumerable<string> nombres = null;
        ///
        /// // Al usar Items(), evitamos excepciones por referencia nula.
        /// foreach (var nombre in nombres.Items())
        /// {
        ///     Console.WriteLine(nombre);
        /// }
        ///
        /// // Salida: (no imprime nada, pero tampoco lanza excepción)
        /// </code>
        /// </example>
        public static IEnumerable<T> Items<T>(this IEnumerable<T> list)
        {
            var isNull = IsNull(list);

            return isNull ? new HashSet<T>() : list;
        }

        /// <summary>
        /// Determina si una colección contiene elementos.
        /// </summary>
        /// <typeparam name="T">El tipo de elementos contenidos en la colección.</typeparam>
        /// <param name="list">La colección que se desea evaluar.</param>
        /// <returns>
        /// <c>true</c> si la colección no es nula y contiene al menos un elemento; 
        /// en caso contrario, <c>false</c>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// IEnumerable<int> numeros = new List<int> { 1, 2, 3 };
        /// IEnumerable<int> vacia = new List<int>();
        /// IEnumerable<int> nula = null;
        ///
        /// bool tieneNumeros = numeros.HasItems(); // True
        /// bool tieneVacia = vacia.HasItems();     // False
        /// bool tieneNula = nula.HasItems();       // False
        ///
        /// Console.WriteLine($"Numeros: {tieneNumeros}");
        /// Console.WriteLine($"Vacia: {tieneVacia}");
        /// Console.WriteLine($"Nula: {tieneNula}");
        /// </code>
        /// </example>
        public static bool HasItems<T>(this IEnumerable<T> list)
        {
            var isNull = IsNull(list);

            if (isNull) return false;

            return list.Any();
        }

        /// <summary>
        /// Determina si un objeto es nulo.
        /// </summary>
        /// <param name="item">El objeto que se desea evaluar.</param>
        /// <returns>
        /// <c>true</c> si <paramref name="item"/> es nulo; en caso contrario, <c>false</c>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// object objeto1 = null;
        /// object objeto2 = "Hola mundo";
        ///
        /// bool esNulo1 = objeto1.IsNull(); // True
        /// bool esNulo2 = objeto2.IsNull(); // False
        ///
        /// Console.WriteLine($"Objeto1 es nulo: {esNulo1}");
        /// Console.WriteLine($"Objeto2 es nulo: {esNulo2}");
        /// </code>
        /// </example>
        public static bool IsNull(this object? item)
        {
            return item == null;
        }

        /// <summary>
        /// Determina si un objeto no es nulo.
        /// </summary>
        /// <param name="item">El objeto que se desea evaluar.</param>
        /// <returns>
        /// <c>true</c> si <paramref name="item"/> no es nulo; en caso contrario, <c>false</c>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// object objeto1 = null;
        /// object objeto2 = "Hola mundo";
        ///
        /// bool noEsNulo1 = objeto1.IsNotNull(); // False
        /// bool noEsNulo2 = objeto2.IsNotNull(); // True
        ///
        /// Console.WriteLine($"Objeto1 no es nulo: {noEsNulo1}");
        /// Console.WriteLine($"Objeto2 no es nulo: {noEsNulo2}");
        /// </code>
        /// </example>
        public static bool IsNotNull(this object item)
        {
            return item != null;
        }

        /// <summary>
        /// Crea una nueva lista a partir de una colección enumerable.
        /// </summary>
        /// <typeparam name="T">El tipo de elementos contenidos en la colección.</typeparam>
        /// <param name="list">La colección enumerable que se desea copiar.</param>
        /// <returns>
        /// Una nueva instancia de <see cref="List{T}"/> que contiene los mismos elementos
        /// que la colección original.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// IEnumerable<string> nombres = new[] { "Ana", "Luis", "Carlos" };
        ///
        /// List<string> listaCopiada = nombres.CopyToList();
        ///
        /// foreach (var nombre in listaCopiada)
        /// {
        ///     Console.WriteLine(nombre);
        /// }
        /// // Salida:
        /// // Ana
        /// // Luis
        /// // Carlos
        /// </code>
        /// </example>
        public static IEnumerable<T> CopyToList<T>(this IEnumerable<T> list)
        {
            return new List<T>(list);
        }

        /// <summary>
        /// Determina si una colección está vacía o es nula.
        /// </summary>
        /// <typeparam name="T">El tipo de elementos contenidos en la colección.</typeparam>
        /// <param name="list">La colección que se desea evaluar.</param>
        /// <returns>
        /// <c>true</c> si la colección es nula o no contiene elementos; 
        /// en caso contrario, <c>false</c>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// IEnumerable<int> numeros = new List<int>();
        /// IEnumerable<int> nula = null;
        /// IEnumerable<int> conDatos = new List<int> { 1, 2, 3 };
        ///
        /// Console.WriteLine(numeros.IsEmpty());   // True
        /// Console.WriteLine(nula.IsEmpty());      // True
        /// Console.WriteLine(conDatos.IsEmpty());  // False
        /// </code>
        /// </example>
        public static bool IsEmpty<T>(this IEnumerable<T> list)
        {
            return !HasItems(list);
        }

        /// <summary>
        /// Devuelve una lista con los elementos distintos de la colección especificada.
        /// </summary>
        /// <typeparam name="T">El tipo de elementos contenidos en la colección.</typeparam>
        /// <param name="list">La colección de la cual se obtendrán los elementos únicos.</param>
        /// <returns>
        /// Una nueva lista de <typeparamref name="T"/> que contiene solo los elementos distintos.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// IEnumerable<int> numeros = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        ///
        /// List<int> distintos = numeros.DistinctList();
        ///
        /// foreach (var n in distintos)
        /// {
        ///     Console.WriteLine(n);
        /// }
        /// // Salida:
        /// // 1
        /// // 2
        /// // 3
        /// // 4
        /// // 5
        /// </code>
        /// </example>
        public static List<T> DistinctList<T>(this IEnumerable<T> list)
        {
            return list.Items().Distinct().ToList();
        }

        /// <summary>
        /// Excluye de la colección los elementos cuya propiedad especificada
        /// coincide con el valor proporcionado.
        /// </summary>
        /// <typeparam name="T">El tipo de elementos contenidos en la colección.</typeparam>
        /// <param name="list">La colección de la cual se filtrarán los elementos.</param>
        /// <param name="nameProperty">El nombre de la propiedad a evaluar.</param>
        /// <param name="value">El valor de la propiedad que se desea excluir.</param>
        /// <returns>
        /// Una nueva lista de <typeparamref name="T"/> que contiene los elementos
        /// cuya propiedad <paramref name="nameProperty"/> no coincide con <paramref name="value"/>.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// public class Persona
        /// {
        ///     public string Nombre { get; set; }
        ///     public string Ciudad { get; set; }
        /// }
        ///
        /// var personas = new List<Persona>
        /// {
        ///     new Persona { Nombre = "Ana", Ciudad = "Madrid" },
        ///     new Persona { Nombre = "Luis", Ciudad = "Barcelona" },
        ///     new Persona { Nombre = "Carlos", Ciudad = "Madrid" }
        /// };
        ///
        /// // Excluir las personas cuya Ciudad sea "Madrid"
        /// var filtradas = personas.ExcludeByPropertyValue("Ciudad", "Madrid");
        ///
        /// foreach (var p in filtradas)
        /// {
        ///     Console.WriteLine(p.Nombre);
        /// }
        /// // Salida:
        /// // Luis
        /// </code>
        /// </example>
        public static List<T> ExcludeByPropertyValue<T>(this IEnumerable<T> list, string nameProperty, string value)
        {
            var filteredCollection = new List<T>();
            foreach (var item in list)
            {

                var propertyInfo =
                    item.GetType()
                        .GetProperty(nameProperty);
                if (propertyInfo == null)
                    return list.ToList();

                var propertyValue = propertyInfo.GetValue(item, null);
                if (propertyValue.ToString() != value)
                {
                    filteredCollection.Add(item);
                }
            }

            return filteredCollection;
        }

        /// <summary>
        /// Devuelve una colección con elementos distintos de acuerdo a una clave especificada.
        /// </summary>
        /// <typeparam name="T">El tipo de elementos contenidos en la colección.</typeparam>
        /// <typeparam name="TKey">El tipo de la clave usada para determinar la unicidad.</typeparam>
        /// <param name="enumerable">La colección de la cual se obtendrán los elementos únicos.</param>
        /// <param name="keySelector">
        /// Función que selecciona la clave de cada elemento para evaluar su unicidad.
        /// </param>
        /// <returns>
        /// Una colección de <typeparamref name="T"/> que contiene solo el primer elemento de cada grupo
        /// definido por la clave.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// var personas = new List<Persona>
        /// {
        ///     new Persona { Nombre = "Ana", Ciudad = "Madrid" },
        ///     new Persona { Nombre = "Luis", Ciudad = "Barcelona" },
        ///     new Persona { Nombre = "Carlos", Ciudad = "Madrid" }
        /// };
        ///
        /// // Obtener personas distintas por Ciudad
        /// var distintasPorCiudad = personas.DistinctBy(p => p.Ciudad);
        ///
        /// foreach (var p in distintasPorCiudad)
        /// {
        ///     Console.WriteLine($"{p.Nombre} - {p.Ciudad}");
        /// }
        /// // Salida posible:
        /// // Ana - Madrid
        /// // Luis - Barcelona
        /// </code>
        /// </example>
        public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> enumerable, Func<T, TKey> keySelector)
        {
            return enumerable.GroupBy(keySelector).Select(s => s.First());
        }

        /// <summary>
        /// Ejecuta de manera asíncrona una función sobre cada elemento de la colección.
        /// </summary>
        /// <typeparam name="T">El tipo de elementos contenidos en la colección.</typeparam>
        /// <param name="enumerable">La colección cuyos elementos se recorrerán.</param>
        /// <param name="funcAsync">
        /// Función asíncrona que se aplicará a cada elemento de la colección.
        /// </param>
        /// <returns>
        /// Una tarea que representa la operación asíncrona de recorrer y ejecutar la función sobre todos los elementos.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// var numeros = new List<int> { 1, 2, 3 };
        ///
        /// await numeros.ForEachAsync(async n =>
        /// {
        ///     await Task.Delay(500); // Simula trabajo asíncrono
        ///     Console.WriteLine($"Procesado: {n}");
        /// });
        ///
        /// // Salida (con retraso de 500ms entre cada elemento):
        /// // Procesado: 1
        /// // Procesado: 2
        /// // Procesado: 3
        /// </code>
        /// </example>
        public static async Task ForEachAsync<T>(this IEnumerable<T> enumerable, Func<T, Task> funcAsync)
        {
            foreach (T item in enumerable)
            {
                await funcAsync(item);
            }
        }

        /// <summary>
        /// Obtiene una lista de valores únicos en formato <see cref="string"/> 
        /// a partir de una propiedad especificada de los elementos de la colección.
        /// </summary>
        /// <typeparam name="T">El tipo de elementos contenidos en la colección.</typeparam>
        /// <param name="collection">La colección de la cual se extraerán los valores.</param>
        /// <param name="propertyName">El nombre de la propiedad cuyos valores se desean obtener.</param>
        /// <returns>
        /// Una lista de cadenas que representan los valores distintos de la propiedad indicada.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// public class Persona
        /// {
        ///     public string Nombre { get; set; }
        ///     public string Ciudad { get; set; }
        /// }
        ///
        /// var personas = new List<Persona>
        /// {
        ///     new Persona { Nombre = "Ana", Ciudad = "Madrid" },
        ///     new Persona { Nombre = "Luis", Ciudad = "Barcelona" },
        ///     new Persona { Nombre = "Carlos", Ciudad = "Madrid" }
        /// };
        ///
        /// // Obtener lista de ciudades distintas
        /// var ciudades = personas.GetStringListOf("Ciudad");
        ///
        /// foreach (var ciudad in ciudades)
        /// {
        ///     Console.WriteLine(ciudad);
        /// }
        /// // Salida:
        /// // Madrid
        /// // Barcelona
        /// </code>
        /// </example>
        public static List<string> GetStringListOf<T>(this IEnumerable<T> collection, string propertyName)
        {
            var result = collection.Select(s => s.GetType().GetProperty(propertyName).GetValue(s, null).ToString());
            return result.Distinct().ToList();
        }

        /// <summary>
        /// Concatena los elementos de una colección en una sola cadena,
        /// separados por el delimitador especificado.
        /// </summary>
        /// <typeparam name="T">El tipo de elementos contenidos en la colección.</typeparam>
        /// <param name="collection">La colección cuyos elementos se unirán en una cadena.</param>
        /// <param name="separator">El separador que se usará entre los elementos.</param>
        /// <returns>
        /// Una cadena que contiene los elementos de la colección separados por <paramref name="separator"/>.
        /// Si la colección es nula o está vacía, devuelve una cadena vacía.
        /// </returns>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// var nombres = new List<string> { "Ana", "Luis", "Carlos" };
        ///
        /// string resultado = nombres.GetStringFromList(", ");
        /// Console.WriteLine(resultado);
        ///
        /// // Salida:
        /// // Ana, Luis, Carlos
        /// </code>
        /// </example>
        public static string GetStringFromList<T>(this IEnumerable<T> collection, string separator)
        {
            if (collection.HasItems())
            {
                return string.Join(separator, collection).Trim();
            }
            return string.Empty;
        }
    }
}
````

## File: Infraestructura/Context/Mapping/Seguridad/UsuarioMap.cs
````csharp
using Dominio.Context.Entidades.Seguridad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Context.Mapping.Seguridad
{
    internal class UsuarioMap : EntityMap<Usuario>
    {
        public override void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(r => r.UsuarioId);
            builder.ToTable("Usuario", "Seguridad");
            builder.Property(r => r.UsuarioId).HasColumnName("UsuarioId").IsRequired().IsUnicode(false).HasMaxLength(25);
            builder.Property(r => r.Nombre).HasColumnName("Nombre").IsRequired().HasMaxLength(50);
            builder.Property(r => r.Apellido).HasColumnName("Apellido").IsRequired().HasMaxLength(50);
            builder.Property(r => r.Contrasena).HasColumnName("Contrasena").IsRequired().HasMaxLength(250);
            builder.Property(r => r.RolId).HasColumnName("RolId").IsRequired().IsUnicode(false).HasMaxLength(25);
            builder.Property(r => r.Activo).HasColumnName("Activo").IsRequired();

            builder.HasOne(x => x.Rol).WithMany(r => r.Usuarios).HasForeignKey(x => x.RolId);

            base.Configure(builder);
        }
    }
}
````

## File: Infraestructura/Infraestructura.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="EntityFramework" Version="6.4.4" />
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="8.0.4" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Proxies" Version="8.0.4" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.4" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.4">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
    </PackageReference>
    <PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
    <PackageReference Include="System.Data.SqlClient" Version="4.8.6" />
    <PackageReference Include="System.IdentityModel.Tokens.Jwt" Version="7.5.1" />
    <PackageReference Include="Microsoft.Identity.Client" Version="4.84.1" />
    <PackageReference Include="Azure.Identity" Version="1.21.0" />
    <PackageReference Include="Microsoft.Extensions.Caching.Memory" Version="9.0.0" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\Dominio\Dominio.csproj" />
  </ItemGroup>

</Project>
````

## File: WebServices/Jwtoken/JwtConfiguration.cs
````csharp
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
````

## File: Aplicacion/Aplicacion.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="AutoMapper" Version="16.1.1" />
    <!-- Add safe packages for identity and caching -->
    <PackageReference Include="Microsoft.Identity.Client" Version="4.84.1" />
    <PackageReference Include="Azure.Identity" Version="1.21.0" />
    <PackageReference Include="Microsoft.Extensions.Caching.Memory" Version="9.0.0" />
    <PackageReference Include="FluentValidation" Version="11.4.0" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\Dominio\Dominio.csproj" />
    <ProjectReference Include="..\Infraestructura\Infraestructura.csproj" />
  </ItemGroup>

</Project>
````

## File: Aplicacion/DTOs/Seguridad/UserRequest.cs
````csharp
namespace Aplicacion.DTOs.Seguridad
{
    public class UserRequest : RequestBase
    {
        public string? UsuarioId { get; set; }
        public string? Password { get; set; }
    }

    public class EdicionUsuarioRequest : RequestBase
    {
        public UsuarioDTO? Usuario { get; set; }
    }

    public class GetUserRequest : RequestBase { }

    public class EdicionRolRequest : RequestBase
    {
        public RolDTO? Rol { get; set; }
    }

    public class EdicionPermisosRequest : RequestBase
    {
        public string? RolId { get; set; }
        public List<PermisosDTO>? Permisos { get; set; }
    }
}
````

## File: Dominio/Context/Entidades/Seguridad/Usuario.cs
````csharp
using Dominio.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Context.Entidades.Seguridad
{
    public class Usuario : Entity
    {
        [Key]
        public required string UsuarioId { get; set; }
        public required string Contrasena { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required bool Activo { get; set; }
        public string? RolId { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }

        [NotMapped]
        public string? Token { get; set; }
        [ForeignKey("RolId")]
        public virtual Rol? Rol { get; set; }
    }
}
````

## File: WebServices/Extensions/DependencyInjectionRepository.cs
````csharp
using Aplicacion.Core;
using System;
using Aplicacion.Services.ConfiguracionesApp;
using Aplicacion.Services.Seguridad;
using CrossCutting.Configuration;
using Infraestructura.Context;
using Infraestructura.Core.Jwtoken;
using Infraestructura.Core.RestClient;
using Microsoft.EntityFrameworkCore;

namespace WebServices.Extensions
{
    public static class DependencyInjectionRepository
    {
        public static IServiceCollection AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("conectionDataBase")
                ?? throw new InvalidOperationException("Connection string 'conectionDataBase' not found in configuration.");

            // Inicialización única de configuraciones
            AppSettingsManager.Initialize(connectionString);

            services.AddDbContext<MyContext>(dbContextOption =>
                dbContextOption.UseSqlServer(connectionString)
            );

            services.AddScoped<IDataContext, MyContext>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Servicios de Aplicación
            services.AddScoped<ISecurityApplicationService, SecurityAplicationService>();
            services.AddScoped<IConfiguracionesApplicationService, ConfiguracionesApplicationService>();

            return services;
        }

        public static IServiceCollection AddExternalAndSecurityServices(this IServiceCollection services)
        {
            // JWT
            services.AddTransient<ITokenService, JwtTokenService>();

            // Rest Client
            RestClientFactory.SetCurrent(new HttpRestClientFactory());
            //services.AddTransient<IRestClient, HttpRestClient>();
            //services.AddTransient<IRestClientFactory, HttpRestClientFactory>();

            return services;
        }
    }
}
````

## File: Aplicacion/DTOs/Seguridad/UsuarioDTO.cs
````csharp
using Dominio.Core.Extensions;
using System.Text;

namespace Aplicacion.DTOs.Seguridad
{
    public class UsuarioDTO : ResponseBase
    {
        public string? UsuarioId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Contrasena { get; set; }
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
        public bool UsuarioAutenticado { get; set; }
        public string? RolId { get; set; }
        public bool EditarContrasena { get; set; } = true;
        public bool Activo { get; set; }
        public List<PermisosDTO>? Permisos { get; set; }

        public string ValidarCampos()
        {
            StringBuilder mensajeValidacion = new StringBuilder();

            if (UsuarioId.IsMissingValue())
            {
                mensajeValidacion.AppendLine("El usuarioId es requerido");
            }
            if (Nombre.IsMissingValue())
            {
                mensajeValidacion.AppendLine("El nombre es requerido");
            }
            if (Apellido.IsMissingValue())
            {
                mensajeValidacion.AppendLine("El apellido es requerido");
            }
            if (EditarContrasena && Contrasena.IsMissingValue())
            {
                mensajeValidacion.AppendLine("La contraña es requerida");
            }
            if (RolId.IsMissingValue())
            {
                mensajeValidacion.AppendLine("El rol es requerido");
            }

            return mensajeValidacion.ToString();
        }
    }
}
````

## File: WebServices/appsettings.json
````json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",


  "ConnectionStrings": {
    "conectionDataBase": "Server=localhost; initial Catalog=test; Integrated Security=True; MultipleActiveResultSets=True;TrustServerCertificate=True;"
  },

  "JwtSettings": {
    "Secret": "CHANGE_ME_TO_A_STRONG_SECRET",
    "ExpirationInMinutes": 60,
    "RefreshTokenExpirationInDays": 7,
    "Issuer": "TemplateNetCore.Api",
    "Audience": "TemplateNetCore"
  },

  "Cors": {
    "AllowedOrigins": [ "https://localhost:5283" ]
  }
}
````

## File: WebServices/WebServices.csproj
````
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <InvariantGlobalization>false</InvariantGlobalization>
  </PropertyGroup>

  <ItemGroup>
    <Compile Remove="Controllers\TestRestClient.cs" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="AutoMapper" Version="16.1.1" />
    <PackageReference Include="Microsoft.AspNetCore.OpenApi" Version="10.0.8" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="8.0.4">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.Identity.Client" Version="4.84.1" />
    <PackageReference Include="Azure.Identity" Version="1.21.0" />
    <PackageReference Include="EntityFramework" Version="6.4.4" />
    <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="8.0.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="8.0.4" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Proxies" Version="8.0.4" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.4" />
    <PackageReference Include="Scalar.AspNetCore" Version="2.14.14" />
    <PackageReference Include="FluentValidation.AspNetCore" Version="11.3.1" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\Aplicacion\Aplicacion.csproj" />
    <ProjectReference Include="..\CrossCutting\CrossCutting.csproj" />
    <ProjectReference Include="..\Dominio\Dominio.csproj" />
    <ProjectReference Include="..\Infraestructura\Infraestructura.csproj" />
  </ItemGroup>

</Project>
````

## File: Aplicacion/Services/Seguridad/SecurityAplicationService.cs
````csharp
using Aplicacion.Core;
using Aplicacion.DTOs;
using Aplicacion.DTOs.Seguridad;
using System.Threading.Tasks;
using Aplicacion.Helpers;
using AutoMapper;
using Dominio.Context.Entidades;
using Dominio.Context.Entidades.Seguridad;
using Dominio.Core;
using Dominio.Core.Extensions;
using Dominio.Core.Jwtoken;
using Dominio.Core.Result;
using Infraestructura.Context;
using Infraestructura.Core.Jwtoken;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Aplicacion.Services.Seguridad
{
    public class SecurityAplicationService : BaseDisposable, ISecurityApplicationService
    {
        private readonly IGenericRepository<IDataContext> _genericRepository;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        private readonly JwtSettings _jwtSettings;
        public SecurityAplicationService(IGenericRepository<IDataContext> genericRepository, ITokenService tokenService, IMapper mapper, IOptions<JwtSettings> jwtSettings)
        {
            _genericRepository = genericRepository;
            _tokenService = tokenService;
            _mapper = mapper;
            _jwtSettings = jwtSettings.Value;
        }

        public Task<Result<UsuarioDTO>> EditarUsuario(EdicionUsuarioRequest request)
        {
            if (request.IsNull() || request.Usuario.IsNull())
            { 
                return Task.FromResult(Result<UsuarioDTO>.Failure("Usuario es obligatorio", "NULL_USUARIO"));
            }

            Usuario usuarioExiste = _genericRepository.GetSingle<Usuario>(r => r.UsuarioId == request.Usuario.UsuarioId);

            if (usuarioExiste.IsNull())
            { 
                return Task.FromResult(Result<UsuarioDTO>.Failure("El usuario no existe", "USER_NOT_FOUND"));
            }

            if (request.Usuario.EditarContrasena)
            {
                usuarioExiste.Contrasena = PasswordEncryptor.HashPassword(request.Usuario.Contrasena);
            } 

            usuarioExiste.Nombre = request.Usuario.Nombre.ValueOrEmpty();
            usuarioExiste.Apellido = request.Usuario.Apellido.ValueOrEmpty();
            usuarioExiste.RolId = request.Usuario.RolId.ValueOrEmpty();
            usuarioExiste.Activo = request.Usuario.Activo;

            TransactionInfo transactionInfo = request.RequestUserInfo?.CrearTransactionInfo("EditarUsuario")
                ?? new TransactionInfo { GenerateTransaction = false }; 
            _genericRepository.UnitOfWork.Commit(transactionInfo);

            return Task.FromResult(Result<UsuarioDTO>.Success(_mapper.Map<UsuarioDTO>(usuarioExiste), "Usuario actualizado exitosamente"));
        }

        public Task<Result<List<PantallaDTO>>> ObtenerPantallas()
        {
            var pantallas = _genericRepository.GetAll<Pantalla>();
            var lista = pantallas.Select(r => new PantallaDTO { Descripcion = r.Descripcion, PantallaId = r.PantallaId }).ToList(); 
            return Task.FromResult(Result<List<PantallaDTO>>.Success(lista));
        }

        public Task<Result<RolDTO>> EdicionPermisos(EdicionPermisosRequest request)
        {
            var permisos = _genericRepository.GetFiltered<Permisos>(r => r.RolId == request.RolId);

            foreach (var item in request.Permisos) 
            {
                var permiso = permisos.FirstOrDefault(r => r.PantallaId == item.PantallaId);
                if (permiso.IsNotNull())
                {
                    permiso.Ver = item.Ver;
                    permiso.Editar = item.Editar;
                    permiso.Eliminar = item.Eliminar;

                    if (!permiso.Ver)
                    {
                        _genericRepository.Remove(permiso);
                    }
                }
                else
                {
                    var nuevoPermiso = new Permisos 
                    {
                        Editar = item.Editar,
                        Eliminar = item.Eliminar,
                        PantallaId = item.PantallaId,
                        RolId = item.RolId,
                        Ver = item.Ver,
                    };
                    _genericRepository.Add(nuevoPermiso); 
                }
            }
            
            TransactionInfo transactionInfo = request.RequestUserInfo?.CrearTransactionInfo("AgregarUsuario")
                ?? new TransactionInfo { GenerateTransaction = false };
            _genericRepository.UnitOfWork.Commit(transactionInfo);
            return Task.FromResult(Result<RolDTO>.Success(new RolDTO())); 
        }

        public Task<Result<UsuarioDTO>> CrearUsuario(EdicionUsuarioRequest request)
        {
            if (request.IsNull() || request.Usuario.IsNull())
            { 
                return Task.FromResult(Result<UsuarioDTO>.Failure("Usuario es obligatorio", "NULL_USUARIO"));
            }

            var usuarioRequest = request.Usuario;

            Usuario usuarioExiste = _genericRepository.GetSingle<Usuario>(r => r.UsuarioId == usuarioRequest.UsuarioId);

            if (usuarioExiste.IsNotNull())
            { 
                return Task.FromResult(Result<UsuarioDTO>.Failure("Usuario ya esta registrado", "USER_EXISTS"));
            }

            var usuario = new Usuario
            {
                Apellido = usuarioRequest.Apellido.ValueOrEmpty(),
                Contrasena = PasswordEncryptor.HashPassword(usuarioRequest.Contrasena), 
                Nombre = usuarioRequest.Nombre.ValueOrEmpty(),
                RolId = usuarioRequest.RolId.ValueOrEmpty(),
                UsuarioId = usuarioRequest.UsuarioId.ValueOrEmpty(),
                Activo = usuarioRequest.Activo
            };

            _genericRepository.Add(usuario);
            TransactionInfo transactionInfo = request.RequestUserInfo?.CrearTransactionInfo("AgregarUsuario")
                ?? new TransactionInfo { GenerateTransaction = false };
            _genericRepository.UnitOfWork.Commit(transactionInfo);
            return Task.FromResult(Result<UsuarioDTO>.Success(_mapper.Map<UsuarioDTO>(usuario), "Usuario creado exitosamente"));
        }

        public Task<Result<UsuarioDTO>> IniciarSesion(UserRequest request)
        {
            var includes = new List<string> { "Rol", "Rol.Permisos" };

            if (string.IsNullOrWhiteSpace(request?.Password) || string.IsNullOrWhiteSpace(request?.UsuarioId))
            { 
                return Task.FromResult(Result<UsuarioDTO>.Failure("Usuario o Contraseña no valido", "INVALID_CREDENTIALS"));
            }

            Usuario usuario = _genericRepository.GetSingle<Usuario>(r => r.UsuarioId == request.UsuarioId, includes);

            if (usuario.IsNotNull() && PasswordEncryptor.VerifyPassword(request.Password, usuario.Contrasena))
            {
                if (!usuario.Activo)
                { 
                    return Task.FromResult(Result<UsuarioDTO>.Failure($"Usuario {usuario.UsuarioId} esta desactivado", "USER_INACTIVE"));
                }

                var newAccessToken = _tokenService.Generate(usuario);
                var newRefreshToken = _tokenService.GenerateRefreshToken();

                usuario.RefreshToken = HashRefreshToken(newRefreshToken);
                usuario.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_jwtSettings.RefreshTokenExpirationInDays);

                if (request.RequestUserInfo != null)
                {
                    request.RequestUserInfo.UsuarioId = usuario.UsuarioId;
                }

                TransactionInfo transactionInfo = request.RequestUserInfo?.CrearTransactionInfo("IniciarSesion")
                    ?? new TransactionInfo { GenerateTransaction = false };
                _genericRepository.UnitOfWork.Commit(transactionInfo);

                var resultDto = new UsuarioDTO
                {
                    Apellido = usuario.Apellido,
                    Nombre = usuario.Nombre,
                    RolId = usuario.RolId,
                    Token = newAccessToken,
                    RefreshToken = newRefreshToken,
                    UsuarioAutenticado = true,
                    UsuarioId = usuario.UsuarioId,
                    Permisos = MapPermisosDto(usuario.Rol?.Permisos)
                };

                return Task.FromResult(Result<UsuarioDTO>.Success(resultDto, "Inicio de sesión exitoso"));
            }

            return Task.FromResult(Result<UsuarioDTO>.Failure("Usuario o Contraseña no valido", "INVALID_CREDENTIALS"));
        }

        public Task<Result<UsuarioDTO>> RefreshToken(TokenRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.AccessToken) || string.IsNullOrWhiteSpace(request.RefreshToken))
            { 
                return Task.FromResult(Result<UsuarioDTO>.Failure("Solicitud de token inválida", "INVALID_TOKEN_REQUEST"));
            }

            ClaimsPrincipal principal;
            try
            {
                principal = _tokenService.GetPrincipalFromExpiredToken(request.AccessToken);
            } 
            catch (SecurityTokenException)
            {
                return Task.FromResult(Result<UsuarioDTO>.Failure("Token de acceso inválido", "INVALID_ACCESS_TOKEN"));
            }

            string? userId = principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrWhiteSpace(userId))
            { 
                return Task.FromResult(Result<UsuarioDTO>.Failure("Token de acceso inválido", "INVALID_ACCESS_TOKEN"));
            }

            string refreshTokenHash = HashRefreshToken(request.RefreshToken);
            var usuario = _genericRepository.GetSingle<Usuario>(u => u.UsuarioId == userId && u.RefreshToken == refreshTokenHash, new List<string> { "Rol", "Rol.Permisos" });

            if (usuario == null || !usuario.Activo || usuario.RefreshTokenExpiryTime <= DateTime.UtcNow)
            { 
                return Task.FromResult(Result<UsuarioDTO>.Failure("Token de refresco inválido o expirado", "INVALID_REFRESH_TOKEN"));
            }

            var newAccessToken = _tokenService.Generate(usuario);
            var newRefreshToken = _tokenService.GenerateRefreshToken();

            usuario.RefreshToken = HashRefreshToken(newRefreshToken);
            usuario.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(_jwtSettings.RefreshTokenExpirationInDays);

            TransactionInfo transactionInfo = request.RequestUserInfo?.CrearTransactionInfo("RefreshToken")
                ?? new TransactionInfo { GenerateTransaction = false };
            _genericRepository.UnitOfWork.Commit(transactionInfo);

            var resultDto = new UsuarioDTO 
            {
                Apellido = usuario.Apellido,
                Nombre = usuario.Nombre,
                RolId = usuario.RolId,
                Token = newAccessToken,
                RefreshToken = newRefreshToken,
                UsuarioAutenticado = true,
                UsuarioId = usuario.UsuarioId,
                Permisos = MapPermisosDto(usuario.Rol?.Permisos)
            };

            return Task.FromResult(Result<UsuarioDTO>.Success(resultDto, "Token renovado correctamente"));
        }

        public Task<Result<SearchResult<UsuarioDTO>>> ObtenerUsuario(GetUserRequest request)
        {
            var queryInfo = request.QueryInfo ?? new QueryInfo();
            var dynamicFilter = DynamicFilterFactory.CreateDynamicFilter(queryInfo);
            var usuarios = _genericRepository.GetPagedAndFiltered<Usuario>(dynamicFilter);
            var result = new SearchResult<UsuarioDTO>
            {
                PageCount = usuarios.PageCount,
                ItemCount = usuarios.ItemCount,
                TotalItems = usuarios.TotalItems,
                PageIndex = usuarios.PageIndex,
                Items = (from qry in usuarios.Items as IEnumerable<Usuario> select MapUsuarioDto(qry)).ToList(),
            };

            return Task.FromResult(Result<SearchResult<UsuarioDTO>>.Success(result));
        }

        public Task<Result<RolDTO>> CrearRol(EdicionRolRequest request)
        {
            if (request.Rol is null)
            {
                return Task.FromResult(Result<RolDTO>.Failure("El rol es obligatorio", "NULL_ROLE"));
            }

            var rol = _genericRepository.GetSingle<Rol>(r => r.RolId == request.Rol.RolId);
            if (rol.IsNotNull())
            {
                return Task.FromResult(Result<RolDTO>.Failure($"El rol {request.Rol.RolId} ya existe", "ROLE_EXISTS"));
            }

            var nuevoRol = new Rol
            {
                Descripcion = request.Rol.Descripcion,
                RolId = request.Rol.RolId
            };

            _genericRepository.Add(nuevoRol);
            TransactionInfo transactionInfo = request.RequestUserInfo?.CrearTransactionInfo("AgregarRol")
                ?? new TransactionInfo { GenerateTransaction = false };
            _genericRepository.UnitOfWork.Commit(transactionInfo);

            return Task.FromResult(Result<RolDTO>.Success(new RolDTO()));
        }

        public Task<Result<RolDTO>> EditarRol(EdicionRolRequest request)
        {
            if (request.Rol is null)
            {
                return Task.FromResult(Result<RolDTO>.Failure("El rol es obligatorio", "NULL_ROLE"));
            }

            var rol = _genericRepository.GetSingle<Rol>(r => r.RolId == request.Rol.RolId);

            if (rol.IsNull())
            {
                return Task.FromResult(Result<RolDTO>.Failure($"El Rol {request.Rol.RolId} no existe", "ROLE_NOT_FOUND"));
            }

            rol.Descripcion = request.Rol.Descripcion;
            TransactionInfo transactionInfo = request.RequestUserInfo?.CrearTransactionInfo("EditarRol")
                ?? new TransactionInfo { GenerateTransaction = false };
            _genericRepository.UnitOfWork.Commit(transactionInfo);
            return Task.FromResult(Result<RolDTO>.Success(new RolDTO()));
        }

        public Task<Result<List<RolDTO>>> ObtenerRoles()
        {
            var includes = new List<string> { "Permisos" };
            var roles = _genericRepository.GetAll<Rol>(includes);
            var lista = roles.Select(qry =>
            new RolDTO
            {
                Descripcion = qry.Descripcion,
                RolId = qry.RolId,
                Permisos = MapPermisosDto(qry?.Permisos),
            }).ToList();

            return Task.FromResult(Result<List<RolDTO>>.Success(lista));
        }

        private static List<PermisosDTO> MapPermisosDto(List<Permisos>? permisos)
        {
            return permisos?.Select(r => new PermisosDTO
            {
                Editar = r.Editar,
                Eliminar = r.Eliminar,
                PantallaId = r.PantallaId,
                RolId = r.RolId,
                Ver = r.Ver,
            }).ToList() ?? new List<PermisosDTO>();
        }

        private static UsuarioDTO MapUsuarioDto(Usuario qry)
        {
            return new UsuarioDTO
            {
                Apellido = qry.Apellido,
                Nombre = qry.Nombre,
                RolId = qry.RolId,
                UsuarioId = qry.UsuarioId,
                FechaTransaccion = qry.FechaTransaccion,
                Activo = qry.Activo
            };
        }

        private static string HashRefreshToken(string refreshToken)
        {
            var tokenBytes = Encoding.UTF8.GetBytes(refreshToken);
            var hashBytes = SHA256.HashData(tokenBytes);
            return Convert.ToBase64String(hashBytes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_genericRepository.IsNotNull()) _genericRepository.Dispose();

            }

            base.Dispose(disposing);
        }
    }
}
````

## File: README.md
````markdown
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
````

## File: WebServices/Controllers/UserController.cs
````csharp
using Aplicacion.DTOs;
using Aplicacion.DTOs.Seguridad;
using Aplicacion.Services.Seguridad;
using Dominio.Core.Result;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace WebServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ISecurityApplicationService _securityAppService;
        public UserController(ISecurityApplicationService securityAppService)
        {
            _securityAppService = securityAppService;
        }

        [AllowAnonymous]
        [EnableRateLimiting("AuthPolicy")]
        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserRequest request)
        {
            var usuario = await _securityAppService.IniciarSesion(request);
            return MapResult(usuario);
        }

        [AllowAnonymous]
        [EnableRateLimiting("AuthPolicy")]
        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken([FromBody] TokenRequest request)
        {
            var usuario = await _securityAppService.RefreshToken(request);
            return MapResult(usuario);
        }

        [Authorize]
        [HttpPost("crear-usuario")]
        public async Task<IActionResult> CreateUser(EdicionUsuarioRequest request)
        {
            var usuario = await _securityAppService.CrearUsuario(request);
            return MapResult(usuario);
        }

        [Authorize]
        [HttpPost("editar-usuario")]
        public async Task<IActionResult> EditarUsuario(EdicionUsuarioRequest request)
        {
            var usuario = await _securityAppService.EditarUsuario(request);
            return MapResult(usuario);
        }

        [Authorize]
        [HttpPost("obtener-usuarios")]
        public async Task<IActionResult> ObtenerUsuarios(GetUserRequest request)
        {
            var usuarios = await _securityAppService.ObtenerUsuario(request);
            return MapResult(usuarios);
        }

        [Authorize]
        [HttpGet("obtener-roles")]
        public async Task<IActionResult> ObtenerRoles()
        {
            var roles = await _securityAppService.ObtenerRoles();
            return MapResult(roles);
        }

        [Authorize]
        [HttpPost("crear-rol")]
        public async Task<IActionResult> CrearRol(EdicionRolRequest request)
        {
            var rol = await _securityAppService.CrearRol(request);
            return MapResult(rol);
        }

        [Authorize]
        [HttpPost("editar-rol")]
        public async Task<IActionResult> EditarRol(EdicionRolRequest request)
        {
            var rol = await _securityAppService.EditarRol(request);
            return MapResult(rol);
        }

        [Authorize]
        [HttpGet("obtener-pantalla")]
        public async Task<IActionResult> ObtenerPantalla()
        {
            var pantallas = await _securityAppService.ObtenerPantallas();
            return MapResult(pantallas);
        }

        [Authorize]
        [HttpPost("edicion-permisos")]
        public async Task<IActionResult> EdicionPermisos(EdicionPermisosRequest request)
        {
            var rol = await _securityAppService.EdicionPermisos(request);
            return MapResult(rol);
        }

        private IActionResult MapResult<T>(Result<T> result)
        {
            if (result == null) return StatusCode(500);

            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }

            return result.Status switch
            {
                ResultStatus.ValidationError => BadRequest(result),
                ResultStatus.ApplicationError => Conflict(result),
                ResultStatus.Exception => StatusCode(500, result),
                _ => BadRequest(result),
            };
        }
    }
}
````

## File: WebServices/Program.cs
````csharp
using Aplicacion.Core;
using Infraestructura.Context;
using Scalar.AspNetCore;
using WebServices.Extensions;
using WebServices.Jwtoken;
using WebServices.Middleware;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.RateLimiting;
using System.Threading.RateLimiting;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

builder.ConfigureJwt();

builder.Services.AddAutoMapper(cfg => cfg.AddMaps(typeof(AutoMapperProfile).Assembly));

// FluentValidation: register automatic validation and scan for validators in Aplicacion assembly
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssembly(typeof(Aplicacion.Services.Seguridad.Validators.UsuarioDTOValidator).Assembly);

const string AllowSpecificOriginsPolicy = "AllowSpecificOriginsPolicy";
const string AuthRateLimitPolicy = "AuthPolicy";

builder.Services.AddCors(options =>
{
    options.AddPolicy(AllowSpecificOriginsPolicy, policy =>
    {
        var allowedOrigins = builder.Configuration
            .GetSection("Cors:AllowedOrigins")
            .Get<string[]>() ?? new string[0];

        if (allowedOrigins.Length == 0)
        {
            throw new InvalidOperationException("Cors:AllowedOrigins must be configured.");
        }

        policy.WithOrigins(allowedOrigins)
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddRateLimiter(options =>
{
    options.RejectionStatusCode = StatusCodes.Status429TooManyRequests;
    options.AddFixedWindowLimiter(AuthRateLimitPolicy, limiterOptions =>
    {
        limiterOptions.PermitLimit = 5;
        limiterOptions.Window = TimeSpan.FromMinutes(1);
        limiterOptions.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
        limiterOptions.QueueLimit = 0;
    });
});

builder.Services.AddPersistenceInfrastructure(builder.Configuration);
builder.Services.AddApplicationServices();          
builder.Services.AddExternalAndSecurityServices();

builder.Services.AddTransient<GlobalExceptionHandlingMiddleware>();

var app = builder.Build();

// 🔹 Seeder: insertar datos iniciales
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<MyContext>();

    // Inserta datos iniciales solo si no existen. El usuario admin requiere contraseña configurada.
    DataSeeder.Seed(context, app.Configuration["Seed:AdminPassword"]);
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseMiddleware<GlobalExceptionHandlingMiddleware>();

app.UseCors(AllowSpecificOriginsPolicy);
app.UseRateLimiter();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
````
