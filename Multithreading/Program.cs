using System;
using System.Threading;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            movie mo = new movie();
            music mu = new music();

            ThreadStart ts1 = new ThreadStart(mo.PlayMovie);
            ThreadStart ts2 = new ThreadStart(mu.PlayMusic);
            Thread t1 = new Thread(ts1);
            Thread t2 = new Thread(ts2);
            t1.Start();
            t2.Start();



        }
    }
    class movie
    {
        public void PlayMovie()
        {
            Console.WriteLine("Movvie is Started...");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Movie is playing:");
                Console.WriteLine(i);
                Thread.Sleep(1000); 
            }
            Console.WriteLine("Movie is finished");
        }
    }
    class music
    {
        public void PlayMusic()
        {
            Console.WriteLine( "Music is playing...");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Musiv is playing:");
                Console.WriteLine(i);
                Thread.Sleep(1000);
                
            }
            Console.WriteLine("music stopped");
        }
    }
}
