using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Market
{
    internal class Tovar
    {



        private readonly string name;
        private readonly double price;
        private readonly string color;

        public Tovar(string name, double price, string color)
        {
           
            this.name = name;
            this.price = price;
            this.color = color;
        }

        public string Name => name;
        public double Price => price;
        public string Color => color;

        public override string ToString()
        {

            return Color + " " + Name + " " + Price.ToString() + "$";
        }


    }
}
