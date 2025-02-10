using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryStrat
{
    public interface IStrategy
    {
        public void SendInfo();
        public void ChangeBackLight();
    }
}
