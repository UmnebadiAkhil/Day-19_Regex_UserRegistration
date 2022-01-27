using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReGex_UserRegistration;
using System;

namespace UserRegistration_Test
{
    [TestClass]
    public class UnitTest1
    {
        //UC-1 As a User need to enter a valid First name
        [TestMethod]
        public void ValidateFirstName_LengthGreaterThenThree()
        {
           UC1_EnterFirstName uC1_EnterFirstName = new UC1_EnterFirstName();

            string Name = "Ram";
            int expectedNameLength = 3;

            int actual = uC1_EnterFirstName.ValidateFirstName(Name);

            Assert.AreEqual(expectedNameLength, actual);
        }

        //UC-2 As a User need to enter a valid Last name
        [TestMethod]
        public void ValidateLastName_LengthGreaterThenThree()
        {
            UC2_EnterLastName uc2_EnterLastName = new UC2_EnterLastName();

            string Name = "Ram";
            int expectedNameLength = 3;

            int actual = uc2_EnterLastName.ValidateLastName(Name);

            Assert.AreEqual(expectedNameLength, actual);
        }
            
        //UC-3 As a User need to enter a valid email
         [TestMethod]
        public void ValidateEmail_ProperOrder()
        {
            UC3_EnterEmail uC3_EnterEmail = new UC3_EnterEmail();

            string email = "abc5024@gmail.com";
            string Regex_Pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(email, Regex_Pattern));
        }

        //UC-4 As a User need to follow pre-defined Mobile Format
        [TestMethod]
        public void ValidatePhoneNumber_InProperOrder()
        {
            UC4_EnterPhoneNumber uC4_EnterPhoneNumber = new UC4_EnterPhoneNumber();

            string number = "+918904839805";
            string Regex_Pattern = "^[/+]{1}(91)[7-9]{1}[0-9]{9}$";

            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(number, Regex_Pattern));
        }

        //UC-5 As a User need to  follow pre-definedPassword rules.Rule1 – minimum 8 Characters
        [TestMethod]
        public void ValidatePassword_InProperOrder()
        {
            UC5_EnterPreDefinedPassword uC5_EnterPreDefinedPassword = new UC5_EnterPreDefinedPassword();

            string password = "Aqws123sAa";
            string Regex_Pattern = @"[a-z,A-Z,0-9]{8,}$";

            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(password, Regex_Pattern));
        }

        //UC-6 As a User need to  follow pre-definedPassword rules.Rule2 Should have at least 1 Upper Case - NOTE – All rules must be
        [TestMethod]
        public void ValidatePassword_Rule2()
        {
            UC6_Password_Rule_2 uC6_Password_Rule_2 = new UC6_Password_Rule_2();

            string password = "Aqws123sA@a";
            string Regex_Pattern = "^.*(?=.{8,})(?=.*[a-z])(?=.*[A-Z]).*$";

            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(password, Regex_Pattern));
        }

        //UC-7 As a User need to  follow pre-definedPassword rules.Rule2 Should have at least 1 Upper Case - NOTE – All rules must be
        [TestMethod]
        public void ValidatePassword_Rule3()
        {
            UC7_Password_Rule_03 uC7_Password_Rule_03 = new UC7_Password_Rule_03();

            string password = "Aqws123sAa";
            string Regex_Pattern = "^.*(?=.{8,})(?=.*[a-z])(?=.*[A-Z]).*$";

            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(password, Regex_Pattern));
        }

        //UC-8 As a User need to  follow pre-definedPassword rules.Rule2 Should have at least 1 Upper Case and 1 special charcacter - NOTE – All rules must be
        [TestMethod]
        public void ValidatePassword_Rule4()
        {
            UC8_Password_Rule_04 uC8_Password_Rule_04 = new ReGex_UserRegistration.UC8_Password_Rule_04();

            string password = "Aqws123sA@a";
            string Regex_Pattern = "^.*(?=.{8,})(?=.*[a-z])(?=.*[A-Z]).*$";

            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(password, Regex_Pattern));
        }

        //UC-9 Should clear all email samples provided separately
        [TestMethod]
        public void ValidatePassword_CheckDifferentEmail()
        {
            UC9_CheckDifferentEmail uC9_CheckDifferentEmail = new UC9_CheckDifferentEmail();

            string password1 = "abc@yahoo.com";
            string password2 = "abc-100@yahoo.com";
            string password3 = "abc.100@yahoo.com";
            string password4 = "abc111@abc.com";
            string password5 = "abc-100@abc.com";
            string password6 = "abc.100@abc.com";
            string password7 = "abc@1.com";
            string password8 = "abc+100@gmail.com";

            string Regex_Pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(password1, Regex_Pattern));
            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(password2, Regex_Pattern));
            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(password3, Regex_Pattern));
            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(password4, Regex_Pattern));
            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(password5, Regex_Pattern));
            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(password6, Regex_Pattern));
            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(password7, Regex_Pattern));
            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(password8, Regex_Pattern));

        }
    }
}