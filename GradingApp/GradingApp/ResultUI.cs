using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingApp
{
    public partial class ResultUI : Form
    {
        public ResultUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Marks marks=new Marks();
            float average = marks.showAverage(Convert.ToInt16(physicstextBox.Text),
                Convert.ToInt16(ChemistrytextBox.Text), Convert.ToInt16(mathtextBox.Text));
            gradetextBox.Text = marks.CalculateGrade(average);
            averagetextBox.Text = average.ToString();
        }
    }
}
