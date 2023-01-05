using System;
using System.Collections.Generic;
using BankProject.Entities;


namespace BankProject.BusinessLogicLayer.BussinessLayerContracts
{
    /// <summary>
    /// Interface that represents customers business logic
    /// </summary>
    public interface ICustomersBusinessLogicLayer
    {
      
        List<Customer> GetCustomers();
       
        List<Customer> GetCustomersByCondition(Predicate<Customer> predicate);
     
        Guid AddCustomer(Customer customer);
     

        bool UpdateCustomer(Customer customer);
      
        bool DeleteCustomer(Guid customerID);

        
    }
}
