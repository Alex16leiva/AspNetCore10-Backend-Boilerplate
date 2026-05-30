namespace Dominio.Core.Result
{
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
        /// Constructor protegido para inicializar un resultado.
        /// </summary>
        protected Result(bool isSuccess, string message, string? errorCode = null, IEnumerable<string>? errors = null)
        {
            IsSuccess = isSuccess;
            Message = message;
            ErrorCode = errorCode;
            Errors = errors?.ToList().AsReadOnly() ?? Array.Empty<string>().AsReadOnly();
        }

        /// <summary>
        /// Crea un resultado exitoso con un mensaje opcional.
        /// </summary>
        public static Result Success(string message = "Operación exitosa")
        {
            return new Result(true, message);
        }

        /// <summary>
        /// Crea un resultado fallido con un mensaje de error y código opcional.
        /// </summary>
        public static Result Failure(string message, string? errorCode = null)
        {
            return new Result(false, message, errorCode);
        }

        /// <summary>
        /// Crea un resultado fallido con múltiples errores de validación.
        /// </summary>
        public static Result ValidationFailure(string message, IEnumerable<string> errors, string? errorCode = null)
        {
            return new Result(false, message, errorCode, errors);
        }
    }
}
