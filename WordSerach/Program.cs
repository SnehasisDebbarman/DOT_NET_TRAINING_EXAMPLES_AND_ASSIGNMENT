using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSerach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<meaning> meaningList = new List<meaning>();
            while (true)
            {
                Console.WriteLine("1.Add word  Meaning \n2.find Meaning");
                int ch = int.Parse(Console.ReadLine());
                if (ch == 1)
                {
                    Console.WriteLine("Enter word:");
                    string wd = Console.ReadLine();
                    Console.WriteLine("Enter Meaning of the word '{0}' : ",wd);
                    string des = Console.ReadLine();
                    Word word = new Word();
                    word.addMeaning(wd, des,meaningList);
                }
                else if (ch == 2)
                {
                    Console.WriteLine("Enter word:");
                    string wd = Console.ReadLine();
                    Word word = new Word();
                    word.searchMeaning(wd,meaningList);
                }

            }

        }

    }
    class Word
    {
        public void addMeaning(string word,string wordMeaning, List<meaning> meaningList)
        {
            meaning ms = new meaning();
            ms.word = word;
            ms.description = wordMeaning;
            meaningList.Add(ms);
        }
        public void searchMeaning(string word, List<meaning> meaningList)
        {
            foreach (meaning item in meaningList)
            {
                if (word.Equals(item.word))
                {
                    Console.WriteLine("+--------------------------------------------------+");
                    Console.WriteLine("The meaning of "+word+" :"+item.description);
                    Console.WriteLine("+--------------------------------------------------+");
                }
                else
                {
                    Console.WriteLine("Meaning of word not found");
                }
            }
        }
    }
}
