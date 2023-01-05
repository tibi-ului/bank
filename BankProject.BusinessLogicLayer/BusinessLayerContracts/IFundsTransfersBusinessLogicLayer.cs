using BankProject.Entities;
using System;
using System.Collections.Generic;

namespace BankProject.BusinessLogicLayer.BussinessLayerContracts
{
    public interface IFundsTransfersBusinessLogicLayer
    {
        List<FundsTransfer> GetFundsTransfers();
        List<FundsTransfer> GetFundsTransfersByCondition(Predicate<FundsTransfer> predicate);
        Guid AddFundsTransfer(FundsTransfer fundsTransfer);
        bool UpdateFundsTransfer(FundsTransfer fundsTransfer);
        bool DeleteFundsTransfer(Guid fundsTransferID);
    }
}





