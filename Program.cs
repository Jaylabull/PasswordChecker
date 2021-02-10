using System;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password Checker!");

            //SETUP STANDARDS
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "~!@#$%^&*";

            Console.WriteLine("Enter a password: ");
            string userPassword = Console.ReadLine();

            //TESTING PASSWORD
            int score = 0;

            if (userPassword.Length >= minLength) 
            {
                score++;
            }
            if (Tools.Contains(userPassword, uppercase))
            {
                score++;
            }
            if (Tools.Contains(userPassword, lowercase))
            {
                score++;
            }
            if (Tools.Contains(userPassword, digits))
            {
                score++;
            }
            if (Tools.Contains(userPassword, specialChars))
            {
                score++;
            }
            if (userPassword == "password" || userPassword == "1234")
            {
                score = 0;
            }

            //TELL USER PASSWORD STRENGTH
            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("Extremly strong password.");
                    break;
                case 3:
                    Console.WriteLine("Password is strong.");
                    break;
                case 2:
                    Console.WriteLine("Password is medium.");
                    break;
                case 1:
                    Console.WriteLine("Password is weak.");
                    break;
                default:
                    Console.WriteLine("Password does not meet standards. Please enter new password.");
                    break;
                
            }
          
        }
       
    }
}
