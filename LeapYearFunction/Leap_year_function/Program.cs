using System;

namespace Leap_year_function
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        
        public static bool IsLeapYear(int year){
            if(year % 4 == 0 && (year % 400 == 0 || year % 100 != 0)){
                return true;
            } else {
                return false;
            }
        }
    }
}
