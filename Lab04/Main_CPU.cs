using System;

namespace Lab04
{
    public abstract class Main_CPU
    {
        abstract protected bool TurnOn(string key);
        abstract protected bool Restart(string key);
        abstract protected bool TurnOff(string key);

        protected static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
