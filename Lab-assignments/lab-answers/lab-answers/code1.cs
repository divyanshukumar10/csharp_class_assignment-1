using System;
namespace lab_answers
{
    public class code1
    {
        public int m;

        public code1()
        {
            m = 1000;
        }
        void Payment(int n)
        {
            int i = 1;
            int money = 0;
            while (m > 0)
            {


                int intrest = (m * 15) / 1000;
                m = m + intrest;
                if (m >= 100)
                {

                    m = m - n;
                    money = n * i;

                }
                else
                {

                    money = money + m;
                    m = m - m;

                }



                Console.WriteLine("Month: " + i + "Balance:-" + m + "Total Payment: " + money);
                i++;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Monthly Installment:-");
            int n = Convert.ToInt32(Console.ReadLine());
            code1 myobj = new code1();
            myobj.Payment(n);
        }
    }
}
