using System;
namespace lab_answers
{
    public class code6
    {
        public string name;
        public int account_no;
        public string Type;
        public int balance;

        public code6(string name)
        {
            this.name = name;
        }

        void method(int b, int amount, int witdraw)
        {
            balance = b;
            balance = b + amount;
            balance = balance - witdraw;
            if (balance > 10000)
            {
                balance = balance - witdraw;
            }
            Console.WriteLine("Name of Depositor is " + name);
            Console.WriteLine("Total Balance in Account is:" + balance);
        }

        static void Main()
        {
            Console.WriteLine("Enter the Name of Depositor:-");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Intial amount in account:-");
            int intial_balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount that you want to deposite");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Amount that you want withdraw");
            int withdraw = Convert.ToInt32(Console.ReadLine());

            code6 myobj = new code6 (name);
            myobj.method(intial_balance, amount, withdraw);
        }
    }
}
