using System;
using System.Collections.Generic;
namespace Lab04
{
    public class Storage : Main_CPU
    {
        public Storage()
        {
        }

        List<Array> PartsList()
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
