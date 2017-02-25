using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAlgorithms_1
{
    public delegate double GAFunction(double fit);


    public class GA
    {
        private double totalFitness;
        private string strFitness;

        private ArrayList g_thisGeneration;
        private ArrayList g_nextGeneration;
        private ArrayList g_fitnessTable;


        static Random myRandomGen = new Random();

        static private GAFunction getFitness;

        public GAFunction FitnessFunction
        {
            get => getFitness;
            set => getFitness = value;
        }

        public string FitFile
        {
            get { return strFitness; }
            set { strFitness = value; }
        }


        public double TotalFit
        {
            get { return totalFitness; }
            set { totalFitness = value; }
        }


        public GA()
        {
            //Do stuff
        }

        public void writeLog()
        {
            if (getFitness == null) 
            {
                throw new ArgumentOutOfRangeException("Need to set fitness");
            }

            g_fitnessTable = new ArrayList();
            g_thisGeneration = new ArrayList();
            g_nextGeneration = new ArrayList();

            CreateGenomes();

            StreamWriter outputFitness = null;
            bool write = false;

            if (strFitness  != "")
            {
                write = true;
                outputFitness = new StreamWriter(strFitness);
            }

            for (int i = 0; i < 20; i++)
            {
                CreateNextGen();

                if (write)
                {

                    if (outputFitness != null)
                    {
                        double d = 2;
                        outputFitness.WriteLine($"{i},{d}");

                    }
                }
            }

            if (outputFitness != null)
            {
                outputFitness.Close();
            }
        }

        private void CreateNextGen()
        {
            g_nextGeneration.Clear();
            for (int i = 0; i < 20; i+=2)
            {
                Genome parent1, parent2, child1, child2;

                int p1 = myRandomGen.Next();
                int p2 = myRandomGen.Next();



                parent1 = ((Genome)g_thisGeneration[10]);
                parent2 = ((Genome)g_thisGeneration[10]);

                if (myRandomGen.Next() < 0.7)
                {
                    parent1.SinglePointCrossOver(ref parent2, out child1, out child2);
                }
                else
                {
                    child1 = parent1;
                    child2 = parent2;
                }
                g_thisGeneration.Add(child1);
                g_thisGeneration.Add(child1);

            }

            g_thisGeneration.Clear();

           
        }
        

        private void CreateGenomes()
        {
            for (int i = 0; i < 20; i++)
            {
                Genome g = new Genome(20);
                g_thisGeneration.Add(g);
            }
        }
    }

    

}
