using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Validate
    {
        public static string ValidInput(string info)
        {
            while (true)
            {
                if (string.IsNullOrEmpty(info) || info.Length > 35)
                {
                    Console.WriteLine("This input is not valid. Please try again!");

                }

                foreach (char item in info)
                {
                    if (!char.IsLetter(item))
                    {
                        Console.WriteLine("Please use an alphabetic character. Try again");

                    }
                }

                return info;
            }
        }
        public static void MovieCategories(string userInput)
        {
            if (userInput.ToLower() == "horror")
            {
                foreach (Movie movie in Program.movies)
                {
                    if (movie.Category == "Horror")
                    {
                        Console.WriteLine(movie.Title);
                    }
                }
            }
            else if (userInput.ToLower() == "animated")
            {
                foreach (Movie movie in Program.movies)
                {
                    if (movie.Category == "Animated")
                    {
                        Console.WriteLine(movie.Title);
                    }
                }
            }
            else if (userInput.ToLower() == "scifi" || userInput.ToLower() == "sci fi" || userInput.ToLower() == "sci-fi")
            {
                foreach (Movie movie in Program.movies)
                {
                    if (movie.Category == "SciFi")
                    {
                        Console.WriteLine(movie.Title);
                    }
                }
            }

            else if (userInput.ToLower() == "drama")
            {
                foreach (Movie movie in Program.movies)
                {
                    if (movie.Category == "Drama")
                    {
                        Console.WriteLine(movie.Title);
                    }
                }
            }
            else
            {
                Console.Write("I'm sorry, that category was not recognied. Please enter Animated, Drama, Horror or SciFi: ");
            }
        }
        public static bool YesOrNo(string response)
        {
            while (true)
            {

                if (response == "y")
                {
                    Console.Clear();
                    return true;
                }
                else if (response == "n")
                {
                    return false;
                }
                else
                {
                    Console.Write("I'm sorry, that input was not valid. Please enter (y/n): ");
                    response = Console.ReadLine().ToLower();

                }
            }
        }
    }
}
                    

