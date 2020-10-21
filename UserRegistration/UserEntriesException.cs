// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserEntriesException.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akshay Poriya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace UserRegistration
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class to throw custom exception for invalid user entry
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class UserEntriesException : Exception
    {
        /// <summary>
        /// variable to store type of Exception
        /// </summary>
        public readonly ExceptionType Type;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEntriesException"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        public UserEntriesException(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }

        /// <summary>
        /// Cause of exception
        /// </summary>
        public enum ExceptionType
        {
            /// <summary>
            /// for exception due to name
            /// </summary>
            NAME,

            /// <summary>
            /// for exception due to email
            /// </summary>
            EMAIL,

            /// <summary>
            /// for exception due to mobile number
            /// </summary>
            MOBILE_NUMBER,

            /// <summary>
            /// for exception due to password
            /// </summary>
            PASSWORD
        }
    }
}
