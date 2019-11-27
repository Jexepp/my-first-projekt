using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Morgengry
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("[Start]");

            Program program = new Program();
            program.Save();
            Console.ReadLine();
        }

        private string Save()
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
            return "Done";
        }
    }
}
