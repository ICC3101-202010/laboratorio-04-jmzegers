using System;
namespace Lab04
{
    public class Packaging : Main_CPU
    {
        public Packaging()
        {
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
