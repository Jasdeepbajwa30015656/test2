/*jasdeep bajwa
 30015656*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static question_1.Program.salary;

namespace question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // methods 
            Console.WriteLine(" welcome to the stuff payroll system");
            Console.WriteLine("press enter to display salary");
            Console.WriteLine("press enter again to display wages");
            Console.Write("please enter the button");
            int button = int.Parse(Console.ReadLine());


            {
                //salary class//
                salary s1 = new salary();
                Console.WriteLine($"your per week salary ${Math.Round(s1.DisplaySalary(), 2)}");
                //2 lines//
                Console.WriteLine("");
                Console.WriteLine("");

            }

            // wages class//
            wages w1 = new wages();
            Console.Write("please enter the working hours");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine($"Wages per week ${Math.Round(w1.Displaywages(), 2)}");
            Console.ReadLine();
        }


        public class salary
        {
            // variables//
            public double annualsalary = 80000;
            public double weeklysalary;
            /* getters and setters*/
            public double Annualsalary { get { return annualsalary; } set { annualsalary = 80000; } }
            public double Weeklysalary { get { return weeklysalary; } set { weeklysalary = value; } }

            // Display the method for salary//
            // number of weeks ina year is 365/7 = 52
            public double DisplaySalary;
            double 80000/52;
                return $" per week salary is ${Math.round(income, 2)}";
               
                // create the constructor //
                public salary()
            {
                Console.WriteLine("your saalry is 80000 per year ");
                Annualsalary = 80000;
            }


            public class wages

            {
                // variables//
                private double hourlyrate;
                private double numHours;
                private double weeklywages;

                /*getter and setters*/
                public double hourlyRate { get { return hourlyrate; } set { hourlyrate = 33.72; } }
                public double numhours { get { return numHours; } set { numHours = value; } }
                public double weeklyWages { get { return weeklywages; } set { weeklywages = value; } }


                // methods of display wages//
                public string Displaywages(int hours)
                {
                    double hourly = 33.72;
                    return $" wages per week is ${Math.Round(hourly, 2)}";
                }

                //create the constuctor//
                public wages()
                {
                    Console.WriteLine("i will provide display salary");

                }
                public wages(double _houlyrate, double _numHours, double _weeklywages)
                {
                    Console.WriteLine("..... ..... \n");
                    hourlyRate = _houlyrate;
                    numHours = _numHours;
                    weeklyWages = _weeklywages;
                }
            }
        }
    }
}  
      
