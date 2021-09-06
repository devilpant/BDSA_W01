using System;

namespace Leap_year_function
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            try
            {
                 int year = Int32.Parse(Console.ReadLine());
                try
                {
                    if(IsLeapYear(year)){
                        Console.WriteLine("yay");
                    } else {
                        Console.WriteLine("nay");
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("That's not a valid year");
            }
        }
        
        public static bool IsLeapYear(int year) {
            if(year < 1582){
                throw new ArgumentException("This only applies to years from 1582");
            }
            if(year % 4 == 0 && (year % 400 == 0 || year % 100 != 0)){
                return true;
            } else {
                return false;
            }
        }
    }
}
