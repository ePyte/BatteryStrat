using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryStrat
{
    public class Context
    {
        private IStrategy? _strategy = null;

        public Context() { }


        public Context(IStrategy strategy)//can be set
        {
            this._strategy = strategy;
        }

  
        public void SetStrategy(IStrategy strategy)//can be changed
        {
            this._strategy = strategy;
        }


        public void PerformOperations()
        {
            if (_strategy == null)
            {
                Console.WriteLine("Please set a strategy.");
                return; 
            }

            this._strategy.SendInfo();
            this._strategy.ChangeBackLight();
        }


    }
}
