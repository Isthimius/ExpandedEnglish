using System;

namespace ExpandedEnglish
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IExpander expander = new Expander();

            do
            {
                Console.WriteLine("Enter the sentence in need of expanding:");

                var sentence = Console.ReadLine();
                var expandedSentence = expander.Expand(sentence);

                Console.WriteLine(string.Format("expanded result: {0}", expandedSentence));
                Console.WriteLine();

                Console.WriteLine("Press {Esc} to exit.  Press any other key to continue.");
                Console.WriteLine();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}