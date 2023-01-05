using BankProject.BusinessLogicLayer.BussinessLayerContracts;
using BankProject.DataAccesLayer;
using BankProject.DataAccesLayer.DALContracts;
using BankProject.Entities;
using BankProject.Exceptions;
using System;
using System.Collections.Generic;


namespace BankProject.BusinessLogicLayer
{
    public class FundsTransfersBusinessLogicLayer: IFundsTransfersBusinessLogicLayer
    {
        private IFundsTransfersDataAccessLayer _fundsTransfersDataAccessLayer;


        public FundsTransfersBusinessLogicLayer()
        {
            _fundsTransfersDataAccessLayer = new FundsTransfersDataAccessLayer();
        }


        private IFundsTransfersDataAccessLayer FundsTransfersDataAccessLayer
        {
            get => _fundsTransfersDataAccessLayer;
            set => _fundsTransfersDataAccessLayer = value;
        }


        public List<FundsTransfer> GetFundsTransfers()
        {
            try
            {
                return FundsTransfersDataAccessLayer.GetFundsTransfers();
            }
            catch (FundsTransferException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }

        }


        public List<FundsTransfer> GetFundsTransfersByCondition(Predicate<FundsTransfer> predicate)
        {
            try
            {
                return FundsTransfersDataAccessLayer.GetFundsTransfersByCondition(predicate);
            }
            catch (FundsTransferException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Guid AddFundsTransfer(FundsTransfer FundsTransfer)
        {
            try
            {
                List<FundsTransfer> allFundsTransfers = FundsTransfersDataAccessLayer.GetFundsTransfers();
                long maxFundsTransferCode = 0;
                foreach (var item in allFundsTransfers)
                {
                    if (item.FundsTransferCode > maxFundsTransferCode)
                    {
                        maxFundsTransferCode = item.FundsTransferCode;
                    }
                }
                if (allFundsTransfers.Count >= 1)
                {
                    FundsTransfer.FundsTransferCode = maxFundsTransferCode + 1;
                }
                else
                {
                    FundsTransfer.FundsTransferCode = BankProject.Configuration.Settings.BaseFundsTransferNo + 1;
                }
                return FundsTransfersDataAccessLayer.AddFundsTransfer(FundsTransfer);
            }
            catch (FundsTransferException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateFundsTransfer(FundsTransfer FundsTransfer)
        {
            try
            {

                return FundsTransfersDataAccessLayer.UpdateFundsTransfer(FundsTransfer);
            }
            catch (FundsTransferException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool DeleteFundsTransfer(Guid FundsTransferID)
        {
            try
            {

                return FundsTransfersDataAccessLayer.DeleteFundsTransfer(FundsTransferID);
            }
            catch (FundsTransferException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
