using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public string firstNumber = string.Empty;
        public string secondNumber = string.Empty;
        public string operation = string.Empty;
        public string result = string.Empty;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            firstNumber = txtBoxFirstNumber.Text;
            secondNumber = txtBoxSecondNumber.Text;
            operation = dropDownCombo.SelectedItem.ToString();
            //lblResult.Text = "The result is : "
            labelResult.Visible = true;
            txtBoxResult.Visible = true;
            txtBoxResult.Text= Program.ComputeOperation(firstNumber, secondNumber, operation);

        }
    }
}
