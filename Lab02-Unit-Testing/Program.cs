using System;

namespace Lab02_Unit_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayAtm = true;
            while (displayAtm)
            {
                displayAtm = DisplayAtm();
            }
          
        }
        private static bool DisplayAtm()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the bank of Regan Dufort");
            Console.Write("This is an ATM where you can manage and update your account");
            Console.WriteLine("Choose an option for your bank account");
            Console.WriteLine("1) Choose to view your total balance");
            Console.WriteLine("2) Choose to add to money to your balance");
            Console.WriteLine("3) Choose to subtract money from your balance");
            Console.WriteLine("4) Choose to exit");

            string result = Console.ReadLine();

            if (result == "1")
            {
                TotalBalance();
                return true;
            }
            else if (result == "2")
            {
                addToBalance();
                return true;
           
            }
            else if (result == "3")
            {
                SubtractFromBalance();
                return true;

            }
            else
            {
                return true;
            }

        }

    }
}
