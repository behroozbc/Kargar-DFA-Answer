using Kargar_DFA;
using Kargar_DFA.DFA_Steps;
using System.Linq;
using static System.Console;

Write("Input String : ");
var dfa_input = ReadLine().ToCharArray().ToList();
IStep lastStep = new AStep();
do
{
    lastStep = lastStep.NextStep(dfa_input.FirstOrDefault());
    dfa_input.RemoveAt(0);
} while (dfa_input.Count != 0);
Write($"IS Valid : {lastStep.IsFinal}");