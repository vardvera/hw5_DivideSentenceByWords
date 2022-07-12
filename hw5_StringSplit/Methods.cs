using System;






namespace hw5_StringSplit
{
    class Methods
    {

        public enum ReverseOption
        {
            No,
            Yes
        }

        public static void PrintWordsOnLines(string [] words) 
        {
            foreach (var e in words) { Console.WriteLine($"{e}"); }
        }

        public static void ReverseWords(string [] words)
        {
            int wordCount = 1;
            string reverseWords = "";

            foreach (var e in words) { reverseWords += words[words.Length - wordCount] + " "; wordCount++; }
            Console.WriteLine($"{reverseWords}");
        }

        public static void SplitSentenceByWords(string Sentence, ReverseOption options)
        {
            char[] charSeparators = new char[] { ' ' };
            string[] words;

            words = Sentence.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

            if (options == 0 ) { PrintWordsOnLines(words); }
            else { ReverseWords(words);}
        }

        
 
           
    }
}
