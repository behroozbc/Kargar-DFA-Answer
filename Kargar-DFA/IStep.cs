using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kargar_DFA
{
    public interface IStep
    {
        bool IsFinal { get; }
        IStep NextStep(char input);
    }
}
