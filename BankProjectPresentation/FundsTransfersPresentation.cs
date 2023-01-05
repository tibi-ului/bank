using BankProject.BusinessLogicLayer.BussinessLayerContracts;
using BankProject.BusinessLogicLayer;
using BankProject.Entities;
using System;
using System.Collections.Generic;


namespace BankProject.Presentation
{
    static class FundsTransfersPresentation
    {
        internal static void AddFundsTransfer()
        {
            try
            {
                FundsTransfer fundsTransfer = new FundsTransfer();

                Console.WriteLine("\n---Add FundsTransfer---");
                Console.Write("FundsTransfer Name: ");
                fundsTransfer.FundsTransferName = Console.ReadLine();



                IFundsTransfersBusinessLogicLayer fundsTransfersBusinessLogicLayer = new FundsTransfersBusinessLogicLayer();
                Guid newGuid = fundsTransfersBusinessLogicLayer.AddFundsTransfer(fundsTransfer);

                List<FundsTransfer> matchingFundsTransfers = fundsTransfersBusinessLogicLayer.GetFundsTransfersByCondition(item => item.FundsTransferID == newGuid);
                if (matchingFundsTransfers.Count >= 1)
                {
                    Console.WriteLine("New FundsTransfer Code:" + matchingFundsTransfers[0].FundsTransferCode);
                    Console.WriteLine("FundsTransfer Added.\n");

                }
                else
                {
                    Console.WriteLine("FundsTransfer Not added");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
        }





        internal static void ViewFundsTransfers()
        {
            try
            {
                IFundsTransfersBusinessLogicLayer fundsTransfersBusinessLogicLayer = new FundsTransfersBusinessLogicLayer();

                List<FundsTransfer> allFundsTransfers = fundsTransfersBusinessLogicLayer.GetFundsTransfers();
                Console.WriteLine("\n---ALL Accounts---");


                foreach (var item in allFundsTransfers)
                {
                    Console.WriteLine("FundsTransfer Code:" + item.FundsTransferCode);
                    Console.WriteLine("FundsTransfer Name:" + item.FundsTransferName);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
        }

    }
}
