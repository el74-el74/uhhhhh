using System;
using System.Reflection.Metadata;

namespace playhangman
{
    class program
    {
        static void Main(String[] args)
        {
            string[] options = {"It is certain", "It is decidedly so", "Without a doubt", "Yes definitely", "You may rely on it", "As I see it, yes", "Most likely", "Outlook good", "Yes", "Reply hazy, try again", "Ask again later", "Better not tell you now", "Cannot predict now", "Concentrate and ask again", "Don't count on it", "My reply is no", "My sources say no", "Outlook not so good", "Very Doubtful"};
            Random rng = new Random();
            int rand1 = rng.Next(20);
            Console.Write("ask me your question and be granted an answer ");
            Console.ReadLine();
            Console.WriteLine(options[rand1]);
        }

    }
}