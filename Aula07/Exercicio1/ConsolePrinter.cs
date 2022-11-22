using System;

namespace Observers
{
    public class ConsolePrinter : IObserver<AbstractStringSubject>
    {
        // Update, called by the subject when something new is happening
        public void Update(AbstractStringSubject sub)
        {
            // Show the last key pressed
            Console.Write(sub.Item);
        }
    }
}