using System;
using System.Collections.Generic;

namespace ListsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruit = new List<string>();
            

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a fruit: ");
                fruit.Add(Console.ReadLine());
            }
            
            
            fruit.Add("pineapple");

            foreach (string FruitItem in fruit)
            {
                Console.WriteLine($"Fruits on the list: {FruitItem}");
            }

            int indexOfPineapple = fruit.IndexOf("pineapple");

            Console.WriteLine($"Pineapple is on index {indexOfPineapple}");

            fruit[indexOfPineapple] = "orange";

            foreach (string FruitItem in fruit)
            {
                Console.WriteLine($"Fruits on the updated list: {FruitItem}");
            }

            fruit.RemoveAt(fruit.Count-1);

            foreach (string FruitItem in fruit)
            {
                Console.WriteLine($"Trimmed fruit list: {FruitItem}");

            }

        }
    }
}
