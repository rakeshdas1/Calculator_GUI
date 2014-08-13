using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class CalcGUI : Form
    {
        public CalcGUI()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtInput2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int firstNum = int.Parse(txtInput1.Text);
            int secNum = int.Parse(txtInput2.Text);
            if( cbxOp.SelectedIndex==0)
            {
            int ans = firstNum + secNum;
            lblAns.Text = " Your answer is " + ans.ToString();
            }
            if (cbxOp.SelectedIndex == 1)
            {
                int ans = firstNum - secNum;
                lblAns.Text = " Your answer is " + ans.ToString();
            }
            if (cbxOp.SelectedIndex == 2)
            {
                int ans = firstNum * secNum;
                lblAns.Text = " Your answer is " + ans.ToString();
            }
            if (cbxOp.SelectedIndex == 3)
            {
                int ans = firstNum / secNum;
                lblAns.Text = " Your answer is " + ans.ToString();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CalcGUI_Load(object sender, EventArgs e)
        {
            cbxOp.SelectedIndex = 0;
        }

        private void txtInput1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
    }
}
