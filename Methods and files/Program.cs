using System;
using System.IO;

namespace Methods_and_files
{
    class Program
    {
        static void Main(string[] args)
        {

            File.WriteAllText(@".\Movies.txt", "Star Wars\nThe Empire Strikes Back\nReturn Of The Jedi\n");

            // Opret en fil stream kaldet file ved hjælp af den lokale fil "Movies.txt"
            var file = new FileStream(@".\Movies.txt", FileMode.Create);
            var writer = new StreamWriter(file);

            //    Opret en stream reader kaldet reader ved hjælp af file stream
            var reader = new StreamReader(file);

            //  Hvis vi ikke er i slutningen af streamen, skal du oprette en lokal string med navnet movie og tildele den værdien af den næste linje fra filen

            string movie = reader.ReadLine();

            //     Skriv hver film til konsollen ved hjælp af WriteLine metoden.

            Console.WriteLine(file);


            // Why are these "tasks" so poorly made that I can't even understand them. FIX THEM!

            Console.ReadKey();

        }


        public static string ContentOne()
        {
            File.WriteAllText(@".\StarWars.txt", "Han skød først");

            string content = File.ReadAllText(@".\StarWars.txt");

            return content;

        }
        public static string ContentTwo()
        {
            string content = File.ReadAllText(@".\StarWars.txt");

            return content;
        }
        public static string ContentThree()
        {
            File.Delete(@".\StarWars.txt");
            string content = File.ReadAllText(@".\StarWars.txt");

            return content;
        }
        public static string ContentFour()
        {
            Directory.CreateDirectory(@".\Users\mark4805\Desktop\school\Droids");
            string d = "Droids";
            Console.WriteLine(d + " was created");
            return d;
        }
        public static string ContentFive()


        {
            Directory.Delete(@".\Users\mark4805\Desktop\school\Droids");
            string d = "Droids";
            Console.WriteLine(d + " was deleted");
            return d;
        }
        public static string ContentSix()
        {

            Directory.CreateDirectory(@".\Droids\Astromech");
            Directory.CreateDirectory(@".\Droids\Protocol");
            File.WriteAllText(@".\Droids\Astromech\R2D2.txt", "beep bop");
            File.WriteAllText(@".\Droids\Protocol\C3P0.txt", "sir!");

            string[] files = Directory.GetFiles(@"C:\Users\Bailey\source\repos\Methods and files\Methods and files\bin\Debug\net5.0\Droids", "*", SearchOption.AllDirectories);


            foreach (string i in files)
            {
                Console.WriteLine(i);
            }

            string d = "Res";
            return d;


        }
    }
}