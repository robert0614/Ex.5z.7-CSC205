// Recurse.cs

/* first: returns the first character of the given string

public static char First(string s)
{
    return s[0];
}

// rest: returns a new string that contains all but the

// first letter of the given string
public static string Rest(string s)
{
    return s.substring(1);
}

// length: returns the length of the given string
public static int Length(string s)
{
    return s.Length;
} */
using System;

namespace Ex._5z._7_CSC205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test the First method
            Console.WriteLine("First(\"Hello\"): " + First("Hello"));

            // Test the Rest method
            Console.WriteLine("Rest(\"Hello\"): " + Rest("Hello"));

            // Test the Length method
            Console.WriteLine("Length(\"Hello\"): " + Length("Hello"));

            // Test WriteString method
            Console.WriteLine("WriteString(\"Hello\"):");
            WriteString("Hello");

            // Test WriteBackward method
            Console.WriteLine("WriteBackward(\"Hello\"):");
            WriteBackward("Hello");

            // Test ReverseString method
            string backwards = ReverseString("Allen Downey");
            Console.WriteLine("ReverseString(\"Allen Downey\"): " + backwards);
        }

        // First: returns the first character of the given string
        public static char First(string s)
        {
            return s[0];
        }

        // Rest: returns a new string that contains all but the first letter of the given string
        public static string Rest(string s)
        {
            return s.Substring(1);
        }

        // Length: returns the length of the given string
        public static int Length(string s)
        {
            return s.Length;
        }

        // WriteString: prints the letters of the string, one on each line
        public static void WriteString(string s)
        {
            if (Length(s) == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine(First(s));
                WriteString(Rest(s));
            }
        }

        // WriteBackward: prints the letters of the string in reverse order, one on each line
        public static void WriteBackward(string s)
        {
            if (Length(s) == 0)
            {
                return;
            }
            else
            {
                WriteBackward(Rest(s));
                Console.WriteLine(First(s));
            }
        }

        // ReverseString: returns a new string that is the reverse of the input string
        public static string ReverseString(string s)
        {
            if (Length(s) == 0)
            {
                return s;
            }
            else
            {
                return ReverseString(Rest(s)) + First(s);
            }
        }
    }
}
/* The Main method includes tests for each method to ensure they work correctly and demonstrate their functionality.
Run the program to see the output for the given examples. */




