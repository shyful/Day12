using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleSpeedCalculationApp
{
    public partial class VehicleSpeedCalculationUI : Form
    {
        public VehicleSpeedCalculationUI()
        {
            InitializeComponent();
        }

        private Vehicle vehicle;
        private void createButton_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(nameTextBox.Text);
            string regNo = Convert.ToString(regNoTextBox.Text);
            vehicle=new Vehicle(name,regNo);

            
        }

     

        private void enterButton_Click(object sender, EventArgs e)
        {
            vehicle.InputSpeed = Convert.ToDouble(speedTextBox.Text);
            vehicle.CalculateMaxSpeed();
            vehicle.CalculateMinSpeed();
            vehicle.CalculateAvrSpeed();

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            minSpeedextBox.Text = vehicle.MinSpeed.ToString();
            maxSpeedTextBox.Text = vehicle.MaxSpeed.ToString();
            avrgeSpeedTextBox.Text = vehicle.AvrSpeed.ToString();
        }
    }
}
