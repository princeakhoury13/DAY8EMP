﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8EMP
{
    public class Attendance
    {
        public const int presentFullTime = 1;
        public const int presentHalfTime = 2;
        
        public void monthlyWage()
        {
            int empHours = 0;
            int dailyWage = 0;
            int monthlyWage = 0;
            int workingDays = 20;
            int hourlyWage = 20;



            for (int i = 1; i <= workingDays; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(3);
                switch (empCheck)
                {
                    case presentFullTime:
                        Console.WriteLine("Present Full Time");
                        empHours = 8;
                        break;
                    case presentHalfTime:
                        Console.WriteLine("Present Half Time");
                        empHours = 4;
                        break;
                    default:
                        Console.WriteLine("Absent");
                        empHours = 0;
                        break;
                }
                dailyWage = empHours * hourlyWage;
                Console.WriteLine("Today's Wage: " + dailyWage);
                monthlyWage = monthlyWage + dailyWage;
            }



            Console.WriteLine("Employee's Monthly Wage : " + monthlyWage);
        }
    }
}
