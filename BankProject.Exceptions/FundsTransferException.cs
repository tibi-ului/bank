using System;


namespace BankProject.Exceptions
{
    public class FundsTransferException : ApplicationException
    {
        public FundsTransferException(string message) : base(message) { }
        public FundsTransferException(string message, Exception innerException) : base(message, innerException) { }
    }
}
