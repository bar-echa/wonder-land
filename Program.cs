using Microsoft.VisualBasic;
using System.Globalization;
using System.IO;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace console21
{
    internal class Program
    {
        static string directory = "C:\\GitHub\\ConsoleApp7\\ConsoleApp7\\";

        
        static void CreateDirectory(string location, string character_name, string item, string action, string fileName)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            string filePath = Path.Combine(directory, fileName +".txt");
            using (StreamWriter sw = new StreamWriter(filePath))
            {
               sw.WriteLine($"Once upon a time in a land called {location}," +
                   $" there lived a brave {character_name}. One day," +
                   $" {character_name} found a magical {item} that granted them the ability to {action}. " +
                   $"With this newfound power, {character_name}" +
                   $" set out on a journey to bring peace and prosperity to {location}.”");
            }

            
        }

            static void Main(string[] args)
            {
            Console.Write("Enter a location: ");
            string location = Console.ReadLine();
            Console.Write("Enter a character name: ");
            string character_name = Console.ReadLine();
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            Console.Write("Enter an action: ");
            string action = Console.ReadLine();
            Console.Write("Enter a filename to save your story: ");
            string fileName = Console.ReadLine();
            Console.WriteLine($"The story is successfully saved to C:\\GitHub\\ConsoleApp7\\ConsoleApp7\\{fileName}");

            CreateDirectory(location, character_name, item, action, fileName);
        }

        }
    }

