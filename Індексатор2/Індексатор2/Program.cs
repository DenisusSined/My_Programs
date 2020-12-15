using System;

namespace Індексатор2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Word
    {
        public string Source { get; }
        public string Target { get; set; }
        public Word(string source, string target)
        {
            Source = source;
            Target = target;
        }
    }
    class Dictionary
    {
        Word[] words;
        public Dictionary()
        {
            words = new Word[]
            {
            new Word("red", "красный"),
            new Word("blue", "синий"),
            new Word("green", "зеленый")
            };
        }
    }
}
