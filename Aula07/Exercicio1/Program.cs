using System;

namespace Observers
{
    public class Program
    {
        private static void Main()
        {
            // The subject
            KeyReader kr = new KeyReader();

            // The observers
            IObserver<AbstractStringSubject> obs1 = new ConsolePrinter();
            IObserver<AbstractStringSubject> obs2 = new FileSaver("pressed_keys.txt");

            // Register observers
            kr.RegisterObserver(obs1);
            kr.RegisterObserver(obs2);

            // Read keys, observers are listening
            Console.WriteLine("Press some keys...");
            kr.ReadKeys();

            // Unregister observers
            kr.RemoveObserver(obs2);
            kr.RemoveObserver(obs1);
        }
    }
}
