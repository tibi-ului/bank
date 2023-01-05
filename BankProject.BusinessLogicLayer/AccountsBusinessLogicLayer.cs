using System;
using System.Collections.Generic;
using BankProject.BusinessLogicLayer.BussinessLayerContracts;
using BankProject.DataAccessLayer;
using BankProject.DataAccessLayer.DALContracts;
using BankProject.Entities;
using BankProject.Exceptions;


namespace BankProject.BusinessLogicLayer
{
    /// <summary>
    /// Represents account business logic
    /// </summary>
    public class AccountsBusinessLogicLayer : IAccountsBusinessLogicLayer
    {
        #region Private Fields
        private IAccountsDataAccessLayer _accountsDataAccessLayer;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor that initializes AccountsDataAccessLayer
        /// </summary>
        public AccountsBusinessLogicLayer()
        {
            _accountsDataAccessLayer = new AccountsDataAccessLayer();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Private property that represents reference of AccountsDataAccesLayer
        /// </summary>
        private IAccountsDataAccessLayer AccountsDataAccessLayer
        {
            get => _accountsDataAccessLayer;
            set => _accountsDataAccessLayer = value;
        }

        #endregion


        #region Methods
        /// <summary>
        /// Returns all existing Accounts
        /// </summary>
        /// <returns>List of Accounts</returns>
        public List<Account> GetAccounts()
        {
            try
            {
                //invoke DAL
                return AccountsDataAccessLayer.GetAccounts();
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
        /// Returns a set of Accounts that matches with specified criteria
        /// </summary>
        /// <param name="predicate">Lambda expression that contains condition to check</param>
        /// <returns>The list of matching Accounts</returns>

        public List<Account> GetAccountsByCondition(Predicate<Account> predicate)
        {
            try
            {
                //invoke DAL
                return AccountsDataAccessLayer.GetAccountsByCondition(predicate);
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

        public Guid AddAccount(Account account)
        {
            try
            {
                //get all Accounts
                List<Account> allAccounts = AccountsDataAccessLayer.GetAccounts();
                long maxAccountCode = 0;
                foreach (var item in allAccounts)
                {
                    if (item.AccountCode > maxAccountCode)
                    {
                        maxAccountCode = item.AccountCode;
                    }
                }
                //generate new account number
                if (allAccounts.Count >= 1)
                {
                    account.AccountCode = maxAccountCode + 10;
                }
                else
                {
                    account.AccountCode = BankProject.Configuration.Settings.BaseAccountNo + 10;
                }
                //invoke DAL
                return AccountsDataAccessLayer.AddAccount(account);
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
        /// Updates an existing account
        /// </summary>
        /// <param name="account">Customer object that contains account details to update</param>
        /// <returns>Returns true, that indicates the account is updated successfully</returns>
        public bool UpdateAccount(Account account)
        {
            try
            {

                //invoke DAL
                return AccountsDataAccessLayer.UpdateAccount(account);
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
        /// Deletes an existing account
        /// </summary>
        /// <param name="accountID">AccountID to delete</param>
        /// <returns>Returns true, that indicates the account is deleted successfully</returns>
        public bool DeleteAccount(Guid accountID)
        {
            try
            {

                //invoke DAL
                return AccountsDataAccessLayer.DeleteAccount(accountID);
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
