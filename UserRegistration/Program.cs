// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akshay Poriya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace UserRegistration
{
    using System;

    /// <summary>
    /// This class contains main function and UserInput function
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            UserInput();
        }

        /// <summary>
        /// This function is used to take input from user for validation.
        /// works as an UI for our application
        /// </summary>
        private static void UserInput()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. Validate First Name \n2. Validate Last Name\n3. Validate Email " +
                                    "\n4. Validate Mobile Number \n5. Validate Password \n6. Exit");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter First Name");
                        string firstName = Console.ReadLine();
                        try
                        {
                            Console.WriteLine("{0}", UserEntries.IsValidName(firstName) ? "Valid" : "Invalid"); // Ternary operator
                        }
                        catch (UserEntriesException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;
                    case "2":
                        Console.WriteLine("Enter Last Name");
                        string lastName = Console.ReadLine();
                        try
                        {
                            Console.WriteLine("{0}", UserEntries.IsValidName(lastName) ? "Valid" : "Invalid"); // Ternary operator
                        }
                        catch (UserEntriesException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;
                    case "3":
                        Console.WriteLine("Enter Email");
                        string email = Console.ReadLine();
                        try
                        {
                            Console.WriteLine("{0}", UserEntries.IsValidEmail(email) ? "Valid" : "Invalid"); // Ternary operator
                        }
                        catch (UserEntriesException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;
                    case "4":
                        Console.WriteLine("Enter Mobile Number");
                        string mobileNumber = Console.ReadLine();
                        try
                        {
                            Console.WriteLine("{0}", UserEntries.IsValidMobileNumber(mobileNumber) ? "Valid" : "Invalid"); // Ternary operator
                        }
                        catch (UserEntriesException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;
                    case "5":
                        Console.WriteLine("Enter Password");
                        string password = Console.ReadLine();
                        try
                        {
                            Console.WriteLine("{0}", UserEntries.IsValidPassword(password) ? "Valid" : "Invalid"); // Ternary operator
                        }
                        catch (UserEntriesException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;
                    default:
                        flag = false; // To break loop
                        break;
                }
            }
        }
    }
}
