using static System.Collections.Specialized.BitVector32;
using System.ComponentModel;
using System.Drawing;

namespace AssignmentTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 2 :

            #region Question 1
            // 1 - Write a program that allows the user to enter anumber then print it.
            //  Console.WriteLine("Please Enter A Number ");
            //  int num = Convert.ToInt32(Console.ReadLine());
            //  Console.WriteLine(num);
            //  Console.WriteLine("==============================================================================================");
            #endregion

            #region Question 2
            // 2 - Write C# program that converts a string to an integer, but the string contains non - numeric characters.And mention what will happen
            // string word = "Anything";
            // int num1 = Convert.ToInt32("word");
            // Console.WriteLine(num1);
            // Result : Unhandled exception.   
            // Console.WriteLine("==============================================================================================");
            #endregion

            #region Question 3
            // 3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            // float x = 20.5f;
            // float y = 40.5f;
            // float res = x + y;
            // Console.WriteLine(res);
            // Result : it's run and print =>  61
            //Point P1 = new Point() { x = 3.5f, y = 6.8f };
            //float res1 = P1.x + P1.y; 
            //Console.WriteLine(res1);
            // Result : it's run and print =>  10.3
            // Console.WriteLine("==============================================================================================");
            #endregion

            #region Question 4
            // 4 - Write C# program that Extract a substring from a given string. (Search)
            // string str = "Anything Anything2";
            // string subStr = str.Substring(9, 9);
            // Console.WriteLine(subStr);
            // Console.WriteLine("==============================================================================================");
            #endregion

            #region Question 5
            // 5 - Write C# program that take two string variables and print them as one variable
            // string str1 = "Anything";
            // string str2 = "Anything2";
            // string fullStr = str1 + " " + str2;
            // Console.WriteLine(fullStr);
            // Console.WriteLine("==============================================================================================");
            #endregion

            #region Question 6
            // 6 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time.The formula for simple interest is Interest = (principal * rate * time) / 100.
            // int principal = 800;
            // int rate = 8;
            // int time = 2;
            // double interest = (principal * rate * time) / 100;
            // Console.WriteLine(interest);
            // Console.WriteLine("==============================================================================================");
            #endregion

            #region Question 7
            // 7 - Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters.The formula for BMI is BMI = (Weight) / (Height * Height)
            // int w = 70; // kg
            // double h = 1.75; // meters
            // double BMI = w / (h * h);
            // Console.WriteLine(w + " Kg " + " & " + h + " Meters " + " = " + " bmi " + " = " + w / (h * h));
            // Console.WriteLine("==============================================================================================");
            #endregion

            #region Question 8
            /* 8 - Write a program that takes the date from the user and displays it in various formats using string interpolation. (Search)
                   Ex:
                     Today’s date : 20 , 11 , 2001
                     Today's date : 20 / 11 / 2001 
                     Today's date : 20 – 11 – 2001 
            */
            //   Console.WriteLine("Enter A Day ");
            //   int day = int.Parse(Console.ReadLine());
            //   Console.WriteLine("Enter A Month ");
            //   int month = int.Parse(Console.ReadLine());
            //   Console.WriteLine("Enter A Year ");
            //   int year = int.Parse(Console.ReadLine());
            //   Console.WriteLine($"Today's date: {day} , {month} , {year}");
            //   Console.WriteLine($"Today's date: {day} / {month} / {year}");
            //   Console.WriteLine($"Today's date: {day} - {month} - {year}");
            //   Console.WriteLine("==============================================================================================");
            #endregion

            #region Question 9
            /* 9 - What is the output of the following C# code? (Search)
                  DateTime date = new DateTime(2024, 6, 14); 
                  Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
                      a)  The event is on 14/06/2024 
                      b)  The event is on 2024-06-14 
                      c)  The event is on 06/14/2024 
                      d)  The event is on June 14, 2024 
           */

            //Answer :
            //c)  The event is on 06/14/2024 
            // Console.WriteLine("==============================================================================================");
            #endregion

            #region Question 10
            /* 10- Which of the following statements is correct about the C#.NET code snippet given below? 
               int d;  
               d = Convert.ToInt32( !(30 < 20) ); 
                  e) A value 0 will be assigned to d. 
                  f) A value 1 will be assigned to d. 
                  g) A value -1 will be assigned to d. 
                  h) The code reports an error. 
                  i) The code snippet will work correctly if ! is replaced by Not. 
            */

            // Answer : 
            // f) A value 1 will be assigned to d.
            // Console.WriteLine("==============================================================================================");
            #endregion

            #region Question 11
            /* 11 - Which of the following is the correct output for the C# code given below?
                   Console.WriteLine(13 / 2 + " " + 13 % 2); 
                        a) 6.5 1 
                        b) 6.5 0 
                        c) 6 0 
                        d) 6 1 
                        e) 6.5 6.5
            */

            // Answer :
            // d) 6 1
            // Console.WriteLine("==============================================================================================");
            #endregion
        }
    }
}
