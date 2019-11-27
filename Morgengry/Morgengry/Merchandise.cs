using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Merchandise : IValuable
    {
        public string ItemId
        {
            get; set;
        }

        //public Merchandise(string inItemId)
        //{
        //    ItemId = inItemId;
        //}

        public override string ToString()
        {
            return "ItemId: " + ItemId;
        }

        public virtual string BlivSolgt(double pris)
        {
            string message = "Genstanden blev solgt for " + pris + " kr.";
            return message;
        }

        public double GetValue()
        {
            if (this is Book book)
            {
                return book.Price;
            }
            else if (this is Amulet amulet)
            {
                double price = 20;

                switch (amulet.Quality)
                {
                    case Level.medium:
                        return price;
                    case Level.low:
                        return price - 7.5;
                    case Level.high:
                        return price + 7.5;
                }

                return 0;
            }
            throw new Exception(this + " is not a merchandise.");
        }
    }
}
