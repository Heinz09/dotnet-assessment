using System;
using TGS.Challenge;

namespace TGS.CLI
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("TGS CLI");
            Console.WriteLine("-*-*-*-*-");
            Console.WriteLine("\t1> VowelCount");
            Console.WriteLine("\t2> Anagram");
            Console.WriteLine("\t3> FormatNumbers");
            Console.WriteLine("-*-*-*-*-");
            Console.WriteLine("\t0> Exit");
            Console.Write("> ");
            var key = Console.ReadKey();
            char sKey = key.KeyChar;

            switch(sKey)
            {
                case ('1'):
                    {                        
                        Console.WriteLine("\r\nGive me a sentence :");
                        Console.Write("> ");
                        var input = Console.ReadLine();

                        VowelCount vc = new VowelCount();
                        Console.WriteLine("Vowels Found: "+vc.Count(input));

                        break;
                    }
                case ('2'):
                    {
                        Console.WriteLine("\r\nGive me your first word:");
                        Console.Write("> ");
                        string word1 = Console.ReadLine();
                        Console.WriteLine("\r\nGive me your 2nd word:");
                        Console.Write("> ");
                        string word2 = Console.ReadLine();

                        Anagram anagram = new Anagram();
                        Console.WriteLine("These words are :"+anagram.AreAnagrams(word1,word2));
                        break;
                    }
                case ('3'):
                    {
                        Console.WriteLine("\r\nGive me your number (integer/int32):");
                        Console.Write("> ");
                        int number = Convert.ToUInt16(Console.ReadLine());

                        FormatNumber formatNumber = new FormatNumber();
                        
                        Console.WriteLine("Formatted to :" + formatNumber.Format(number));

                        break;
                    }
                case ('0'):
                    {
                        Console.WriteLine("Exit gracefully.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Done");
                        break;
                    }
            }
        
        
        }

        
    }
}
