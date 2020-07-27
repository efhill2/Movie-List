using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Movie_List
{
    class Program
    {         
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat)
            {
                List<Movie> movies = listBuilder();
                List<string> catList = new List<string>() { "horror", "drama", "animated", "sci-fi" };

                Console.WriteLine("What category would you like to search for?");

                Console.WriteLine("");

                Console.WriteLine("You can select a number from the following: \n" +
                    "1) Horror \n" +
                    "2) Drama \n" +
                    "3) Animated \n" +
                    "4)Sci-Fi");

                string userInput = Console.ReadLine().ToLower();
                int numInput = int.Parse(userInput);

                foreach (Movie movie in movies)
                {
                    if(movie.catergory == catList[numInput - 1])
                    {
                        Console.WriteLine(movie.title);
                    }
                }

                repeat = repeatApp();
            }
        }

        static List<Movie> listBuilder()
        {
            List<Movie> movies = new List<Movie>();

            Movie One = new Movie("Halloween: Runtime = 1h 31m, Released = 1978", "horror");
            Movie Two = new Movie("Candy Man: Runtime = 1h 41m, Released = 1992", "horror");
            Movie Three = new Movie("Us: Runtime = 2h 1m, Released = 2019", "horror");
            Movie Four = new Movie("Rose Red: Runtime = 4h 14m, Released = 2002", "horror");
            Movie Five = new Movie("The Godfather: Runtime = 2h 58m, Released = 1972", "drama");
            Movie Six = new Movie("Boyz N The Hood: Runtime = 1h 52m, Released = 1991", "drama");
            Movie Seven = new Movie("Set it Off: Runtime = 2h 4m, Released = 1996", "drama");
            Movie Eight = new Movie("The Color Purple: Runtime = 2h 34m, Released = 1985", "drama");
            Movie Nine = new Movie("Spirited Away: Runtime = 2h 5m, Released = 2001", "animated");
            Movie Ten = new Movie("My Neighbor Totoro: Runtime = 1h 28m, Released = 1988", "animated");
            Movie Eleven = new Movie("Princess Mononoke: Runtime = 2h 14m, Released = 1997", "animated");
            Movie Twelve = new Movie("KiKi's Delivery Service: Runtime = 1h 43m, Released = 1989", "animated");
            Movie Thirteen = new Movie("The Fifth Element: Runtime = 2h 7m, Released = 1997", "sci-fi");
            Movie Fourteen = new Movie("Waterworld: Runtime = 2h 56m, Released = 1995", "sci-fi");
            Movie Fifthteen = new Movie("Demolition Man: Runtime = 1h 55m, Released = 1993", "sci-fi");

            movies.Add(One);
            movies.Add(Two);
            movies.Add(Three);
            movies.Add(Four);
            movies.Add(Five);
            movies.Add(Six);
            movies.Add(Seven);
            movies.Add(Eight);
            movies.Add(Nine);
            movies.Add(Ten);
            movies.Add(Eleven);
            movies.Add(Twelve);
            movies.Add(Thirteen);
            movies.Add(Fourteen);
            movies.Add(Fifthteen);

            movies.Sort((x, y) => x.title.CompareTo(y.title));

            return movies;
        }

        public static bool repeatApp()
        {
            Console.WriteLine("Would you like to search again?");
            string input = Validator(Console.ReadLine(), @"([(^yes$)|^(no)$])");

            if(Regex.IsMatch(input, "(yes)|(y)"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string Validator(string entry, string pattern)
        {
            while (idCheck(entry, pattern) == false)
            {
                entry = correctInput();
            }

            return entry;
        }
        public static bool idCheck(string ID, string pattern)
        {
            if(Regex.IsMatch(ID, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string correctInput()
        {
            Console.WriteLine("Please enter a correct input for the question ");
            return Console.ReadLine().ToLower();
        }
    }
}
