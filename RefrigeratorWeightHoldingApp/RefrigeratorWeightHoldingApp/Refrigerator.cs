using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorWeightHoldingApp
{
    class Refrigerator
    {
        public double MaxWeight { get; set; }
        public double currentWeight { get; private set; }


        public Refrigerator(double maxWeight)
        {
            MaxWeight = maxWeight;
        }
        public double RemainingWeight
        {
            get { return MaxWeight - currentWeight; }
        }

        public void AddItems(double noofItems,double weightperUnit)
        {
            double itemstobeAdded = noofItems*weightperUnit;
            if (currentWeight+itemstobeAdded<=MaxWeight)
            {
                currentWeight += itemstobeAdded;    
            }
            else
            {
                throw new Exception("Over Flowed");
            }

            
        
        }
    }
}
