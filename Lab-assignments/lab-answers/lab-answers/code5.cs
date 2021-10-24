using System;
namespace lab_answers
{
    public class code5
    {
        float area(float a, float b)
        {
            return a * b;
        }
        float area(int c, int d)
        {
            return ((float)(0.5 * c * d));
        }
        float area(float e)
        {
            return (float)(3.14 * e * e);
        }
        float area(int f)
        {
            return f * f;
        }

        static void Main(string[] args)
        {
            float a, b, e;
            int c, d, f;

            Console.WriteLine("Choose shape");
            Console.WriteLine("1.rect \n2.tri \n3.circle \n4.sq");
            int g= Convert.ToInt32(Console.ReadLine());

            switch(g)
            {
                case 1:
                    {
                        code5 t = new code5();
                        a = Convert.ToSingle(Console.ReadLine());
                        b = Convert.ToSingle(Console.ReadLine());
                        float m = t.area(a, b);
                        Console.WriteLine("rect area = {0}", m);
                        break;
                    }
                case 2:
                    {
                        code5 u = new code5();
                        c = Convert.ToInt32(Console.ReadLine());
                        d = Convert.ToInt32(Console.ReadLine());
                        float n = u.area(c, d);
                        Console.WriteLine("tri area = {0}", n);
                        break;
                    }
                case 3:
                    {
                        code5 v = new code5();
                        e = Convert.ToSingle(Console.ReadLine());
                        float o = v.area(e);
                        Console.WriteLine("cirlce area = {0}", o);
                        break;
                    }
                case 4:
                    {
                        code5 w = new code5();
                        f = Convert.ToInt32(Console.ReadLine());
                        float p = w.area(f);
                        Console.WriteLine("sq area = {0}", p);
                        break;

                    }
                default:
                    {
                        Console.WriteLine("Invalid");
                        break;
                    }
            }
        }

    }
}
