using System;

namespace Observers
{
    public class KeyReader : AbstractStringSubject
    {
        public void ReadKeys()
        {
            // Ask for keys while user does not press Escape
            ConsoleKey key;
            while ((key = Console.ReadKey(true).Key) != ConsoleKey.Escape)
            {
                // Read key
                Item = key.ToString();
            }
        }
    }
}