using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryStrat
{
    public class HighBattery: IStrategy
    {
        public void SendInfo()
        {
            Console.WriteLine("Battery percentage is excellent!");
        }


        public void ChangeBackLight()
        {
            Console.WriteLine("Changing backlight to 100%.");
        }
    }
}
