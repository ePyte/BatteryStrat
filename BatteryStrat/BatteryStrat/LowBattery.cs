using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryStrat
{
    public class LowBattery : IStrategy
    {


        public void SendInfo()
        {
            Console.WriteLine("Battery percentage is low!");
        }


        public void ChangeBackLight()
        {
            Console.WriteLine("Changing backlight to 10%.");
        }
    }
}
