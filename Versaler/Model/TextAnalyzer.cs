using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Versaler
{
    public static class TextAnalyzer
    {
        public static int GetNumberOfCapitals(string text)
        {
            //Skapa en räknare som håller koll på antalet versaler
            int count = 0;

            //Kollar antalet versaler i strängen
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}