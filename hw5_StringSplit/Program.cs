using System;




namespace hw5_StringSplit
{
    class Program
    {
        static void Main (string[] args)
        {
            // печать каждого слова в предложении на новой строчке
            
            Console.WriteLine("Введите предложение с единичным пробелом между словами:");
            string Sentence = Console.ReadLine();

            Methods.SplitSentenceByWords(Sentence, Methods.ReverseOption.No);

            Sentence = "";
            Console.WriteLine();



            // перестановка слов местами в обратной последовательности

            Console.WriteLine("Введите предложение с единичным пробелом между словами:");
            Sentence = Console.ReadLine();

            Methods.SplitSentenceByWords(Sentence, Methods.ReverseOption.Yes);
        }


    }
}
