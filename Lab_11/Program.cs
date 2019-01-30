using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 10 movies in this list.");
            do
            {
                Console.Write("What movie category are you interested in? ");
                category = Console.ReadLine();
                Validate.ValidInput(category);
                Validate.MovieCategories(category);
                Console.Write("Would you like to continue? (y/n): ");
                response = Console.ReadLine();
                Validate.YesOrNo(response);

            }
            while (Validate.YesOrNo(response));
            {
                Console.WriteLine("Goodbye! Thanks for coming!");
            }
            Console.ReadLine();
        }
        public static Movie lionKing = new Movie("The Lion King", "Animated");
        public static Movie toyStory = new Movie("Toy Story", "Animated");
        public static Movie findingNemo = new Movie("Finding Nemo", "Animated");
        public static Movie theGodfather = new Movie("The Godfather", "Drama");
        public static Movie taxiDriver = new Movie("Taxi Driver", "Drama");
        public static Movie darkKnight = new Movie("The Dark Knight", "Drama");
        public static Movie halloween = new Movie("Halloween", "Horror");
        public static Movie birdBox = new Movie("Bird Box", "Horror");
        public static Movie starWars = new Movie("Star Wars", "SciFi");
        public static Movie inception = new Movie("Inception", "SciFi");

        public static ArrayList movies = new ArrayList() { lionKing, toyStory, findingNemo, theGodfather, taxiDriver, darkKnight, halloween, birdBox, starWars, inception };

        public static string category, response;

    }
}
                
