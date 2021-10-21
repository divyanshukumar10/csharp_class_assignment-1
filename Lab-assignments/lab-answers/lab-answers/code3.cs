using System;
using System.Linq;
namespace lab_answers
{
    public class code3
    {
        int rollno;
        string name;
        string dept;
        int sem;
        string branch;
        int[] marks = new int[5];

        void getmarks()
        {
            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        void display()
        {
            int sum = marks.Sum();
            Array.Sort(marks);
            float avg = sum / 5;
            if (marks[4] < 35)
            {
                Console.WriteLine("FAIL");
            }
            else
            {
                if (avg < 50)
                    Console.WriteLine("FAIL");
                else
                    Console.WriteLine("PASS");
            }
        }

        static void Main(string[] args)
        {
            code3 student = new code3();
            student.rollno = Convert.ToInt32(Console.ReadLine());
            student.name = Console.ReadLine();
            student.dept = Console.ReadLine();
            student.sem = Convert.ToInt32(Console.ReadLine());
            student.branch = Console.ReadLine();

            student.getmarks();
            student.display();

        }
    }
}
