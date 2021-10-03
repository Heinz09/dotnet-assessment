using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGS.Challenge;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TGS.MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TGS : ControllerBase
    {
        [HttpPost("{message}")]
        public int VowelCount(string message)
        {
            VowelCount vc = new VowelCount();

            return vc.Count(message);
        }
        
        [HttpPost()]
        public bool Anagrams(string word1, string word2)
        {
            Anagram anagram = new Anagram();

            return anagram.AreAnagrams(word1, word2);
        }
        
        [HttpGet("{number}")]
        public string FormatNumber(int number)
        {
            FormatNumber formatNumber = new FormatNumber();

            return formatNumber.Format(number);
        }
    }
}
