using BankProject.DataAccesLayer.DALContracts;
using BankProject.Entities;
using BankProject.Entities.Contracts;
using BankProject.Exceptions;
using System;
using System.Collections.Generic;


namespace BankProject.DataAccesLayer
{
    public class FundsTransfersDataAccessLayer: IFundsTransfersDataAccessLayer
    {
        private static List<FundsTransfer> _fundsTransfers;


        static FundsTransfersDataAccessLayer()
        {
            _fundsTransfers = new List<FundsTransfer>();
        }


        private static List<FundsTransfer> FundsTransfers
        {
            get => _fundsTransfers;
            set => _fundsTransfers = value;
        }


        public List<FundsTransfer> GetFundsTransfers()
        {
            try
            {

                List<FundsTransfer> fundsTransfersList = new List<FundsTransfer>();

                FundsTransfers.ForEach(item => fundsTransfersList.Add(item.Clone() as FundsTransfer));
                return fundsTransfersList;
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
                List<FundsTransfer> fundsTransfersList = new List<FundsTransfer>();

                List<FundsTransfer> filteredFundsTransfers = FundsTransfers.FindAll(predicate);

                filteredFundsTransfers.ForEach(item => fundsTransfersList.Add(item.Clone() as FundsTransfer));
                return fundsTransfersList;
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

        public Guid AddFundsTransfer(FundsTransfer fundsTransfer)
        {
            try
            {
                fundsTransfer.FundsTransferID = Guid.NewGuid();

                FundsTransfers.Add(fundsTransfer);

                return fundsTransfer.FundsTransferID;
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

        public bool UpdateFundsTransfer(FundsTransfer fundsTransfer)
        {
            try
            {

                FundsTransfer existingFundsTransfer = FundsTransfers.Find(item => item.FundsTransferID == fundsTransfer.FundsTransferID);

                if (existingFundsTransfer != null)
                {
                    existingFundsTransfer.FundsTransferCode = fundsTransfer.FundsTransferCode;
                    existingFundsTransfer.FundsTransferName = fundsTransfer.FundsTransferName;

                    return true;   
                }
                else
                {
                    return false;   
                }
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

        public bool DeleteFundsTransfer(Guid fundsTransferID)
        {
            try
            {
                if (FundsTransfers.RemoveAll(item => item.FundsTransferID == fundsTransferID) > 0)
                {
                    Console.WriteLine("The fundsTransfer was deleted");
                    return true;   
                }
                else
                {
                    Console.WriteLine("The fundsTransfer is not deleted");
                    return false;   
                }
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
