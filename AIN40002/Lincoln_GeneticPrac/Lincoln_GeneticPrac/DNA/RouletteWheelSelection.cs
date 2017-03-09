using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lincoln_GeneticPrac.DNA
{
   public class RouletteWheelSelection
    {
        public Genome RouletteWheelSelect()
        {
            double genVal =  DNAattributes.rnd.Next() * DNAattributes.popTotalFitness;
            for (int i = 0; i < DNAattributes.PopulationSize; i++)
            {
                genVal -= DNAattributes.pop[i].Fit;
                if (genVal <= 0)
                {
                    return DNAattributes.pop[i];
                }
            }

            return null;

        }
    }
}
