using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book : Merchandise
    {
        //Assignment
        //private string itemId;
        private string title;
        private double price;

        //Getter setter
        //public string ItemId
        //{
        //    get
        //    {
        //        return itemId;
        //    }
        //    set
        //    {
        //        itemId = value;
        //    }
        //}

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
            
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        //Master constructor
        public Book(string inItemId, string inTitle, double inPrice)
        {
            ItemId = inItemId;
            title = inTitle;
            price = inPrice;
        }

        public Book(string inItemId) : this(inItemId, "", 0)
        {
        }

        public Book(string inItemId, string inTitle) : this(inItemId, inTitle, 0)
        {
        }


        //Override ToString
        public override string ToString()
        {
            return "ItemId: "+ItemId + ", Title: " + Title + ", Price: " + Price;
        }

        public override string BlivSolgt(double pris)
        {
            string message = "Bogen blev solgt for " + pris + " kr.";
            return message;
        }
    }


}
