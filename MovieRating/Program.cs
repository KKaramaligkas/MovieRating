using System;

namespace MovieRating
{
    class Program
    {
        static void Main(string[] args)
        {
            var title = "MovieTitle";
            Random rate = new Random();// random generator
            int rating = rate.Next(0,10); // rating from one person
            int boxoffice = 8 * rate.Next(1000, 300000);// money earned from movie
            Console.WriteLine(string.Format("{0} {1} {2}", title, rating, boxoffice));
            string actorname = "Brad Pi";
        }
    }
}
