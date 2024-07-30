using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1T2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Totalcircumference, TotalAreaCircle, TotalAreaSphere;
            double  Radius=double.Parse(txtRadius.Text);

            if (rbcircumference.Checked)
            {
                Totalcircumference = 2 * Math.PI*Radius;
                lblOutput.Text = string.Format("The circumference of the circle is {0}", Totalcircumference);

            }
            else if (rbAreaCircle.Checked)
            {
                TotalAreaCircle=Math.PI*Math.Pow(Radius,2);
                lblOutput.Text = string.Format("The Area of the circle is {0}", TotalAreaCircle);
            }
            else if(rbAreaSphere.Checked)
            {
                TotalAreaSphere=4*Math.PI * Math.Pow(Radius,2);
                lblOutput.Text = string.Format("The Area of the sphere is {0}", TotalAreaSphere);
            }
            Console.ReadLine(); 
        }
    }
}
