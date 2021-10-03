using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public static class ExtensionMethod
    {
        public static string[] GetWords(this string sentence)
        {
            return sentence.Split(' ');
        }
    }
}
