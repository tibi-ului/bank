using System;
using BankProject.Presentation;
class Program
{
    

    static void Main()
    {
        Console.WriteLine("************FriendlyBank************");
        Console.WriteLine("Login Page");

        //declare variables to store username and password
        string userName = null, password = null;

        //read username from keyboard
        Console.Write("Username: ");
        userName = Console.ReadLine();

        //read password from keyboard only if username is entered
        if (userName !="")
        {
            Console.Write("Password: ");
            password = Console.ReadLine();
        }

        //check username and password
        if (userName == "system" && password == "manager")
        {
            //declare variable to store menu choice
            int mainMenuChoice = -1;
            do
            {
                //show main menu
                Console.WriteLine("\nMain menu");
                Console.WriteLine("1.Customers");
                Console.WriteLine("2.Accounts");
                Console.WriteLine("3.Funds Transfer");
                Console.WriteLine("4.Funds Transfer Statement");
                Console.WriteLine("5.Account Statement");
                Console.WriteLine("0.Exit");

                Console.WriteLine("Enter Choice");
                mainMenuChoice = int.Parse(Console.ReadLine());

                
                switch (mainMenuChoice)
                {
                    case 1:
                        CustomersMenu();
                        break;
                    case 2: 
                        AccountsMenu();
                        break;
                    case 3:
                        //to do: display funds transfer menu
                        FundsTransfersMenu();
                        break;
                    case 4:
                        //to do: display funds transfer statement menu
                        FundsTransferStatementsMenu();
                        break;
                    case 5:
                        //to do: display account statement menu
                        AccountStatementsMenu();
                        break;

                }
            }
                while (mainMenuChoice != 0) ;
        }
        else
        {
            Console.WriteLine("Invalid username or password");

        }


        Console.WriteLine("Thank you!");
        Console.ReadKey();



    }

    static void CustomersMenu()
    {
        int customerMenuChoice = -1;

        do
        {
            Console.WriteLine("\n---Customer Menu---");
            Console.WriteLine("1.Add Customer");
            Console.WriteLine("2.Delete Customer");
            Console.WriteLine("3.Update Customer");
            Console.WriteLine("4.Search Customer");
            Console.WriteLine("5.View Customer");
            Console.WriteLine("0.Back to Main Menu");

            //accept customers menu choice
            Console.WriteLine("Enter Choice");
            customerMenuChoice = int.Parse(Console.ReadLine());

            //switch case
            switch (customerMenuChoice)
            {
                case 1: CustomersPresentation.AddCustomer(); break;                   
                case 2: CustomersPresentation.DeleteCustomer(); break;
                case 3: CustomersPresentation.UpdateCustomer(); break;
                case 5: CustomersPresentation.ViewCustomers(); break;
            }

        } while (customerMenuChoice != 0);

    }

    static void AccountsMenu()
    {
        int accountMenuChoice = -1;

        do
        {
            Console.WriteLine("Accounts Menu");
            Console.WriteLine("1.Add Account");
            Console.WriteLine("2.Delete Account");
            Console.WriteLine("3.Update Account");
            Console.WriteLine("4.View Account");
            Console.WriteLine("0.Back to Main Menu");

            Console.WriteLine("Enter Choice");
            accountMenuChoice = int.Parse(Console.ReadLine());

            //switch case
            switch (accountMenuChoice)
            {
                case 1: AccountsPresentation.AddAccount(); break;
                //case 2: AccountsPresentation.DeleteAccount(); break;
               // case 3: AccountsPresentation.UpdateAccount(); break;
                case 4: AccountsPresentation.ViewAccounts(); break;
            }
        } while (accountMenuChoice != 0);
    }


    static void FundsTransfersMenu()
    {
        int fundsTransferMenuChoice = -1;

        do
        {
            Console.WriteLine("FundsTransfer Menu");
            Console.WriteLine("1.Add FundsTransfer");
            Console.WriteLine("2.Delete FundsTransfer");
            Console.WriteLine("3.Update FundsTransfer");
            Console.WriteLine("4.View FundsTransfer");
            Console.WriteLine("0.Back to Main Menu");

            Console.WriteLine("Enter Choice");
            fundsTransferMenuChoice = int.Parse(Console.ReadLine());

            //switch case
            switch (fundsTransferMenuChoice)
            {
                case 1: FundsTransfersPresentation.AddFundsTransfer(); break;
                case 4: FundsTransfersPresentation.ViewFundsTransfers(); break;
            }
        } while (fundsTransferMenuChoice != 0);
    }


    static void FundsTransferStatementsMenu()
    {
        int fundsTransferStatementMenuChoice = -1;

        do
        {
            Console.WriteLine("FundsTransferStatement Menu");
            Console.WriteLine("1.Add FundsTransferStatement");
            Console.WriteLine("2.Delete FundsTransferStatement");
            Console.WriteLine("3.Update FundsTransferStatement");
            Console.WriteLine("4.View FundsTransferStatement");
            Console.WriteLine("0.Back to Main Menu");

            Console.WriteLine("Enter Choice");
            fundsTransferStatementMenuChoice = int.Parse(Console.ReadLine());
        } while (fundsTransferStatementMenuChoice != 0);
    }


    static void AccountStatementsMenu()
    {
        int accountStatementMenuChoice = -1;

        do
        {
            Console.WriteLine("AccountStatement Menu");
            Console.WriteLine("1.Add AccountStatement");
            Console.WriteLine("2.Delete AccountStatement");
            Console.WriteLine("3.Update AccountStatement");
            Console.WriteLine("4.View AccountStatement");
            Console.WriteLine("0.Back to Main Menu");

            Console.WriteLine("Enter Choice");
            accountStatementMenuChoice = int.Parse(Console.ReadLine());
        } while (accountStatementMenuChoice != 0);
    }
}