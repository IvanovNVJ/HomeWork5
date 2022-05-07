using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5._2
{
    internal class Program
    {
        static string[] StringSplitFunction(string inputPhrase)
        {
            return inputPhrase.Split(' ');

        }

        static string ReverseString(string inputPhrase)
        {
            string[] SplittedPhrase = StringSplitFunction(inputPhrase);
            string ResultString = "";
            for (int i = SplittedPhrase.Length; i > 0; i--)
            {
               ResultString += SplittedPhrase[i-1] + " "; 
            }
            return ResultString;
            
        
        }
        static void Main()
        {
            Console.WriteLine("Введите предложение");
            string Phrase = Console.ReadLine();
            string Result = ReverseString(Phrase);
            Console.WriteLine(Result);
            Console.ReadKey();

        }
    }
}
