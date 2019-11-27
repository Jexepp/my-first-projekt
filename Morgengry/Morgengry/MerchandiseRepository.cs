using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class MerchandiseRepository
    {
        private List<Merchandise> merchandises = new List<Merchandise>(); 

        public void AddMerchandise(Merchandise merch)
        {
            merchandises.Add(merch);
        }

        public Merchandise GetMerchandise(string itemId)
        {
            Merchandise merch = merchandises.ElementAt(int.Parse(itemId));
            return merch;
        }

        public double GetTotalValue()
        {
            double value = 0;
            return value;
        }

    }
}
