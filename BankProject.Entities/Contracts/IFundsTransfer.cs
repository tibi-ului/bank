using System;


namespace BankProject.Entities.Contracts
{
    internal interface IFundsTransfer
    {
        Guid FundsTransferID { get; set; }
        long FundsTransferCode { get; set; }
        string FundsTransferName { get; set; }
    }
}
