using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAlgorithm
{
  public sealed  class GenomeComparer : IComparer
    {

        public GenomeComparer()
        {

        }

        public int Compare(object gen1,object gen2)
        {
            if (!(gen1 is Genome) || !(gen2 is Genome))
                throw new ArgumentException("Not of type Genome");

            if (((Genome)gen1).Fitness > ((Genome)gen2).Fitness)
            {
                return 1;
            }
            else if (((Genome)gen1).Fitness == ((Genome)gen2).Fitness)
            {
                return 0;
            }

            else
            {
                return -1;
            }
        }
    }
}
