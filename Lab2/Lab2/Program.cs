using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Rectangle R = new Rectangle(20, 4);
            Square S = new Square(5.41231);
            Circle C = new Circle(3.14);

            R.Print();
            S.Print();
            C.Print();

            Console.ReadLine();


        }
    }
}
