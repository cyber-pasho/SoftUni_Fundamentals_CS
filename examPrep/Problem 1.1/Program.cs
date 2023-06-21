using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());
            double attendance = 0;
            double totalBonus = 0;
            //
            for (int i = 1; i <= studentsCount; i++)
            {
                double attendanceEach = int.Parse(Console.ReadLine());
                double totalBonusEach = attendanceEach / lecturesCount * (5 + bonus);
                if (totalBonusEach > totalBonus)
                {
                    totalBonus = totalBonusEach;
                    attendance = attendanceEach;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(totalBonus)}.");
            Console.WriteLine($"The student has attended {Math.Ceiling(attendance)} lectures.");
        }
    }
}
