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
        private Result(bool isSuccess, T? data, string message, string? errorCode = null, IEnumerable<string>? errors = null)
            : base(isSuccess, message, errorCode, errors)
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
            return new Result<T>(true, data, message);
        }

        /// <summary>
        /// Crea un resultado fallido sin datos.
        /// </summary>
        /// <param name="message">Mensaje de error.</param>
        /// <param name="errorCode">Código de error opcional.</param>
        /// <returns>Un <see cref="Result{T}"/> fallido.</returns>
        public static Result<T> Failure(string message, string? errorCode = null)
        {
            return new Result<T>(false, default, message, errorCode);
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
            return new Result<T>(false, default, message, errorCode, errors);
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
                return Result<TNew>.Failure($"Error en proyección: {ex.Message}", "PROJECTION_ERROR");
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
                return Result<TNew>.Failure($"Error en encadenamiento: {ex.Message}", "BIND_ERROR");
            }
        }
    }
}
