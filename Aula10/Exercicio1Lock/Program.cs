using System;
using System.Threading;

public class Program
{
    // Gerador de números aleatórios partilhado entre as threads
    private static Random rnd;

    // Lock para acesso ao gerador
    private static object threadLock;

    private static void Main()
    {
        rnd = new Random();
        threadLock = new object();

        Thread t1 = new Thread(FrogRace);
        Thread t2 = new Thread(FrogRace);
        Thread t3 = new Thread(FrogRace);
        t1.Name = "T_One";
        t2.Name = "T_Two";
        t3.Name = "T_Three";
        t1.Start(1);
        t2.Start(2);
        t3.Start(3);
        t1.Join();
        t2.Join();
        t3.Join();
    }

    private static void FrogRace(object o)
    {
        int id = (int)o;
        for (int i = 0; i < 10; i++)
        {
            int waitForMillis;

            // Acesso ao gerador controlado pela lock
            lock (threadLock)
            {
                waitForMillis = rnd.Next(1001);
            }

            Thread.Sleep(waitForMillis);
            Console.WriteLine($"Rã #{id} deu salto #{i + 1}");
        }
    }
}
