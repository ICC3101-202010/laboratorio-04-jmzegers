using System;
namespace Lab04
{
    public class Quality_verif : Main_CPU 
    {
        public Quality_verif()
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
