using System;
using System.Collections.Generic;
using System.Collections;

namespace csharp_practice.Sources.CollectionsPractice
{
    public class Lists
    {
        public static void Run( )
        {
            
           List<bool> listBool = new List<bool>();
           list.Add(true);
           list.Add(false);
           // list.Add(1); // error
            
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            // intList.Add(true); // error
            
            List<int> list = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 9; i++)
            {
                list.Add(rnd.Next(1000));
            }

            Console.WriteLine("Динамически сформированный List");
            foreach (int item in list)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();
            
            list.RemoveAt(0);
            list.RemoveAt(list.Count - 1);

            Console.WriteLine("Тот же List, но без первого и последнего элементов");
            foreach (int item in list)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();
        }

    }
}