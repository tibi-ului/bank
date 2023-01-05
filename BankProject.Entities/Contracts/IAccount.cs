using System;

namespace BankProject.Entities.Contracts
{
    /// <summary>
    /// Represents interface of account entity
    /// </summary>
    public interface IAccount
    {
        Guid AccountID { get; set; }
        long AccountCode { get; set; }
        string AccountName { get; set; }

    }
}
