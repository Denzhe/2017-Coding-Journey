using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Inspired by Ryno Adlam
/// </summary>
namespace Lincoln_GeneticPrac.DNA
{
  public  class Encoding
    {
        private static string [] decodeString = {" ","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        public static int [] Encoded()
        {
            int[] encoded = new int[DNAattributes.DNA_Length];
            for (int i = 0; i < DNAattributes.TargetSentence.Length; i++)
            {
                for (int j = 0; j < decodeString.Length; j++)
                {
                    if (DNAattributes.TargetSentence[i] == decodeString[j])
                    {
                        encoded[i] = j;
                    }
                }
            }

            return encoded;
        }

        public static void Decode(Genome g)
        {
            for (int i = 0; i < DNAattributes.DNA_Length; i++)
            {
                Console.Write(decodeString[g.DNA[i]]);
            }
        }
    }
}
