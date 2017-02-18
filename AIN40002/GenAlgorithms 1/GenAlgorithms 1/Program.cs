using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAlgorithms_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Genome Mother, Father;
            Mother = new Genome();
            Father = new Genome();

            SinglePointCrossOver(Mother, Father);

        }

        private static void SinglePointCrossOver(Genome mother, Genome father)
        {
            throw new NotImplementedException();
        }
    }
}
