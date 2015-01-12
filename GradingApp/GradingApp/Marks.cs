using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingApp
{
    class Marks
    {
        public float Physics { get; set; }
        public float Chemistry { get;  set; }
        public float Math { get; set; }

        public float showAverage(float physics, float chemistry, float math)
        {
            this.Physics = physics;
            float average= (physics + chemistry + math)/3;
            return average;
        }

        public string CalculateGrade(float Total)
        {
            string grade;
            if (Total >= 80 && Total <= 100)
            {
                grade = "A+";
            }
            else if (Total >= 70 && Total < 80)
            {
                grade = "B+";
            }
            else if (Total >= 60 && Total < 70)
            {
                grade = "C+";
            }
            else if (Total >= 50 && Total < 60)
            {
                grade = "D+";
            }
            else
            {
                grade = "F+";
            }
            return grade;  
        }
    }

}
