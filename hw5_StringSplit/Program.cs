using System;

namespace hw5_StringSplit
{
    class Program
    {
        static void PrintWordsOnLines(string [] words) 
        {
            foreach (var e in words) { Console.WriteLine($"{e}"); }
        }

        static void SplitSentenceByWords(string Sentence)
        {
            char[] charSeparators = new char[] { ' ' };
            string[] words;

            words = Sentence.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

            PrintWordsOnLines(words);
        }

 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение с единичным пробелом между словами:");
            string Sentence = Console.ReadLine();

            SplitSentenceByWords(Sentence);

        }
           
    }
}
