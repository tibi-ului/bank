using System;
using System.Collections.Generic;
using BankProject.Entities;
using BankProject.Exceptions;
using BankProject.BusinessLogicLayer;
using BankProject.BusinessLogicLayer.BussinessLayerContracts;
using BankProject.Entities.Contracts;

namespace BankProject.Presentation
{
    static class AccountsPresentation
    {
        internal static void AddAccount()
        {
            try
            {
                //create an object of Account
                Account account = new Account();

                //read all details from the user
                Console.WriteLine("\n---Add Account---");
                Console.Write("Account Name: ");
                account.AccountName = Console.ReadLine();

           

                //create bl object
                IAccountsBusinessLogicLayer accountsBusinessLogicLayer = new AccountsBusinessLogicLayer();
                Guid newGuid = accountsBusinessLogicLayer.AddAccount(account);

                List<Account> matchingAccounts = accountsBusinessLogicLayer.GetAccountsByCondition(item => item.AccountID == newGuid);
                if (matchingAccounts.Count >= 1)
                {
                    Console.WriteLine("New Account Code:" + matchingAccounts[0].AccountCode);
                    Console.WriteLine("Account Added.\n");

                }
                else
                {
                    Console.WriteLine("Account Not added");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
        }

       



        internal static void ViewAccounts()
        {
            try
            {
                //create bl object
                IAccountsBusinessLogicLayer accountsBusinessLogicLayer = new AccountsBusinessLogicLayer();

                List<Account> allAccounts = accountsBusinessLogicLayer.GetAccounts();
                Console.WriteLine("\n---ALL Accounts---");

                //read all accounts

                foreach (var item in allAccounts)
                {
                    Console.WriteLine("Account Code:" + item.AccountCode);
                    Console.WriteLine("Account Name:" + item.AccountName);
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

