using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lincoln_GeneticPrac
{
    /// <summary>
    /// Took inspiration from Ryno
    /// </summary>
 public class DNAattributes
    {
    
        public static Random rnd;
        public static int DNA_Length = 23;
        public static double MutationRate = 0.05;
        public const int PopulationSize = 100;
        public static List<Genome> pop;
        public static double popTotalFitness = 0;
        public static double bestGenome;
        public static int bestGenomeIndex = 0;
        public static int[] target;
        public static string[] TargetSentence;
    }
}
