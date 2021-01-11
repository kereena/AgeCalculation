using System;

namespace justPracticing
{
    class Program
    {
        // prints today's date
        public static void Main(string[] args)
        {

            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);
           
            
            

            Console.WriteLine("Enter your date of birth");
            DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(dateOfBirth);
            

           
            yourAge(currentDate, dateOfBirth);

        }


         public static void yourAge(DateTime cDate, DateTime dBirth)
         {

            /* TimeSpan age = cDate - dBirth ;
             Console.WriteLine("your age is " + age.Days/365,25); */

            if (cDate.Month < dBirth.Month)
            {
                int years = cDate.Year - dBirth.Year - 1;
                Console.WriteLine(years);
            }
            else if ((cDate.Month == dBirth.Month) && (cDate.Day < dBirth.Day))
            {
                int years = cDate.Year - dBirth.Year - 1;
                Console.WriteLine(years);

            }
            else { 
                int years = cDate.Year - dBirth.Year;
                Console.WriteLine(years);


            }

        }
        

    }

}

