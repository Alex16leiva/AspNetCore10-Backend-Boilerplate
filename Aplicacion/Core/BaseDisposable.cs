namespace Aplicacion.Core
{
    public class BaseDisposable : IDisposable
    {
        private bool _disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) 
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                //free other states (managed objects).
            }
            //free your own state (unmanaged objects).
            //Set large fields to null.

            _disposed = true;
        }

        ~BaseDisposable()
        {
            Dispose(false);
        }
    }
}
