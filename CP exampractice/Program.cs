using System;  //system was lighted because it was used for example: Console.WriteLine();
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_exampractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");  //it's in using system so if the system was deleted the console will no longer exit in the program
            System.Console.WriteLine("Hello World"); // can also write like this if you don't add the using system in the program but instead of using like this all the time u can simply type using system upon the code. Turned gray cuz it can be simpified.
            
            //Numeric Data Type
            int age = 13; // int are whole numbers ths statement is initializing and declaring in the same line
            int year;  // declaring in the first line
            year = 2026; // initializing in the second line
            Console.WriteLine("Interger Data Type");
            Console.WriteLine(age + " , "+ year); //Console.WriteLine was from the system library 
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(" ");

            long bignum = 20000000000L;  // if you wnat to declare the number to be long data type, put L in the data's last word
                                         //type CW + tap for auto correct of Console.WriteLine();
            Console.WriteLine("Long Data Type");
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(" ");
            //for the max and minimum value of the data type

            double numq = -12.34D;  //decimal number  will be always registered as double
            Console.WriteLine("Double Data Type");
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue); //for the other data types also can used like this
            Console.WriteLine(" ");

            float num2 = 124.5F;
            Console.WriteLine("Float Data Type");
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(" ");

            decimal num3 = 12.45M;
            Console.WriteLine("Decimal Data Type");
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(" ");
            //int = 32 git long = 64 git

            //Text based data type
            string nvalue = ""; //it is also a string just don't have a value but in char you can't store an empty character literal
            string name = "Kim TaeHyung";  //for the string the data should be put in the speech mark "", if '' was used to declare the char
            char letter = 'V';
            Console.WriteLine("Full name:"+name+","+"Stage Name:" + letter);
            Console.Write(" "); //it will not auto skip to the next line, it will continue to show the output in the same line

            //converting string to number
            string textint = "2020";
            int year1 = Convert.ToInt32(textint);
            Console.WriteLine(year1);
            Console.WriteLine(" ");

            string textint2 = "-2019"; //don't need to write L at the end when we type a number variable as a string
            long date = Convert.ToInt64(textint2);  //for the int64, the system knows it is long because interger is int32 in the system
            Console.WriteLine(date);
            Console.WriteLine(" ");

            string textint3 = "21.11";
            double tdate = Convert.ToDouble(textint3);  //to double value
            float tdate2 = Convert.ToSingle(textint3);  // to float value
            decimal tdate3 = Convert.ToDecimal(textint3);  // to decimal value
            Console.WriteLine(tdate);
            Console.WriteLine(tdate2);
            Console.WriteLine(tdate3);

            //boolean data type has two ==> true and false














        }
    }
}
