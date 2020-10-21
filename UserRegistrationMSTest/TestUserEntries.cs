// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestUserEntries.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akshay Poriya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace UserRegistrationMSTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using UserRegistration;

    /// <summary>
    /// Unit test class for various UserEntries functions
    /// </summary>
    [TestClass]
    public class TestUserEntries
    {
        /// <summary>
        /// Tests the IsValidName function.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="expected">if set to <c>true</c> [expected].</param>
        [TestMethod]
        [DataRow("Akshay", true)]
        [DataRow("akshay", false)]
        [DataRow("Aks1hay", false)]
        [DataRow("Poriya", true)]
        [DataRow("Ak", false)]
        [DataRow("1AksHay", false)]
        public void TestIsValidName(string name, bool expected)
        {
            try
            {
                //// Arrange
                //// Act
                bool actual = UserEntries.IsValidName(name);
                //// Assert
                Assert.AreEqual(expected, actual);
            }
            catch (UserEntriesException ex)
            {
                string actualMessage = ex.Message;
                string expectedMessage = "Enter Valid Name!";
                //// Assert
                Assert.AreEqual(expectedMessage, actualMessage);
            }
        }

        /// <summary>
        /// Tests the IsValidEmailFunction.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="expected">if set to <c>true</c> [expected].</param>
        [TestMethod]
        [DataRow("abc@yahoo.com", true)]
        [DataRow("abc-100@yahoo.com", true)]
        [DataRow("abc.100@yahoo.com", true)]
        [DataRow("abc111@abc.com", true)]
        [DataRow("abc-100@abc.net", true)]
        [DataRow("abc.100@abc.com.au", true)]
        [DataRow("abc@1.com", true)]
        [DataRow("abc@gmail.com.com", true)]
        [DataRow("abc+100@gmail.com", true)]
        [DataRow("abc", false)]
        [DataRow("abc@.com.my", false)]
        [DataRow("abc123@gmail.a", false)]
        [DataRow("abc123@.com", false)]
        [DataRow("abc123@.com.com", false)]
        [DataRow(".abc@abc.com", false)]
        [DataRow("abc()*@gmail.com", false)]
        [DataRow("abc@%*.com", false)]
        [DataRow("abc..2002@gmail.com", false)]
        [DataRow("abc.@gmail.com", false)]
        [DataRow("abc@abc@gmail.com", false)]
        [DataRow("abc@gmail.com.1a", false)]
        [DataRow("abc@gmail.com.aa.au", false)]
        public void TestIsValidEmail(string email, bool expected)
        {
            try
            {
                //// Arrange
                //// Act
                bool actual = UserEntries.IsValidEmail(email);
                //// Assert
                Assert.AreEqual(expected, actual);
            }
            catch (UserEntriesException ex)
            {
                string actualMessage = ex.Message;
                string expectedMessage = "Enter Valid Email!";
                //// Assert
                Assert.AreEqual(expectedMessage, actualMessage);
            }
        }

        /// <summary>
        /// Tests the IsValidMobileNumber function.
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <param name="expected">if set to <c>true</c> [expected].</param>
        [TestMethod]
        [DataRow("91 1234567890", true)]
        [DataRow("91-0123456789", false)]
        [DataRow("91 12897456871", false)]
        [DataRow("67 1000000000", true)]
        [DataRow("9876543210", false)]
        [DataRow("123 9874568584", false)]
        public void TestIsValidMobileNumber(string mobileNumber, bool expected)
        {
            try
            {
                //// Arrange
                //// Act
                bool actual = UserEntries.IsValidMobileNumber(mobileNumber);
                //// Assert
                Assert.AreEqual(expected, actual);
            }
            catch (UserEntriesException ex)
            {
                string actualMessage = ex.Message;
                string expectedMessage = "Enter Valid Mobile Number!";
                //// Assert
                Assert.AreEqual(expectedMessage, actualMessage);
            }
        }
    }
}
