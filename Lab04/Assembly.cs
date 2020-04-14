using System;
using System.Collections.Generic;
namespace Lab04
{
    public class Assembly : Main_CPU
    {
        public Assembly()
        {
            int[] ToyCar = new int[3];

        }

        protected override bool TurnOn(string key)
        {
            if (key == "si")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override bool Restart(string key)
        {
            if (key == "si")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override bool TurnOff(string key)
        {
            if (key == "si")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
