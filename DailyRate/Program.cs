using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }
        //the application calls the run method
        //run method calls the ReadDouble method to ask user for daily rate
        //readInt method is called to obtain the number of days
        //writeFee method displays results...value of writeFee returned by calculateFee method
        void run()
        {
            double dailyRate = ReadDouble("Enter your daily rate: ");
            int noOfDays = ReadInt("Enter the number of days: ");
            WriteFee(CalculateFee(dailyRate, noOfDays));
            Console.ReadLine();
        }

        //this statement calculates the fee payable by multiplying the two parameters together
        private double CalculateFee(double dailyRate, int noOfDays) => dailyRate * noOfDays;


        private static int ReadInt(string v)
        {
            Console.Write(v);
            string line = Console.ReadLine();
            //string converted to a number using int.Parse
            return int.Parse(line);
        }

        private double ReadDouble(string v)
        {
            //display variable "v" to the screen. The string paramter is passed in when the method is called
            //it contains the message prompting the user to type in the daily rate
            Console.Write(v);
            //Console.Write does not output a newline character after the message
            string line = Console.ReadLine();
            //user types a value that is read into a string using ReadLine method
            //converted to a double using the double.Parse method and passed back as the return value of the method
            return double.Parse(line);
        }
       

        private void WriteFee(double v) => Console.WriteLine($"The consultant's fee is: {v * 1.1}");

    }
}
