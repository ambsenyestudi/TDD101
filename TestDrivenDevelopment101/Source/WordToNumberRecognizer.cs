using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment101.Source
{
    public class WordToNumberRecognizer
    {
        public bool Recognize(string word)
        {
            bool isNumber = false;
            if(!string.IsNullOrWhiteSpace(word))
            {
                string[] words = word.Split(' ');
                int lastIndex = words.Length - 1;

                if (lastIndex > 0)
                {
                    isNumber = evaluateManyWordsNumbers(words);
                }
                else
                {
                    isNumber = evaluateSingleWordNumbers(words[lastIndex]);

                }
            }
            
            return isNumber;
        }
        private bool evaluateSingleWordNumbers(string word)
        {
            return NumberRepository.Units.Contains(word) || 
                NumberRepository.TenUnits.Contains(word) || 
                NumberRepository.Tens.Contains(word);
        }
        private bool evaluateManyWordsNumbers(string [] words)
        {
            bool[] wordsAreNumbers = new bool[words.Length];
            int lastIndex = words.Length - 1;
            wordsAreNumbers[lastIndex] = NumberRepository.Units.Contains(words[lastIndex]);
            if(wordsAreNumbers[lastIndex])
            {
                int nextIndex = lastIndex - 1;
                if(nextIndex >= 0)
                {
                    wordsAreNumbers[nextIndex] = 
                        NumberRepository.Tens.Contains(words[lastIndex]) && 
                        !(NumberRepository.TenUnits.Contains(words[lastIndex]));
                }    
            }

            bool isValid = true;
            foreach(bool isB in wordsAreNumbers)
            {
                isValid = isValid && isB;
            }
            return isValid;
        }
    }
}
