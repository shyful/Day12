using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleSpeedCalculationApp
{
    class Vehicle
    {
        private string name;
        private string regNo;
        private double minSpeed;
        private double inputSpeed;
        private double maxSpeed;
        private double avrSpeed ;
        private int count;
        private double total;

        public string Name
        {
            set { name = value; }
           
        }

        public string RegNo
        {
            set { regNo = value; }
           
        }
    
     
        public double InputSpeed
        {
            set { inputSpeed = value; }
            
        }
        public double MinSpeed
        {
            
            get { return minSpeed; }
        }
        public double MaxSpeed
        {
      
            get { return maxSpeed; }
        }
        public double AvrSpeed
        {

            get { return avrSpeed; }
        }

        public Vehicle(string name, string regNo)
        {
            Name = name;
            RegNo = regNo;
        }
        public void CalculateMinSpeed()
        {
            if (inputSpeed < minSpeed || minSpeed == 0)
            {
                minSpeed = inputSpeed;
                
            }
        }
        public void CalculateMaxSpeed()
        {
            if (inputSpeed > maxSpeed)
            {
                maxSpeed = inputSpeed;

            }
            
        }

        public void CalculateAvrSpeed()
        {
            count++;
            total += inputSpeed;
            if (avrSpeed == 0)
            {
                avrSpeed = inputSpeed;
            }
            else
            {
                avrSpeed = total/count;
            }
    
        }

    }
}
