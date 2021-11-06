using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kargar_DFA.DFA_Steps
{
    class DStep : IStep
    {
        public bool IsFinal => false;

        public IStep NextStep(char input)
        {
            if (input == '1')
                return new DStep();
            if (input == '0')
                return new DStep();
            throw new Exception("InValid Input");
        }
    }
}
