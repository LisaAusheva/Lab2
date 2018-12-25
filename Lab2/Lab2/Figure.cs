using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
   abstract partial class Figure
    {
        private string _Type;
        /// <summary>
        /// Название фигуры
        /// </summary>
        public string Type
        {
            get { return this._Type; }
            set { this._Type = value; }
        }
        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns></returns>
        abstract public double Area();

        public override string ToString()
        {
            Console.WriteLine(this.Type + ":");
            return this.Type + " с площадью " + this.Area().ToString();
            
        }

    }
}
