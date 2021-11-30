using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   static class AVT
    {
        public static bool notoryes;
        public static string SourceText { get; set; }

         public static string SubString { get; set;} 
        public static List<string> occurrences = new List<string>();
        public static List<int> AllIndexesOf()
        {
            notoryes = false;
            List<int> indexes = new List<int>();
            for (int index = 0; index < SourceText.Length - SubString.Length+1;index++)
            {
                if (SourceText.Substring(index, SubString.Length)==SubString)
                {
                    indexes.Add(index);
                }
              
            }
            for (int i = 0; i < indexes.Count-1; i++)
            {
                if (indexes[i+1]-indexes[i]<SubString.Length)
                {
                    notoryes = true;
                    break;
                }
            }
            return indexes;
        }
        


    }
}
