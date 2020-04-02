using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //int nombre = 1233;
            //int nombre2 = 222;
            //bool sana = true;
            //string ines = "inefh";
            //Console.WriteLine(nombre);
            //Console.WriteLine(nombre2);
            //Console.WriteLine(sana);
            //Console.WriteLine(ines);
            //Console.ReadKey();

             string filePath = @"C:\Users\mihadadene\source\repos\ConsoleUIReadFiles\Test.txt";

            //List<string> lines = File.ReadAllLines(filePath).ToList();

            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            //lines.Add("Sue, Storm, www.stormy.com");
           
            //File.WriteAllLines(filePath, lines);

            List<Person> people = new List<Person>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Person pr = new Person();

                pr.FirstName = entries[0];
                pr.LastName = entries[1];
                pr.Url = entries[2];

                people.Add(pr);

            }
            Console.WriteLine("Read from text files");

            foreach (var person in people)
            {
                Console.WriteLine($"{ person.FirstName} { person.LastName}: { person.Url }");
            }

            people.Add(new Person { FirstName = "Greg", LastName = "Jones", Url = "www.test.com" });

            List<string> output = new List<string>();

            foreach (var person in people)
            {
                output.Add($"{ person.FirstName },{ person.LastName },{person.Url }");
            }

            Console.WriteLine("Writing to text file");

            File.WriteAllLines(filePath, output);

            Console.WriteLine("All entries written");

            Console.ReadLine();

        }

    }
}
