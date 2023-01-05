﻿using System;
using BankProject.Entities;
using System.Collections.Generic;


namespace BankProject.DataAccessLayer.DALContracts
{
    /// <summary>
    /// Interface that represents customers data acces layer
    /// </summary>
    public interface ICustomersDataAccessLayer
    {
        /// <summary>
        /// Returns all existing customers
        /// </summary>
        /// <returns>List of customers</returns>
        List<Customer> GetCustomers();
        /// <summary>
        /// Returns a set of customers that matches with specified criteria
        /// </summary>
        /// <param name="predicate">Lambda expression that contains conditions to check</param>
        /// <returns>The list of matching customers</returns>
        List<Customer> GetCustomersByCondition(Predicate<Customer> predicate);
        /// <summary>
        /// Adds a new customer to the existing customers list
        /// </summary>
        /// <param name="customer">The customer object to add</param>
        /// <returns>Returns true, that indicates the customer is added successfully</returns>
        Guid AddCustomer(Customer customer);
        /// <summary>
        /// Updates an existing customer
        /// </summary>
        /// <param name="customer">Customer object that contains customer details to update</param>
        /// <returns>Returns true, that indicates the customer is updated successfully</returns>

        bool UpdateCustomer(Customer customer);
        /// <summary>
        /// Delets an existing customer
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns>Returns true, that indicates the customer is deleted successfully</returns>
        bool DeleteCustomer(Guid customerID);
    }
}
