using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTown
{
    class Program
    {
        static void Main(string[] args)
        {

            var mySchool = new School()
            {
                Length = 120,
                Width = 10,
                Height = 10
            };
            var schoolVol = mySchool.SquareFootage;
            Console.WriteLine($"The total square foot is {schoolVol}");
        }
    }
}
