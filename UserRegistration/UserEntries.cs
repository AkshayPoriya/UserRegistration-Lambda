// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserEntries.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akshay Poriya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace UserRegistration
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// This class stores various functions to validate user entries
    /// </summary>
    public class UserEntries
    {
        /// <summary>
        /// Determines whether [is valid name] [the specified first name].
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if [is valid name] [the specified first name]; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="UserRegistration.UserEntriesException">Enter Valid Name!</exception>
        public static Func<string, bool> IsValidName = firstName =>
        {
            string namePattern = @"^[A-Z][a-z][a-z]+$"; // Pattern for Capital letter followed by small letters, min length 3
            Regex regex = new Regex(namePattern);
            if (regex.IsMatch(firstName))
            {
                return true;
            }

            throw new UserEntriesException(UserEntriesException.ExceptionType.NAME, "Enter Valid Name!");
        };

        /// <summary>
        /// Determines whether [is valid email] [the specified email].
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        ///   <c>true</c> if [is valid email] [the specified email]; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="UserRegistration.UserEntriesException">Enter Valid Email!</exception>
        public static Func<string, bool> IsValidEmail = email =>
        {
            string emailPattern = @"^[a-zA-Z0-9]+([.+-]{1}[A-Za-z0-9]+)*[@][a-zA-Z0-9]+([.]{1}([a-zA-Z]{2}|[a-zA-Z]{3,})){0,2}$";
            Regex regex = new Regex(emailPattern);
            if (regex.IsMatch(email))
            {
                return true;
            }

            throw new UserEntriesException(UserEntriesException.ExceptionType.EMAIL, "Enter Valid Email!");
        };

        /// <summary>
        /// Determines whether [is valid mobile number] [the specified mobile number].
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <returns>
        ///   <c>true</c> if [is valid mobile number] [the specified mobile number]; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="UserRegistration.UserEntriesException">Enter Valid Mobile Number!</exception>
        public static Func<string, bool> IsValidMobileNumber = mobileNumber =>
        {
            string mobileNumberPattern = @"^[1-9][0-9][ ][1-9][0-9]{9}$";
            Regex regex = new Regex(mobileNumberPattern);
            if (regex.IsMatch(mobileNumber))
            {
                return true;
            }

            throw new UserEntriesException(UserEntriesException.ExceptionType.MOBILE_NUMBER, "Enter Valid Mobile Number!");
        };

        /// <summary>
        /// Determines whether [is valid password] [the specified password].
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns>
        ///   <c>true</c> if [is valid password] [the specified password]; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="UserRegistration.UserEntriesException">Enter Valid Password!</exception>
        public static Func<string, bool> IsValidPassword = password =>
        {
        // ?= is used for assertion, we want minimum one Capital letter and one small letter
        // .*[A-Z] means there must be one Capital letter in front of which there can be any number of characters
        // . stand for any character and * stand for 0 or more occurence
        string passwordPattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[a-z])(?=.*[@#$%_])(?!.*[@#$%_].*[@#$%_]).{8,20}$";
            Regex regex = new Regex(passwordPattern);
            if (regex.IsMatch(password))
            {
                return true;
            }

            throw new UserEntriesException(UserEntriesException.ExceptionType.PASSWORD, "Enter Valid Password!");
        };
    }
}
