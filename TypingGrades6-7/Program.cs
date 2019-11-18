using System;
using static System.Console;

namespace TypingGrades6_7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] wordTyped = { 76, 51, 31, 16, 0};

            char[] grades = { 'A', 'B', 'C', 'D', 'F' };

            int typeSpeed = Convert.ToInt32(ReadLine()); //get the number of words per minute user typed

            int post = 0; //find the position in the array

            for(int x = 0; x < wordTyped.Length; ++x)
            {
                if(typeSpeed >= wordTyped[x])
                {
                    post = x; //get the position in the array of the grade earned
                    x = wordTyped.Length; //stops the loop early
                }
            }

            WriteLine("Typing {0} words per minute: Grade {1}", typeSpeed, grades[post]);

        }
    }
}
