using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAlgorithms_1
{
    class Genome
    {
        private int[] dna;
        public double Fitness = 0;
      
        protected int[] DNA { get => dna; set => dna = value; }
    }
}
