using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class ValuableRepository : IPersistable
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {

            foreach (IValuable val in valuables)
            {
                if (val.ToString().Contains(id))
                {
                    return val;
                }
                
            }

            return null;
        }

        public double GetTotalValue()
        {
            double price = 0;

            foreach (IValuable valuable in valuables)
            {
                price += valuable.GetValue();
            }

            return price;
        }

        public int Count()
        {
            return valuables.Count();
        }

        public void Save()
        {
            try
            {
                StreamWriter writer = new StreamWriter("C:\\ValuableRepository.txt");

                writer.WriteLine("Test"); //Hvordan med adskilte klasser og værdier?
                writer.WriteLine("Test2"); //Hvordan med adskilte klasser og værdier?
                writer.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");

            }
        }

        public void Save(string filename)
        {
            try
            {
                StreamWriter writer = new StreamWriter(filename);
                writer.WriteLine(); //Hvordan med adskilte klasser og værdier?
                writer.Close();
            }
            catch (Exception e)
            {
                throw e;
            } 
        }

        public void Load()
        {
            StreamReader reader = new StreamReader("ValuableRepository.txt");
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }

            reader.Close();
        }

        public void Load(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }

            reader.Close();
        }
    }
}
