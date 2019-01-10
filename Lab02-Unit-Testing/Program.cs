using System;

namespace Lab02_Unit_Testing
{
    public class Program
    {


        public static void Main(string[] args)
        {
            uint balance = 5000;

            bool menu = true;
            while (menu)
            {

               
                Console.WriteLine("Welcome to the bank of Regan Dufort");
                Console.WriteLine("This is an ATM where you can manage and update your account");
                Console.WriteLine("Choose an option for your bank account");
                Console.WriteLine("1) Choose to view your total balance");
                Console.WriteLine("2) Choose to add to money to your balance");
                Console.WriteLine("3) Choose to subtract money from your balance");
                Console.WriteLine("4) Choose to exit");

                string result = Console.ReadLine();

                try
                {


                    if (result == "1")
                    {
                        Console.WriteLine($"Your total balance is {balance}");
                        Console.ReadLine();

                    }
                    else if (result == "2")
                    {
                        Console.WriteLine("Input a number you wish to add");
                        uint addNum = Convert.ToUInt32(Console.ReadLine());
                        balance = AddToBalance(balance, addNum);
                          

                    }
                    else if (result == "3")
                    {
                        Console.WriteLine("Enter a number you wish to withdrawl from your account");
                        uint subtractNum = Convert.ToUInt32(Console.ReadLine());

                        if (subtractNum > balance)
                        {
                           
                            Console.WriteLine("Whoops you cannot withdraw that much money");
                            Console.ReadLine();

                        }
                        else
                        {
                            balance = SubtractFromBalance(balance, subtractNum);
                        }

                    
                      
                    }
                    else if(result =="4")
                    {
                        menu = false;
                    }

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
             


            }



        }
        
       
        public static uint AddToBalance(uint balance, uint num)

        {

            uint totalToAdd = balance + num;
            Console.WriteLine($"Your total balance is now: {totalToAdd}");
            

            return totalToAdd;
      
        }
        public static uint SubtractFromBalance(uint balance, uint num)

        {

            uint totalToSubtract = balance - num;
            Console.WriteLine($"Your total balance is now: {totalToSubtract}");
            
            return totalToSubtract;
        }


    }
}
