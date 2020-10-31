using Bank_Encapsulation;
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Bank_Account_Software
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Alabama National Bank! My name is Ann-puter.. get it?... eh, most don't. \n What is Your last name?");

            string lastname = Console.ReadLine();
            

            Console.WriteLine("And Your gender?");
            string gender = Console.ReadLine().ToLower();


            if (gender == "male")
            {
                gender = "Mr.";

            }

            else if (gender == "female ")
            {
                gender = "Mrs. ";

            }





            Console.WriteLine($"A pleasure to meet Your Aquaintence {gender}{lastname}" );


            Console.WriteLine($"What would You like to do today {gender}{lastname} ?You can check Your current balance, deposit or withdraw. Just type in the singular action You would like to conduct.");

            bool conditional = true;
            string userinput = Console.ReadLine().ToLower();


            if (userinput == "balance" )
            {
                Console.WriteLine($"Alrighty {gender}{lastname}, Your current balance is... ");
                double useramount = new BankAccount().GetBalance();
                Console.WriteLine($"${useramount} dollars.");
            }


            else if (userinput == "deposit")
            {
                Console.WriteLine($"Alright {gender}{lastname}, How much would You Like to add to Your Account?");

                string amounttodeposit = Console.ReadLine();
                double convertedamount = Double.Parse(amounttodeposit);
                
                double ndeposit = new BankAccount().Deposit(convertedamount);
                Console.WriteLine($"Alrighty then, So Your account now has ${ndeposit} dollars inside of it.");



            }

            else
            {
                Console.WriteLine("what?");
                conditional = false;

            }



        }


       
           

           
            

        
            

        }


    }

