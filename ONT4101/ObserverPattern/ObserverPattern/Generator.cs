using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
  public  class Generator
    {
       static readonly Random gen = new Random();

    
        public int getRandom()
        {
            return gen.Next(1, 1001);
        }

    }
}
