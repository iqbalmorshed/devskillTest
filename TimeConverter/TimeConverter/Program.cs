using System;

namespace TimeConverter
{
    class Program
    {
        static string TimeConvert(string inputTime)
        {
            string[] tokens = inputTime.Split(':');
            string newTime = "";
            //Console.WriteLine(tokens[0] + tokens[1]);
            int hour = Int32.Parse(tokens[0]);
            //string amOrPm = "";
            int newHour = hour % 12;
            string amOrPm = "";
            if(hour < 12)
            {
                amOrPm+= "am";
            }
            else
            {
                amOrPm += "pm";
            }
            return newTime+ newHour.ToString() +":"+ tokens[1]+ " "+ amOrPm;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string time = Console.ReadLine();
            Console.WriteLine(TimeConvert(time));
        }
    }
}
