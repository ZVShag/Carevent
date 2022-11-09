using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public delegate void Finish_time(string t);
    class Car
    {
        public string Model { get; set; }
        public string Fio { get; set; }
        public int max_speed { get; set; }
        public void Time(string time)
        {
            Console.WriteLine($"Car {Model} drive {Fio} maxspeed {max_speed} time{time} ");
        }
        public void Finish(string time)
        {
            Console.WriteLine(time);
        }
    }
    class Rally
    {
        public  Finish_time finishEvent;
        public void Finish(string time)
        {
            if (finishEvent != null)
            {
                finishEvent(time);
            
            }
        }

    }
}
