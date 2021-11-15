using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage carLot = new Garage();
            foreach (Car c in carLot)
            {
                Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH");
            }
            Console.WriteLine();
        }
    }
}
