using System;
using BankProject.Entities.Contracts;
using BankProject.Exceptions;


namespace BankProject.Entities
{
    /// <summary>
    /// Represents account of the customer bank
    /// </summary>
    public class Account: IAccount, ICloneable
    {
        
        #region Private fields
        private Guid _accountID;
        private long _accountCode;
        private string _accountName;
      
        #endregion


        #region Public Properties
        /// <summary>
        /// Guid of account for unique identification
        /// </summary>
        public Guid AccountID { get => _accountID; set => _accountID = value; }
        /// <summary>
        /// auto-generated code number of the account
        /// </summary>
        public long AccountCode { 
            get => _accountCode;
            set
            {
                if (value > 0)
                {
                    _accountCode = value;
                }
                else
                {
                    throw new AccountException("Account code should be positive only");
                }
            }
        }

        public string AccountName { 
            get => _accountName;
            set {
                //account name should be less than 20 characters
                if (value.Length <= 20 && string.IsNullOrEmpty(value) == false)
                {
                    _accountName = value;
                }
                else
                {
                    throw new AccountException("Account Name should not be null and less than 20 characters long");
                }
            } 
        }

  
        #endregion


        #region Methods
        public object Clone()
        {
            return new Account() { 
                AccountID = this.AccountID,
                AccountCode = this.AccountCode,
                AccountName = this.AccountName, 
              
            };
        }

        #endregion
    }
}
