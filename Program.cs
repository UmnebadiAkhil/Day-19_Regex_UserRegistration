// See https://aka.ms/new-console-template for more information
using ReGex_UserRegistration;

Console.WriteLine("Hello, World!");

bool flag = true;
while (flag)
{
    Console.WriteLine("User Registration Validate using Regular Expression");
    Console.WriteLine("Choose Option to Execute the Regex Program: \n 1. Validate First Name, \n 2. Validate Last Name, \n 3. Email Check \n 4. Mobile Number \n 5. Password Rule=1 \n 6. Password Rule=2 \n 7. Password Rule=3 \n 8. Password Rule=4 \n 9. CheckDifferentEmailSamples \n 10. Exit");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter the First Name: ");
            string Name = Console.ReadLine();
            UC1_EnterFirstName uC1_EnterFirstName = new UC1_EnterFirstName();

            bool value1 = uC1_EnterFirstName.validateFirstName(Name);
            if (value1)
                Console.WriteLine("Valid Name");
            else
                Console.WriteLine("InValid Name");
            break;

        case 2:
            Console.WriteLine("Enter the Last Name: ");
            string Name1 = Console.ReadLine();
            UC2_EnterLastName uC2_EnterLastName = new UC2_EnterLastName();

            bool value2 = uC2_EnterLastName.validateLastName(Name1);
            if (value2)
                Console.WriteLine("Valid Name");
            else
                Console.WriteLine("InValid Name");
            break;

        case 3:
            Console.WriteLine("Enter the Email: ");
            string Name2= Console.ReadLine();
            UC3_EnterEmail uC3_EnterEmail=new UC3_EnterEmail();

            bool value3 = uC3_EnterEmail.validateEmail(Name2);
            if (value3)
                Console.WriteLine("Valid Email");
            else
                Console.WriteLine("InValid Email");
            break;
        case 4:
            Console.WriteLine("Enter the PhoneNumber: ");
            string Name3 = Console.ReadLine();
            UC4_EnterPhoneNumber uC4_EnterPhoneNumber = new UC4_EnterPhoneNumber();

            bool value4 = uC4_EnterPhoneNumber.validatePhoneNumber(Name3);
            if (value4)
                Console.WriteLine("Valid Number");
            else
                Console.WriteLine("InValid Number");
            break;

        case 5:
            Console.WriteLine("Enter the Password: ");
            string Name4 = Console.ReadLine();
            UC5_EnterPreDefinedPassword uC5_EnterPreDefinedPassword = new UC5_EnterPreDefinedPassword();

            bool value5 = uC5_EnterPreDefinedPassword.validatePassword(Name4);
            if (value5)
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("InValid Password");
            break;
        case 6:
            Console.WriteLine("Enter the Password: ");
            string Name5 = Console.ReadLine();
            UC6_Password_Rule_2 uC6_Password = new UC6_Password_Rule_2();

            bool value6 = uC6_Password.validatePassword(Name5);
            if (value6)
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("InValid Password");
            break;
        case 7:
            Console.WriteLine("Enter the Password: ");
            string Name6 = Console.ReadLine();
            UC7_Password_Rule_03 uC7_Password_Rule_03= new UC7_Password_Rule_03();

            bool value7 = uC7_Password_Rule_03.validatePassword(Name6);
            if (value7)
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("InValid Password");
            break;
        case 8:
            Console.WriteLine("Enter the Password: ");
            string Name7 = Console.ReadLine();
            UC8_Password_Rule_04 uC8_Password_Rule_04= new UC8_Password_Rule_04();

            bool value8 = uC8_Password_Rule_04.validatePassword(Name7);
            if (value8)
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("InValid Password");
            break;
        case 9:
            Console.WriteLine("Enter the Email: ");
            string Name8 = Console.ReadLine();
            UC9_CheckDifferentEmail uC9_CheckDifferentEmail= new UC9_CheckDifferentEmail();

            bool value9 = uC9_CheckDifferentEmail.validatePassword(Name8);
            if (value9)
                Console.WriteLine("Valid Email ID");
            else
                Console.WriteLine("InValid Email ID");
            break;
        case 10:
            flag = false;
            break;


    }
}