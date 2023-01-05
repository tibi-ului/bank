using System;
using System.Collections.Generic;
using BankProject.Entities;


namespace BankProject.BusinessLogicLayer.BussinessLayerContracts
{
    /// <summary>
    /// Interface that represents accounts business logic
    /// </summary>
    public interface IAccountsBusinessLogicLayer
    {

        List<Account> GetAccounts();

        List<Account> GetAccountsByCondition(Predicate<Account> predicate);

        Guid AddAccount(Account account);


        bool UpdateAccount(Account account);

        bool DeleteAccount(Guid accountID);
    }
}
