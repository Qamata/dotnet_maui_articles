using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoloWorld
{
    public class LanguageFunctions
    {

        public static int GetWordCountInSentence(string word) //Public to make method visible outside of LanguageFunction
                                                              // Static so we dont need to access method with instance but
                                                              // call the method on type/class
        {
            string[] result = word.Split(' ');
            int NumberOfWords = result.Length;
            return NumberOfWords;
        }
    }

   
}
