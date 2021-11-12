using System;
using static System.Console;
using System.Linq;

Write("Input String : ");
var dfa_input = ReadLine().ToCharArray().ToList();
if (dfa_input.Count != 4)
{
    WriteLine("InValid Input");
    return;
}
var IsSafe = true;
var result = true;
for (int i = 1; i < dfa_input.Count(); i++)
{
    if (dfa_input[i] == '1')
    {
        IsSafe = true;
        continue;
    }
    if (dfa_input[i - 1] == '0' && dfa_input[i] == '0' && IsSafe)
    {
        IsSafe = false;
        continue;
    }
    if(IsSafe==false)
    {
        result = false;
        break;
    }
}
if (result == false)
    WriteLine("Input is not valid");
else
    WriteLine("Input is Valid");