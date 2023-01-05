using System;
using System.Collections.Generic;
using BankProject.Entities;
using BankProject.Exceptions;
using BankProject.DataAccessLayer.DALContracts;

namespace BankProject.DataAccessLayer
{
    /// <summary>
    /// Represents DataAccessLayer for bank accounts of customers
    /// </summary>
    public class AccountsDataAccessLayer : IAccountsDataAccessLayer
    {

        #region Fields

        private static List<Account> _accounts;

        #endregion



        #region Constructors
        static AccountsDataAccessLayer()
        {
            _accounts = new List<Account>();
        }
        #endregion



        #region Properties
        private static List<Account> Accounts
        {
            set => _accounts = value;
            get => _accounts;
        }
        #endregion



        #region Methods

        /// <summary>
        /// Returns all existing accounts
        /// </summary>
        /// <returns></returns>
        public List<Account> GetAccounts()
        {
            try
            {

                // create a new accounts list
                List<Account> accountsList = new List<Account>();

                //copy all accounts from the source collection into the newAccounts list
                Accounts.ForEach(item => accountsList.Add(item.Clone() as Account));
                return accountsList;
            }
            catch (AccountException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// Returns list of accounts that are matching with specified criteria
        /// </summary>
        /// <param name="predicate">Lambda expression with condition</param>
        /// <returns>List of matching accounts</returns>
        public List<Account> GetAccountsByCondition(Predicate<Account> predicate)
        {
            try
            {
                // creating a new accounts list
                List<Account> accountsList = new List<Account>();

                //filter the collection
                List<Account> filteredAccounts = Accounts.FindAll(predicate);

                //copy all accounts from the source collection into the newAccounts list
                filteredAccounts.ForEach(item => accountsList.Add(item.Clone() as Account));
                return accountsList;
            }
            catch (AccountException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// Adds a new account to the existing list
        /// </summary>
        /// <param name="account">Account object to add</param>
        /// <returns>Returns Guid of newly created account</returns>
        public Guid AddAccount(Account account)
        {
            try
            {
                //generate new Guid
                account.AccountID = Guid.NewGuid();

                //add account
                Accounts.Add(account);

                return account.AccountID;
            }
            catch (AccountException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }

        }


        /// <summary>
        /// Updates an existing account's details
        /// </summary>
        /// <param name="account">Account object with updated details</param>
        /// <returns>Determines whether the account is updated or not</returns>
        public bool UpdateAccount(Account account)
        {
            try
            {

                // find existing account by AccountID
                Account existingAccount = Accounts.Find(item => item.AccountID == account.AccountID);

                //update all details of account
                if (existingAccount != null)
                {
                    existingAccount.AccountCode = account.AccountCode;
                    existingAccount.AccountName = account.AccountName;
                
                    return true;   //indicates the account is updated
                }
                else
                {
                    return false;   // indicates no object is updated
                }
            }
            catch (AccountException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Deletes an existing account based on AccountID
        /// </summary>
        /// <param name="AccountID">AccountID to delete</param>
        /// <returns>Indicates whether the account is deleted or not</returns>
        public bool DeleteAccount(Guid accountID)
        {
            try
            {
                //delete account by AccountID
                if (Accounts.RemoveAll(item => item.AccountID == accountID) > 0)
                {
                    Console.WriteLine("The account was deleted");
                    return true;   //indicates one or more accounts are deleted
                }
                else
                {
                    Console.WriteLine("The account is not deleted");
                    return false;   //indicates no account is deleted
                }
            }
            catch (AccountException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
