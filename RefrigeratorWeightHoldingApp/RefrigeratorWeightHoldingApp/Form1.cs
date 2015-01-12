using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorWeightHoldingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Refrigerator aRefrigerator;
        private void saveButton_Click(object sender, EventArgs e)
        {
            aRefrigerator=new Refrigerator(Convert.ToDouble(maxTextBox.Text));

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            double noofItems = Convert.ToDouble(noofItemsTextBox.Text);
            double weightPerUnit = Convert.ToDouble(weightTextBox.Text);
          
            try
            {
                aRefrigerator.AddItems(noofItems, weightPerUnit);
                currentWeightTextBox.Text = aRefrigerator.currentWeight.ToString();
                remainingTextBox.Text = aRefrigerator.RemainingWeight.ToString();
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show("Over Flowed...");
            }
            
        }
    }
}
