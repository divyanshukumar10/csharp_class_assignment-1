using System;
namespace lab_answers
{
    public class code2
    {
        public int Account_Number;
        public string Customer_Name;
        public string Account_Type;
        public string Transaction_Type;
        public int Amount;
        public int Balance;

        public code2(int account_Number, string customer_Name, string account_Type, string transaction_Type, int amount, int balance)
        {
            Account_Number = account_Number;
            Customer_Name = customer_Name;
            Account_Type = account_Type;
            Transaction_Type = transaction_Type;
            Amount = amount;
            Balance = balance;
        }
        void Credit()
        {
            Balance = Balance + Amount;
        }
        void Debited()
        {
            Balance = Balance - Amount;
        }

        void show()
        {
            Console.WriteLine("Account No:- {0}", Account_Number);
            Console.WriteLine("Customer Name:{0}", Customer_Name);
            Console.WriteLine("Account Type: {0}", Account_Type);
            Console.WriteLine("Original Balance:{0}", Balance);
            if (Account_Type == "D")
            {
                Credit();
            }
            if (Account_Type == "W")
            {
                Debited();
            }
            Console.WriteLine(" Balance After Updation:{0}", Balance);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Account Number:-");
            int account_Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Customer Name:-");
            string customer_Name = Console.ReadLine();
            Console.WriteLine("Enter the Account Type:");
            string account_Type = Console.ReadLine();
            Console.WriteLine("Enter the transaction Type: D or W");
            string transaction_Type = Console.ReadLine();
            Console.WriteLine("Enter the Amount that you want to Credit or Debit:");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Intial Balance:");
            int balance = Convert.ToInt32(Console.ReadLine());

            code2 Account_Details = new code2(account_Number, customer_Name, account_Type, transaction_Type, amount, balance);
            Account_Details.show();

        }
    }
}
