﻿using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that number grouped by commas after every 3 digits. 
        
        NOTES: You cannot use any built-in formatting functions to complete this task.

        Assume: 0 <= n < 1000000000

        1 -> "1"
        10 -> "10"
        100 -> "100"
        1000 -> "1,000"
        10000 -> "10,000"
        100000 -> "100,000"
        1000000 -> "1,000,000"
        35235235 -> "35,235,235"

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class FormatNumber
    {
        public string Format(int value)
        {
            try
            {
                int num;
                bool parse = int.TryParse(value.ToString(), out num);
                if (!parse)
                {
                    throw new ArgumentOutOfRangeException();
                }

                string returnValue = "";
                string sValue = value.ToString();
                int counter = sValue.Length;
            
                foreach(char c in sValue)
                {
                    if (counter % 3 == 0)
                    {
                        if (returnValue.Length>0)
                            returnValue += ",";
                    }
                    returnValue += c;
                    counter--;
                }

                return returnValue;
            }
            catch (Exception e)
            {
                throw new Exception("Out of range", e);
            }
        }
    }
}
