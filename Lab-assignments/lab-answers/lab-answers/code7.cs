using System;
namespace lab_answers

{
    public class code7
    {
            public int rollno;
            public string name;
            public int eng, maths, sci;

            void display()
            {
                float total = eng + maths + sci;
                float per = (total/300)*100;
                Console.Write("Total marks = {0}\n", total);
                Console.Write("Total percentage = {0}", per);
            }
        

        static void Main(string[] args)
        {
            code7 user = new code7();
            user.rollno = Convert.ToInt32(Console.ReadLine());
            user.name = Console.ReadLine();
            user.eng = Convert.ToInt32(Console.ReadLine());
            user.maths = Convert.ToInt32(Console.ReadLine());
            user.sci = Convert.ToInt32(Console.ReadLine());

            user.display();
        }

    }
}
