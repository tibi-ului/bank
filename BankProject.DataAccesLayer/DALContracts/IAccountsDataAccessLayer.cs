using System;
using BankProject.Entities;
using System.Collections.Generic;


namespace BankProject.DataAccessLayer.DALContracts
{
    /// <summary>
    /// Interface that represents accounts data acces layer
    /// </summary>
    public interface IAccountsDataAccessLayer
    {
        /// <summary>
        /// Returns all existing accounts
        /// </summary>
        /// <returns>List of accounts</returns>
        List<Account> GetAccounts();



        /// <summary>
        /// Returns a set of accounts that matches with specified criteria
        /// </summary>
        /// <param name="predicate">Lambda expression that contains conditions to check</param>
        /// <returns>The list of matching accounts</returns>
        List<Account> GetAccountsByCondition(Predicate<Account> predicate);



        /// <summary>
        /// Adds a new account to the existing accounts list
        /// </summary>
        /// <param name="account">The account object to add</param>
        /// <returns>Returns true, that indicates the account is added successfully</returns>
        Guid AddAccount(Account account);



        /// <summary>
        /// Updates an existing account
        /// </summary>
        /// <param name="account">Account object that contains account details to update</param>
        /// <returns>Returns true, that indicates the account is updated successfully</returns>

        bool UpdateAccount(Account account);



        /// <summary>
        /// Deletes an existing account
        /// </summary>
        /// <param name="accountID"></param>
        /// <returns>Returns true, that indicates the account is deleted successfully</returns>
        bool DeleteAccount(Guid accountID);
    }
}
