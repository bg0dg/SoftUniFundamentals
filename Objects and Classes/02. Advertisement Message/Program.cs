using System;

namespace _02._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] Phrases = new string[]
            {   "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] Events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] Authors = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] Cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };


            for (int i = 1; i <= n; i++)
            {
                int phraseIndexRandom = new Random().Next(0, Phrases.Length);
                int EventsIndexRandom = new Random().Next(0, Events.Length);
                int AuthorsIndexRandom = new Random().Next(0, Authors.Length);
                int CitiesIndexRandom = new Random().Next(0, Cities.Length);

                Console.WriteLine($"{Phrases[phraseIndexRandom]} {Events[EventsIndexRandom]} {Authors[AuthorsIndexRandom]} - {Cities[CitiesIndexRandom]}");
            }


        }
    }
}
