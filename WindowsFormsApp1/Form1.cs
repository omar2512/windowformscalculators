using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        float resultss;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text = btnadd.Text;
            if(num1 != null && num2 != null)
            {
                resultss = float.Parse((num1.Text)) + float.Parse((num2.Text));

                result.Text = resultss.ToString();
            }
            else
            {
                MessageBox.Show("check if the two numbers are entered");
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text = btnminus.Text;
            if (num1 != null && num2 != null)
            {
                resultss = float.Parse((num1.Text)) - float.Parse((num2.Text));

                result.Text = resultss.ToString();
            }
            else
            {
                MessageBox.Show("check if the two numbers are entered");
            }
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text = btnmulti.Text;
            if (num1 != null && num2 != null)
            {
                resultss = float.Parse((num1.Text)) * float.Parse((num2.Text));

                result.Text = resultss.ToString();
            }
            else
            {
                MessageBox.Show("check if the two numbers are entered");
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text = btndiv.Text;

            if (num1 != null && num2 != null)
            {
                if (int.Parse(num2.Text) == 0)
                {
                    MessageBox.Show("cant divsion by zero");
                }
                else
                {
                    resultss = float.Parse((num1.Text)) / float.Parse((num2.Text));

                    result.Text = resultss.ToString();
                }
            }
            else
            {
                MessageBox.Show("check if the two numbers are entered");
            }   }
    }
}
