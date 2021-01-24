using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double ivansMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            int robesNeeded = students;
            int sabresNeeded = (int)Math.Ceiling((double)students * 1.10);
            int beltsNeeded = students - (students / 6);
            double totalEquipmentPrice = lightsabrePrice * sabresNeeded + robesNeeded * robePrice + beltPrice * beltsNeeded;
            if (totalEquipmentPrice <= ivansMoney)
            {
                Console.WriteLine("The money is enough - it would cost {0:F2}lv.", totalEquipmentPrice);
            }
            else
            {
                Console.WriteLine("Ivan Cho will need {0:F2}lv more.", totalEquipmentPrice - ivansMoney);
            }
        }
    }
}