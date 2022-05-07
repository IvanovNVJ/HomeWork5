using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5._1
{
    internal class Program
    {
        static string[] StringSplitFunction(string inputPhrase)
        {
             return inputPhrase.Split(' '); 
                   
        }
        static void Print (string [] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine (Array [i]);
                            }
        }
        static void Main()
        {
            Console.WriteLine("Введите предложение");
            string arr1 = Console.ReadLine();
            string[] arr2 = StringSplitFunction(arr1);
            Print(arr2);
            Console.ReadKey();
        }
    }
}
