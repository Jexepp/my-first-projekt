using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        public static double GetValueOfMerchandise(Merchandise merch)
        {
            if (merch is Book book)
            {
                return book.Price;
            }
            else if (merch is Amulet amulet)
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
            throw new Exception(merch + " is not a merchandise.");
        }


        public static double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public static double GetValueOfAmulet(Amulet amulet)
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

        public static double GetValueOfCourse(Course course)
        {
            double price = (course.DurationInMinutes / 60) * 875.0;
            if ((course.DurationInMinutes % 60) >= 1)
            {
                price += 875;
            }
            return price;
        }

    }
}
