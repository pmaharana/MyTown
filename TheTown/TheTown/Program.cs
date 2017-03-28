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
            House house1 = new House()
            {
                BathRooms = 3,
                BedRooms = 4,
                Floors = 2
            };
            House house2 = new House()
            {
                BathRooms = 1,
                BedRooms = 2,
                Floors = 1
            }
            ;
            House house3 = new House()
            {
                BathRooms = 2,
                BedRooms = 3,
                Floors = 1
            }
            ;
            List<House> houseList = new List<House>();
            house1.Name = "Schweinsteigers";
            house2.Name = "Maharana";
            house3.Name = "Boulengaire";

            Bank bank1 = new Bank();
            Bank bank2 = new Bank();
            Bank bank3 = new Bank();

            List<Bank> bankList = new List<Bank>();

            School school1 = new School();
            School school2 = new School();
            School school3 = new School();

            List<School> schoolList = new List<School>();






        }
    }
}
