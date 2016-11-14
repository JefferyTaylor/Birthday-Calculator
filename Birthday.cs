// Jeffery Taylor, BIT 142, A2.0
using System;
using A3_Date_StudentWork;

namespace A3_Date
{
    class Birthday
    {
            
            private MyDate today = new MyDate(0,0);
            private int todayMonth;
            private int todayDay;

            private MyDate bday = new MyDate(0,0);
            private int bdayMonth;
            private int bdayDay;
            // Initializes all the variables.

        static void Main(string[] args)
        {
            Birthday Bday = new Birthday();
            Bday.Questions();   // Prompts Question.
            Bday.BirthdayCalc();// Calculates the number of days to Bday.
        }

        public void Questions() // This method promts the questions, sets the 'today' and 'bday' variables then prints how many days in the Bday month.
        {
            Console.WriteLine("What month is it now?");
            Int32.TryParse(Console.ReadLine(),out todayMonth);

            Console.WriteLine("What day is it now?");
            Int32.TryParse(Console.ReadLine(), out todayDay);

            Console.WriteLine("What month is your birthday in?");
            Int32.TryParse(Console.ReadLine(), out bdayMonth);

            Console.WriteLine("What day is your birthday on?");
            Int32.TryParse(Console.ReadLine(), out bdayDay);

            today.setDate(todayMonth, todayDay);// Sets the 'today'.
            bday.setDate(bdayMonth, bdayDay);   // Sets the 'bday'.

            Console.WriteLine("There are {0} days in month #{1}", bday.daysInMonth(), bday.getMonth());// Prints the number of days in the Bday month.
        }

        public void BirthdayCalc()// This method calculates the number of days to Bday.
        {
            int daysUntilBirthday = 0;

            if (bday.equals(today))// If users Bday, prints happy bday.
                Console.WriteLine("Happy Birthday!!! :D");
            else// If not, then calculates how many days.
            {
                for (int i = 0; i < 365; i++)// Goes through a full year.
                {
                    if (bday.equals(today))// When its users Bday, stops the counter.
                        break;
                    else
                    {
                        today.nextDay();
                        daysUntilBirthday++;
                    }
                }
                Console.WriteLine("Number of days until birthday {0}: {1}", bday.toString(), daysUntilBirthday);// Prints number of days until Bday.
            }
        }
    }
}
