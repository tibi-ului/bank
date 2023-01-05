﻿using System;


namespace BankProject.Exceptions
{
    /// <summary>
    /// Exception class that represents error raised in account class
    /// </summary>
    public class AccountException : ApplicationException
    {
        /// <summary>
        /// Constructor that initializes exception message
        /// </summary>
        /// <param name="message">Exception message</param>
        public AccountException(string message) : base(message)
        {

        }
        /// <summary>
        /// Constructor that initializes exception message and inner exception
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception</param>
        public AccountException(string message, Exception innerException) : base(message, innerException)
        {

        }

    }
}
