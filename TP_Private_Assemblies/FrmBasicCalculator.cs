using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace TP_Private_Assemblies
{
    public partial class FrmBasicCalculator : Form
    {

        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           switch (cbSymbols.Text.ToString())
            {
                case "+":
                    float Addends = BasicComputation.Add((float)Convert.ToDouble(txtBoxInput1.Text), (float)Convert.ToDouble(txtBoxInput2.Text));
                    lblResult.Text = Addends.ToString();
                    break;

                case "-":
                    float Difference = BasicComputation.Substract((float)Convert.ToDouble(txtBoxInput1.Text), (float)Convert.ToDouble(txtBoxInput2.Text));
                    lblResult.Text = Difference.ToString();
                    break;

                case "*":
                    float Product = BasicComputation.Multiply((float)Convert.ToDouble(txtBoxInput1.Text), (float)Convert.ToDouble(txtBoxInput2.Text));
                    lblResult.Text = Product.ToString();
                    break;

                case "/":
                    float Quotient = BasicComputation.Divide((float)Convert.ToDouble(txtBoxInput1.Text), (float)Convert.ToDouble(txtBoxInput2.Text));
                    lblResult.Text = Quotient.ToString();
                    break;

            }
        }
    }
}
