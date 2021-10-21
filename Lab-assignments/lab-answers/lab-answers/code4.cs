using System;
namespace lab_answers
{
    public class code4
    {
        int bn;
        string bookname;
        string booktitle;
        string bookauthor;
        int quantityofbooks;
        int bookprice;

        void display()
        {
            Console.Write("Book name= {0}\nBook Title= {1}\nBy= {2}\nQuantity= {3}\nBook Price= {4}\n", bn, bookname, booktitle, bookauthor, quantityofbooks, bookprice);
        }
        void calculate()
        {
            Console.Write("Total Bill Amount = {0}", quantityofbooks * bookprice);
        }

        static void Main(string[] args)
        {
            code4 book = new code4();
            book.bn = Convert.ToInt32(Console.ReadLine());
            book.bookname = Console.ReadLine();
            book.booktitle = Console.ReadLine();
            book.bookauthor = Console.ReadLine();
            book.quantityofbooks = Convert.ToInt32(Console.ReadLine());
            book.bookprice = Convert.ToInt32(Console.ReadLine());

            book.display();
            book.calculate();
        }
    }
}
