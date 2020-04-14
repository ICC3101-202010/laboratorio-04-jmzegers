using System;
namespace Lab04
{
    public class Reception : Main_CPU
    {
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

        public int numParte1;
        public int numParte2;
        public int numParte3;

        public Reception(int numParte1, int numParte2, int numParte3)
        {
            this.numParte1 = numParte1;
            this.numParte2 = numParte2;
            this.numParte3 = numParte3;
        }
    }
}
