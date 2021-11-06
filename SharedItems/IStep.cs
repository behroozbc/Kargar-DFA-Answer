

namespace Kargar_DFA
{
    public interface IStep
    {
        bool IsFinal { get; }
        IStep NextStep(char input);
    }
}
