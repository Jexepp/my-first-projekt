using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course : IValuable
    {
        private double courseHourValue = 875.0;

        public double CourseHourValue {
            get { return courseHourValue; }
            set { courseHourValue = value; } 
        }

        public string Name { get; set; }

        public int DurationInMinutes { get; set; }

        public Course(string inName, int inDuration)
        {
            Name = inName;
            DurationInMinutes = inDuration;
        }

        public Course(string inName) : this(inName, 0)
        {

        }

        public override string ToString()
        {
            return "Name: " + Name + ", Duration in Minutes: " + DurationInMinutes + ", Pris pr påbegyndt time: " + CourseHourValue;
        }

        public double GetValue()
        {
            double price = (DurationInMinutes / 60) * 875.0;
            if ((DurationInMinutes % 60) >= 1)
            {
                price += 875;
            }
            return price;
        }
    }
}
