/*
 * Student Name: Zechariah Te waaka (zac)
 * Student ID: 17452351
 * Pledge: I Pledge that his is souly my own code
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Tasl1
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = @""; //Enter path here
            //Try catach for errors
            try
            {
                //Creating Array from Text File
                string[] lines = File.ReadAllLines(path);
                //Checks if the File is empty, and if it is then it will not run the code
                if (lines.Length > 0)
                {
                    //Checks if the File is over 20 lines, and if it is then it will not run the code
                    if (!(lines.Length > 20))
                    {
                        //Converts the String Array to Int Array
                        int[] myArray = Array.ConvertAll(lines, int.Parse);
                        //Prints Headings
                        Console.WriteLine("Data Read From File: ");
                        Console.WriteLine();
                        //Loops through Array
                        foreach (String line in lines) { Console.WriteLine(line); } //Prints Array

                        //Calls the Print Prime Function and sends Parameters
                        PrintPrime(myArray);
                        Console.ReadLine();

                    }//If Condtion meet then this message will display
                    else { Console.WriteLine("***Over 20 Lines***"); Console.ReadLine(); }
                }//If Condition meet then this meesage will display
                else { Console.WriteLine("***File Empty***"); Console.ReadLine(); }
            }
            //If this Exceptions displays then this will trigger
            catch (DirectoryNotFoundException) { Console.WriteLine("***File not Found***"); Console.ReadLine(); }
            catch (FileNotFoundException) { Console.WriteLine("***File not Found***"); Console.ReadLine(); }
            catch (FormatException) { Console.WriteLine("***Failed to format***"); Console.ReadLine(); }
            catch (System.ArgumentException) { Console.Write("Error Found"); Console.ReadLine(); }
        }
        //Function to check if number is prime or not
        public static bool PrimeCheck(int number1)
        {
            //Sets to Bool so that all Numbers are Prime numbers until Calculated not
            Boolean b = true;
            //Sqrs the number
            int number2 = (int)Math.Sqrt(number1);
            //Checks if number is greater than 1 since any number below is not a prime
            if (!(number1 <= 1))
            {
                for (int num = 2; num <= number2; num++)
                {
                    //if the remainer is a 0
                    if ((number1 % num) == 0)
                    {
                        //Bool is set to Fale which means number is not a prime number
                        b = false;
                        //Breaks loops
                        break;
                    }
                }
                //Returns Prime number
                return (b);
            }
            //Otherwise Returns false
            return false;
        }
        //Function to print the prime
        public static void PrintPrime(int[] number)
        {
            int count = 0;
            for (int i = 0; i < number.Length; i++)
            {
                //Checks if number is prime using Primechecker method
                if (PrimeCheck(number[i]))
                {
                    //Adds 1 to count if number is print
                    count += 1;
                }
            }
            //Prints the amount of prime numbers
            Console.WriteLine();
            Console.WriteLine("The Count of Prime Numbers: " + count);
        }

    }
}
