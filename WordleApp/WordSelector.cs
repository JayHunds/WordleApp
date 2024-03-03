using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleApp
{
    public class WordSelector
    {
        private string[] wordList;
        private Random random;
       
        public WordSelector(string[] wordList)
        {
            this.wordList = wordList;
            random = new Random();
        }
        public string SelectRandomWord()
        {
            int randomIndex = random.Next(0, wordList.Length);
            return wordList[randomIndex];
        }
    }
}
