using System;
using System.Collections.Generic;
using BankProject.Entities;
using BankProject.Exceptions;
using BankProject.BusinessLogicLayer;
using BankProject.BusinessLogicLayer.BussinessLayerContracts;
using BankProject.Entities.Contracts;

namespace BankProject.Presentation
{
    static class CustomersPresentation
    {
        internal static void AddCustomer()
        {
            try
            {
                //create an object of Customer
                Customer customer = new Customer();

                //read all details from the user
                Console.WriteLine("\n---Add Customer---");
                Console.Write("Customer Name: ");
                customer.CustomerName = Console.ReadLine();

                Console.Write("Customer Address: ");
                customer.Address = Console.ReadLine();

                Console.Write("Customer Landmark: ");
                customer.Landmark = Console.ReadLine();

                Console.Write("Customer City: ");
                customer.City = Console.ReadLine();

                Console.Write("Customer Country: ");
                customer.Country = Console.ReadLine();

                Console.Write("Customer Mobile: ");
                customer.Mobile = Console.ReadLine();

                //create bl object
                ICustomersBusinessLogicLayer customersBusinessLogicLayer = new CustomersBusinessLogicLayer();
                Guid newGuid = customersBusinessLogicLayer.AddCustomer(customer);

                List<Customer>matchingCustomers = customersBusinessLogicLayer.GetCustomersByCondition(item => item.CustomerID == newGuid);
                if(matchingCustomers.Count >= 1)
                {
                    Console.WriteLine("New Customer Code:" + matchingCustomers[0].CustomerCode);
                    Console.WriteLine("Customer Added.\n");

                }
                else
                {
                    Console.WriteLine("Customer Not added");
                }
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
        }

        //internal static void UpdateCustomer()
        //{
        //    try
        //    {

        //        ICustomersBusinessLogicLayer customersBusinessLogicLayer = new CustomersBusinessLogicLayer();

        //        Customer customer = new Customer();

                
        //        Console.WriteLine("\n---Update Customer---");
        //        Console.WriteLine("Enter the customer code: ");
        //        int updatedCustomerCode = int.Parse(Console.ReadLine());


        //        Console.Write("Customer Name: ");
        //        customer.CustomerName = Console.ReadLine();

        //        Console.Write("Customer Address: ");
        //        customer.Address = Console.ReadLine();

        //        Console.Write("Customer Landmark: ");
        //        customer.Landmark = Console.ReadLine();

        //        Console.Write("Customer City: ");
        //        customer.City = Console.ReadLine();

        //        Console.Write("Customer Country: ");
        //        customer.Country = Console.ReadLine();

        //        Console.Write("Customer Mobile: ");
        //        customer.Mobile = Console.ReadLine();

                

        //        Console.WriteLine("Customer Code:" + customer.CustomerCode);
        //        Console.WriteLine("Customer Name:" + customer.CustomerName);
        //        Console.WriteLine("Address :" + customer.Address);
        //        Console.WriteLine("Landmark :" + customer.Landmark);
        //        Console.WriteLine("City :" + customer.City);
        //        Console.WriteLine("Country :" + customer.Country);
        //        Console.WriteLine("Mobile :" + customer.Mobile);
        //        Console.WriteLine();


        //        List<Customer> updatedCustomer = customersBusinessLogicLayer.GetCustomersByCondition(item => item.CustomerCode == updatedCustomerCode);

        //        if (updatedCustomer != null)
        //        {
        //            customersBusinessLogicLayer.UpdateCustomer(updatedCustomer.CustomerID);
        //            Console.WriteLine("Customer Updated.\n");

        //        }
        //        else
        //        {
        //            Console.WriteLine("Customer Not updated");
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine(ex.GetType());
        //    }
        //}



        internal static void UpdateCustomer()
        {
            try
            {

                ICustomersBusinessLogicLayer customersBusinessLogicLayer = new CustomersBusinessLogicLayer();

                Console.WriteLine("\n---Update Customer---");
                Console.WriteLine("Enter the customer code: ");
                int updatedCustomerCode = int.Parse(Console.ReadLine());

              

                List<Customer> updatedCustomer = customersBusinessLogicLayer.GetCustomersByCondition(item => item.CustomerCode == updatedCustomerCode);

                Console.Write("Customer Name: ");
                updatedCustomer[0].CustomerName = Console.ReadLine();

                Console.Write("Customer Address: ");
                updatedCustomer[0].Address = Console.ReadLine();

                Console.Write("Customer Landmark: ");
                updatedCustomer[0].Landmark = Console.ReadLine();

                Console.Write("Customer City: ");
                updatedCustomer[0].City = Console.ReadLine();

                Console.Write("Customer Country: ");
                updatedCustomer[0].Country = Console.ReadLine();

                Console.Write("Customer Mobile: ");
                updatedCustomer[0].Mobile = Console.ReadLine();

                if (updatedCustomer != null)
                {
                    customersBusinessLogicLayer.UpdateCustomer(updatedCustomer[0]);
                    Console.WriteLine("Customer Updated.\n");

                }
                else
                {
                    Console.WriteLine("Customer Not updated");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
        }


        internal static void ViewCustomers()
        {
            try
            {
                //create bl object
                ICustomersBusinessLogicLayer customersBusinessLogicLayer = new CustomersBusinessLogicLayer();

                List<Customer> allCustomers = customersBusinessLogicLayer.GetCustomers();
                Console.WriteLine("\n---ALL CUSTOMERS---");

                //read all customers

                foreach (var item in allCustomers)
                {
                    Console.WriteLine("Customer ID:" + item.CustomerID);
                    Console.WriteLine("Customer Code:" + item.CustomerCode);
                    Console.WriteLine("Customer Name:" + item.CustomerName);
                    Console.WriteLine("Address :" + item.Address);
                    Console.WriteLine("Landmark :" + item.Landmark);
                    Console.WriteLine("City :" + item.City);
                    Console.WriteLine("Country :" + item.Country);
                    Console.WriteLine("Mobile :" + item.Mobile);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
        }

        //internal static void DeleteCustomer()
        //{
        //    try
        //    {
        //        Console.WriteLine("Enter customer code: ");
        //        int deletedCustomerCode = int.Parse(Console.ReadLine());


        //        //create bl object
        //        ICustomersBusinessLogicLayer customersBusinessLogicLayer = new CustomersBusinessLogicLayer();

        //        List<Customer> deletedCustomer = customersBusinessLogicLayer.GetCustomersByCondition(item => item.CustomerCode == deletedCustomerCode);

        //        customersBusinessLogicLayer.DeleteCustomer(deletedCustomer[0].CustomerID);

        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine(ex.GetType());
        //    }


        //}


        internal static void DeleteCustomer()
        {
            try
            {
                Console.WriteLine("Enter customer ID: ");
                Guid deletedCustomerID = Guid.Parse(Console.ReadLine());


                //create bl object
                ICustomersBusinessLogicLayer deletedCustomer = new CustomersBusinessLogicLayer();
                deletedCustomer.DeleteCustomer(deletedCustomerID);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }

        }
    }
}

