using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_QS_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            TNN tnn = new TNN();
            tnn.TelecastCurrentNewsToSubscriber();
        }
        class TNN
        {
            //WorldNewsUnit;
            //NationalNewsUnit;
            string ChoosingSection;
            public void TelecastCurrentNewsToSubscriber()
            {
                Subscriber sc = new Subscriber();
                sc.dlg = new Subscriber.CallbackDelegate(this.News);
                sc.DoSubscribe();
            }
            void News(string msg)
            {
                ChoosingSection = msg;
                if (ChoosingSection.Equals("WorldNews"))
                {
                    Console.WriteLine("You have subscribed Current World news...");
                    Console.WriteLine("World News Headlines.......");
                }
                else
                {
                    Console.WriteLine("You have subscribed Current National news...");
                    Console.WriteLine("National News Headlines....");
                }
            }
        }
        class Subscriber
        {
            public delegate void CallbackDelegate(string msg);
            public CallbackDelegate dlg = null;
            public void DoSubscribe()
            {
                Console.WriteLine("Subscribe to the Section... \n1.WorldNews\t2.NationalNews");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    dlg("WorldNews");
                }
                else if (choice == 2)
                {
                    dlg("NationalNews");
                }
                else
                {
                    Console.WriteLine("Wrong Choice...");
                }
            }
        }
    }
}