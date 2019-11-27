using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public enum Level
    {
        medium, low, high
    }

    public class Amulet : Merchandise
    {
        //Assignments
        private string itemId;
        private string design;
        private Level quality;

        static double LowQualityValue = 12.5;
        static double MediumQualityValue = 20.0;
        static double HighQualityValue = 27.5;

        //Getter Setter
        new public string ItemId //New??
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public string Design
        {
            get { return design; }
            set { design = value; }
        }

        public Level Quality
        {
            get { return quality; }
            set { quality = value; }
        }


        //Constructors
        public Amulet(string inItemId, Level inQuality, string inDesign) //: base(inItemId)
        {
            this.ItemId = inItemId;
            quality = inQuality;
            design = inDesign;
        }

        public Amulet(string inItemId) //: base(inItemId)
        {
            this.ItemId = inItemId;
        }

        public Amulet(string inItemId, Level inQuality) //: base(inItemId)
        {
            this.ItemId = inItemId;
            quality = inQuality;
        }

        //Override ToString()
        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Quality: " + Quality + ", Design: " + Design; 
        }


    }
}
