// Jeffery Taylor, BIT 142, A2.0
using System;

namespace A3_Date_StudentWork
{
    class MyDate
    {
        int month;
        int day;

            public MyDate(int m, int d) //Constructs a new MyDate representing the given month and day.
            {
                 month = m;
                 day  = d;
            }

            public int getMonth() // Gets the Month.
            {
                return month;
            }

            public int getDay() // Gets the Day.
            {
                return day;
            }

            public void setDate(int m, int d) // This method changes the month and the day.
            {
                month = m;
                day = d;
            }

            public String toString()  // This method returns a String representation of the MyDate object on which it was called in a month/day format.
            {
                return month.ToString() + "/" + day.ToString(); 
            }

            public Boolean equals(MyDate d) // This method returns true if its the users birthday and false when it is not.           
            {

                if (d.getMonth() == month && d.getDay() == day)
                    return true;
                else
                    return false;
            }

            public int daysInMonth() // This method returns the number of days in the month represented by the MyDate object on which it was called.
            {
                int[] DinM = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                for (int i = 0; i < DinM.Length; i++)
                {
                    if (i == month)
                        return DinM[i];
                }
                return 0000; // Error handling
            }

            public void nextDay() // This method modifies the state of the MyDate object on which it was called by advancing it 1 day in time.
            {
                if (month == 2) // If Febuary.
                {
                    if (day == 28)
                    {
                        month++;
                        day = 1;
                    }
                    else
                        day++;
                }

                else if (month == 3 || month == 5 || month == 8 || month == 10) // ElseIf months have 30 days. 
                {
                    if (day == 30)
                    {
                        month++;
                        day = 1;
                    }
                    else
                        day++;
                }

                else // Else months have 31 days.
                {
                    if (day < 31)
                        day++;
                    else if (month < 12)
                    {
                        month++;
                        day = 1;
                    }
                    else
                    {
                        month = 1;
                        day = 1;
                    }
                }
            }
    }
} 

// old date arrays idea
//int[][] MinY = {};
                //MinY[0] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 }; //Jan
                //MinY[1] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 };             //Feb
                //MinY[2] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 }; //Mar
                //MinY[3] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };     //Apr
                //MinY[4] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 }; //May
                //MinY[5] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };     //Jun
                //MinY[6] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 }; //Jul
                //MinY[7] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 }; //Aug
                //MinY[8] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };     //Sep
                //MinY[9] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 }; //Oct
                //MinY[10] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };    //Nov
                //MinY[11] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };//Dec
