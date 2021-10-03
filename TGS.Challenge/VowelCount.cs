using System;
using System.Collections.Generic;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {
            List<char> vowels = new List<char>();
                       
            vowels.Add('A');
            vowels.Add('E');
            vowels.Add('I'); 
            vowels.Add('O'); 
            vowels.Add('U');

            int vowelCount = 0;

            foreach (char c in value.ToUpper())
            {
                if (vowels.Contains(c)) vowelCount++;
            }

            return vowelCount;
        }
    }
}
