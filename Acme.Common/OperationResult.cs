namespace Acme.Common
{
    /// <summary>
    /// Provides a success flag and message 
    /// useful as a method return type.
    /// </summary>
    public class OperationResult<TResult, TMessage>
    {
        public OperationResult()
        {
        }

        public OperationResult(TResult success, TMessage message) : this()
        {
            this.Result = success;
            this.Message = message;
        }

        public TResult Result { get; set; }
        public TMessage Message { get; set; }
    }
}
