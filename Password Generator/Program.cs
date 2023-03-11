using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChatGPTAPIExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to password generator");

            Console.WriteLine("Enter password length");
            int passWordLength = int.Parse(Console.ReadLine());

            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+";

            Random random = new Random();
            string password = "";

            for(int i = 0; i <passWordLength; i++)
            {
                int index = random.Next(chars.Length);
                password += chars[index];
            }


            Console.WriteLine("Your password is: " + password);

        }

    }
}