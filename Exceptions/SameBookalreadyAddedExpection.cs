using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13.Exceptions
{
    class SameBookalreadyAddedExpection : Exception
    {
        public SameBookalreadyAddedExpection(string message) : base(message)
        {

        }
    }
}
