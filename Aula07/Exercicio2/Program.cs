using System;

namespace Exercicio2
{
    public static class Program
    {
        /// <summary>
        /// Program starts here.
        /// </summary>
        private static void Main()
        {
            // Variable of our delegate type
            StringOp strOp;

            // An instance of the StrConcat struct
            Joiner joiner = new Joiner("String In StrConcat");

            // Chain some methods onto our variable
            strOp = PrintUpper;  // static method
            strOp += PrintLower; // static method
            strOp += joiner.JoinAndPrint; // instance method

            // Invoke all methods via the variable
            strOp("This String Was Passed In tHe vAriAbLe");
        }

        /// <summary>
        /// Print the given string in upper case.
        /// </summary>
        /// <param name="str">The string to print in upper case.</param>
        private static void PrintUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        /// <summary>
        /// Print the given string in lower case.
        /// </summary>
        /// <param name="str">The string to print in lower case.</param>
        private static void PrintLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }
    }
}
