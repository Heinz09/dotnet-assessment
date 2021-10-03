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
