using System.IO;

namespace Observers
{
    public class FileSaver : IObserver<AbstractStringSubject>
    {
        // File where to put pressed keys
        private readonly string filename;

        // Constructor
        public FileSaver(string filename)
        {
            this.filename = filename;
        }

        // Update, called by the subject when something new is happening
        public void Update(AbstractStringSubject sub)
        {
            // Save the last key pressed to a file
            File.AppendAllText(filename, sub.Item);
        }
    }
}