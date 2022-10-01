using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num, result;
        int count;

        private void btn0_Click(object sender, EventArgs e)
        {
            if(txtBox.Text=="0")
            {
                txtBox.Clear();
            }
            txtBox.Text = txtBox.Text + 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Clear();
            }
            txtBox.Text = txtBox.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Clear();
            }
            txtBox.Text = txtBox.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Clear();
            }
            txtBox.Text = txtBox.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Clear();
            }
            txtBox.Text = txtBox.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Clear();
            }
            txtBox.Text = txtBox.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Clear();
            }
            txtBox.Text = txtBox.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Clear();
            }
            txtBox.Text = txtBox.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Clear();
            }
            txtBox.Text = txtBox.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Clear();
            }
            txtBox.Text = txtBox.Text + 9;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtBox.Text);
            txtBox.Clear();
            txtBox.Focus();
            count = 1;
        }
        
        private void btnminus_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "")
            {
                num = float.Parse(txtBox.Text);
                txtBox.Clear();
                txtBox.Focus();
                count = 2;
            }
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtBox.Text);
            txtBox.Clear();
            txtBox.Focus();
            count = 3;
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtBox.Text);
            txtBox.Clear();
            txtBox.Focus();
            count = 4;
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    result = num + float.Parse(txtBox.Text);
                    txtBox.Text = result.ToString();
                    break;
                case 2:
                    result = num - float.Parse(txtBox.Text);
                    txtBox.Text = result.ToString();
                    break;
                case 3:
                    result = num * float.Parse(txtBox.Text);
                    txtBox.Text = result.ToString();
                    break;
                case 4:
                    result = num / float.Parse(txtBox.Text);
                    txtBox.Text = result.ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            int c = txtBox.TextLength;
            int flag = 0;
            string text = txtBox.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                txtBox.Text = txtBox.Text + ".";
            }
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if(txtBox.Text.Length > 0)
            {
                txtBox.Text=txtBox.Text.Remove(txtBox.Text.Length-1, 1);
            }
            else if(txtBox.Text.Length == 0)
            {
                txtBox.Text = "";
            }   
        }

        private void btnpercent_Click(object sender, EventArgs e)
        {
            result=float.Parse(txtBox.Text);
            result = result / 100;
            txtBox.Text=result.ToString();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
            count = 0;
        }
        

    }
}
