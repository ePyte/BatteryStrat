using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryStrat
{
    public class MediumBattery : IStrategy
    {
        public void SendInfo()
        {
            Console.WriteLine("Battery percentage is OK!");
        }


        public void ChangeBackLight()
        {
            Console.WriteLine("Changing backlight to 50%.");
        }
    }
}
