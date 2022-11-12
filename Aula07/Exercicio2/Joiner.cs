using System;

namespace Exercicio2
{
    /// <summary>
    /// Simple class that contains a string and a method to concatenate it
    /// with another string.
    /// </summary>
    public class Joiner
    {
        /// <summary>
        /// The string contained in this class.
        /// </summary>
        private readonly string firstString;

        /// <summary>
        /// Initialize the class.
        /// </summary>
        /// <param name="str">The string to contain in this class.</param>
        public Joiner(string str)
        {
            firstString = str;
        }

        /// <summary>
        /// Concatenate the first string (instance variable) with the second
        /// string, given as a parameter to this method.
        /// </summary>
        /// <param name="secondString">
        /// String to append to the first string.
        /// </param>
        public void JoinAndPrint(string secondString)
        {
            Console.WriteLine(firstString + secondString);
        }
    }
}
