using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    internal class DataSource
    {



        public List<Tovar> Stuf { get; set; }
        public List<Tovar> UserBasket { get; set; }

        public List<Tovar> WhiteStuf { get; set; }
        public List<Tovar> BlueStuf { get; set; }
        public DataSource()
        {
            WhiteStuf = new List<Tovar>();
            BlueStuf = new List<Tovar>();
            UserBasket = new List<Tovar>();
            Stuf = new List<Tovar>()
            

            {
                

                new Tovar("T-shirt",30,"White"),
                new Tovar("T-shirt",25,"Blue"),
                new Tovar("T-shirt",30,"White"),
                new Tovar("T-shirt",30,"White"),
                new Tovar("T-shirt",25,"Blue"),
                new Tovar("Shirt",12,"White"),

            };

            Sort(WhiteStuf);
            Sort(BlueStuf);
        }

        public void Sort(List<Tovar> list)
        {
            for (int i = 0; i < Stuf.Count; i++)
            {
                if (Stuf[i].Color == "White")
                {
                    WhiteStuf.Add(Stuf[i]);
                }else BlueStuf.Add(Stuf[i]);
            }
        }
    }
}
