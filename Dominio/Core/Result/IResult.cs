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
