using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Card
    { 
        public int Element;

        public int Location;

        public Card(int AtomicId)
        {
            Element = AtomicId;
        }

        public int ReturnValue()
        {
            return Element;
        }

        public Locate(int Local)
        {
            Local = Location;
        }
    }
}
