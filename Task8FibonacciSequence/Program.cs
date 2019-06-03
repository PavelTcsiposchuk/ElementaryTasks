using System;

namespace Task8FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = GetReadyArgument(args);
            FibonacciSequence naturalNumberSequence = new FibonacciSequence(range);
            UI.PrintResult(range, naturalNumberSequence.GetFibonacciSequence());

            Console.ReadLine();
        }

        private static int GetReadyArgument(string[] args)
        {
            int readyArgs;

            if (!Validator.CheckArgument(args,out readyArgs))
            {
                UI.ShowInstruction();
                readyArgs = UI.GetNaturalNumberFromConsole();
            }

            return readyArgs;
        }

    }
}
