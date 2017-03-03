using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGenPrac
{
  public static  class Logger
    {
        static string path = "log.txt";

        public static void Write(string text)
        {
            CheckIfFileExists();
            using (StreamWriter file = File.AppendText(path))
            {
                file.Write(text);
            }
        }

        public static void Writeline(string text = "")
        {
            CheckIfFileExists();
            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(text);
            }
        }

        private static void CheckIfFileExists()
        {
            if (!File.Exists(path))
            {
                using(StreamWriter sw  = File.CreateText(path))
                {
                    sw.WriteLine("Generic Algorithm");
                }
            }
        }
    }
}
