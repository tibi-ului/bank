using BankProject.Entities.Contracts;
using BankProject.Exceptions;
using System;
using System.Runtime.Remoting.Messaging;

namespace BankProject.Entities
{
    public class FundsTransfer: IFundsTransfer, ICloneable
    {
        private Guid _fundsTransferID;
        private long _fundsTransferCode;
        private string _fundsTransferName;


        public Guid FundsTransferID { get => _fundsTransferID; set => _fundsTransferID = value; }
        public long FundsTransferCode { 
            get => _fundsTransferCode; 
            set
            {
                if (value > 0)
                {
                    _fundsTransferCode = value;
                }
                else
                {
                    throw new AccountException("FundsTransferCode code should be positive only");
                }
            }
        }
        public string FundsTransferName { 
            get => _fundsTransferName;
            set
            {
                //FundsTransfer name should be less than 20 characters
                if (value.Length <= 20 && string.IsNullOrEmpty(value) == false)
                {
                    _fundsTransferName = value;
                }
                else
                {
                    throw new AccountException("FundsTransfer Name should not be null and less than 20 characters long");
                }
            }
        }


        public object Clone()
        {
            return new FundsTransfer()
            {
                FundsTransferID = FundsTransferID,
                FundsTransferCode = FundsTransferCode,
                FundsTransferName = FundsTransferName,
            };
        }
    }
}
