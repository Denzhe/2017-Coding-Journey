using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_pattern
{
    interface IGenerator
    {
        void Attach(IObserver Target);
        void Detach(IObserver Target);
        void Notify();

    }
}
