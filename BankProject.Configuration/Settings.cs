﻿using System;


namespace BankProject.Configuration
{
    /// <summary>
    /// Project level configuration settings
    /// </summary>
    public static class Settings
    {
        /// <summary>
        /// Customer number starts from 1001;incremented by 1
        /// </summary>
        public static long BaseCustomerNo { get; set; } = 1000;
        public static long BaseAccountNo { get; set; } = 100;
        public static long BaseFundsTransferNo { get; set; } = 10;
        public static long BaseFundsTransferStatementNo { get; set; } = 10;
        public static long BaseAccountStatementNo { get; set; } = 10;
    }
}
