using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCalculators
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string preOps = "", preEq = "", ops = "";
        public static double answer = 0;
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kryptonCalc f1 = new kryptonCalc();
            this.Close();
            f1.ShowDialog();
            
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textDisplay2_TextChanged(object sender, EventArgs e)
        {

        }
        private void AllButtonCLick(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "buttonDel":
                    if (textDisplay.Text.Length > 0)
                    {
                        textDisplay.Text = textDisplay.Text.Substring(0, textDisplay.Text.Length - 1);
                    }
                    break;

                case "buttonC":
                    ops = "";
                    textDisplay.ResetText();
                    textDisplay2.ResetText();
                    break;

                case "buttonCE":
                    textDisplay.ResetText();

                    break;

                case "buttonDot":
                    if (!textDisplay.Text.Contains("."))
                        textDisplay.Text += ".";
                    break;

                case "buttonPulsMin":
                    if (textDisplay.Text.Length > 0)
                    {
                        if (!textDisplay.Text.Contains("-"))
                        {
                            textDisplay.Text = "-" + textDisplay.Text;
                        }
                        else if (textDisplay.Text.Contains("-"))
                        {
                            textDisplay.Text = textDisplay.Text.Substring(1, textDisplay.Text.Length - 1);
                        }

                    }
                    break;
                default:
                    if (ops == "=")
                    {
                        ops = "";
                        textDisplay.ResetText();
                    }
                    textDisplay.Text += btn.Text;

                    break;

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kryptonCalc f1 = new kryptonCalc();
            f1.Close();
            this.Close();
            System.Environment.Exit(1);
            
        }

        private void pi_Click(object sender, EventArgs e)
        {
            double val = Math.PI;
            textDisplay.Text = val.ToString();
        }

        private void sin_Click(object sender, EventArgs e)
        {
            double val = double.Parse(textDisplay.Text);
            val = Math.Sin(val);
            textDisplay.Text = val.ToString();
        }

        private void log_Click(object sender, EventArgs e)
        {
            double val = double.Parse(textDisplay.Text);
            val = Math.Log10(val);
            textDisplay.Text = val.ToString();
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            double val = double.Parse(textDisplay.Text);
            val = Math.Sqrt(val);
            textDisplay.Text = val.ToString();
        }

        private void xto2_Click(object sender, EventArgs e)
        {
            double val = double.Parse(textDisplay.Text);
            val = Math.Pow(val, 2);
            textDisplay.Text = val.ToString();
        }

        private void sinh_Click(object sender, EventArgs e)
        {
            double val = double.Parse(textDisplay.Text);
            val = Math.Sinh(val);
            textDisplay.Text = val.ToString();
        }

        private void cos_Click(object sender, EventArgs e)
        {
            double val = double.Parse(textDisplay.Text);
            val = Math.Cos(val);
            textDisplay.Text = val.ToString();
        }

        private void tan_Click(object sender, EventArgs e)
        {
            double val = double.Parse(textDisplay.Text);
            val = Math.Tan(val);
            textDisplay.Text = val.ToString();
        }

        private void cosh_Click(object sender, EventArgs e)
        {
            double val = double.Parse(textDisplay.Text);
            val = Math.Cosh(val);
            textDisplay.Text = val.ToString();
        }

        private void tanh_Click(object sender, EventArgs e)
        {
            double val = double.Parse(textDisplay.Text);
            val = Math.Tanh(val);
            textDisplay.Text = val.ToString();
        }

        private void dec_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textDisplay.Text);
                textDisplay.Text = System.Convert.ToString(num, 10);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xto3_Click(object sender, EventArgs e)
        {
            double val = double.Parse(textDisplay.Text);
            val = Math.Pow(val, 3);
            textDisplay.Text = val.ToString();
        }

        private void hex_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textDisplay.Text);
                textDisplay.Text = System.Convert.ToString(num, 16);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bin_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textDisplay.Text);
                textDisplay.Text = System.Convert.ToString(num, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void oct_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textDisplay.Text);
                textDisplay.Text = System.Convert.ToString(num, 8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inv_Click(object sender, EventArgs e)
        {
            double val = double.Parse(textDisplay.Text);
            val = 1 / val;
            textDisplay.Text = val.ToString();

        }

        private void lnx_Click(object sender, EventArgs e)
        {
            double val = double.Parse(textDisplay.Text);
            val = Math.Log(val);
            textDisplay.Text = val.ToString();
        }

        private void OpsClick(object sender, EventArgs e)
        {
            Button opsBtn = sender as Button;
            switch (opsBtn.Text)
            {
                case "+":
                    if (textDisplay.Text.Length > 0)
                    {
                        if (ops == "" || ops == "=")
                        {
                            ops = "+";
                            preOps = ops;
                            preEq = textDisplay.Text;
                            // textDisplay.ResetText();
                            textDisplay2.Text = preEq + ops;
                            textDisplay.ResetText();

                        }
                        else
                        {
                            ops = "+";
                            multiEquation();
                        }
                    }
                    break;

                case "-":
                    if (textDisplay.Text.Length > 0)
                    {
                        if (ops == "" || ops == "=")
                        {
                            ops = "-";
                            preOps = ops;
                            preEq = textDisplay.Text;
                            textDisplay2.Text = preEq + ops;
                            textDisplay.ResetText();

                        }
                        else
                        {
                            ops = "-";
                            multiEquation();
                        }
                    }
                    break;

                case "/":
                    if (textDisplay.Text.Length > 0)
                    {
                        if (ops == "" || ops == "=")
                        {
                            ops = "/";
                            preOps = ops;
                            preEq = textDisplay.Text;
                            textDisplay2.Text = preEq + ops;
                            textDisplay.ResetText();

                        }
                        else
                        {
                            ops = "/";
                            multiEquation();
                        }
                    }
                    break;

                case "X":
                    if (textDisplay.Text.Length > 0)
                    {
                        if (ops == "" || ops == "=")
                        {
                            ops = "X";
                            preOps = ops;
                            preEq = textDisplay.Text;
                            textDisplay2.Text = preEq + ops;
                            textDisplay.ResetText();

                        }
                        else
                        {
                            ops = "X";
                            multiEquation();
                        }
                    }
                    break;

                case "=":
                    if (textDisplay.Text.Length > 0)
                    {
                        ops = "=";
                        multiEquation();
                        textDisplay2.ResetText();
                        textDisplay.Text = answer.ToString();
                    }
                    break;
                
            }
        }

        private void mod_Click(object sender, EventArgs e)
        {
            if(textDisplay.Text.Length>0)
            {
                ops = "mod";
                preOps = ops;
                preEq = textDisplay.Text;
                textDisplay2.Text = preEq + ops;
                textDisplay.ResetText();
            }
            else
            {
                ops = "mod";
            }
        }

        private void pCent_Click(object sender, EventArgs e)
        {
            double val = double.Parse(textDisplay.Text);
            val = val / 100;
            textDisplay.Text = val.ToString();
        }

        private void EClick(object sender, EventArgs e)
        {
            double val=double.Parse(textDisplay.Text);
            val = val * 2.718281828;
            textDisplay2.Text = textDisplay.Text + "e";
            textDisplay.Text = val.ToString();
            
        }
        private void multiEquation()
        {
            if (preOps == "+")
            {
                preOps = ops;
                answer = Convert.ToDouble(preEq) + Convert.ToDouble(textDisplay.Text);
                preEq = answer.ToString();
                // textDisplay2.Text = preEq + ops;
                // textDisplay.ResetText();
                switch (preOps)
                {
                    case "+":
                        textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "+";
                        textDisplay.ResetText();
                        break;
                    case "-":
                        textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "-";
                        textDisplay.ResetText();
                        break;
                    case "/":
                        textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "/";
                        textDisplay.ResetText();
                        break;
                    case "X":
                        textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "X";
                        textDisplay.ResetText();
                        break;
                }
                //textDisplay2.Text =textDisplay2.Text + textDisplay.Text+"+" ;
                //textDisplay.ResetText();
            }
            else if (preOps == "-")
            {
                preOps = ops;
                answer = Convert.ToDouble(preEq) - Convert.ToDouble(textDisplay.Text);
                preEq = answer.ToString();
                // textDisplay2.Text = preEq + ops;
                //textDisplay.ResetText();
                switch (preOps)
                {
                    case "+":
                        textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "+";
                        textDisplay.ResetText();
                        break;
                    case "-":
                        textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "-";
                        textDisplay.ResetText();
                        break;
                    case "/":
                        textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "/";
                        textDisplay.ResetText();
                        break;
                    case "X":
                        textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "X";
                        textDisplay.ResetText();
                        break;
                }
                //textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "-";
                //textDisplay.ResetText();
            }
            else if (preOps == "/")
            {
                preOps = ops;
                answer = Convert.ToDouble(preEq) / Convert.ToDouble(textDisplay.Text);
                preEq = answer.ToString();
                // textDisplay2.Text = preEq + ops;
                //textDisplay.ResetText();
                switch (preOps)
                {
                    case "+":
                        textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "+";
                        textDisplay.ResetText();
                        break;
                    case "-":
                        textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "-";
                        textDisplay.ResetText();
                        break;
                    case "/":
                        textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "/";
                        textDisplay.ResetText();
                        break;
                    case "X":
                        textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "X";
                        textDisplay.ResetText();
                        break;
                }
                // textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "/";
                //textDisplay.ResetText();
            }
            else if (preOps == "X")
            {
                preOps = ops;
                answer = Convert.ToDouble(preEq) * Convert.ToDouble(textDisplay.Text);
                preEq = answer.ToString();
                //textDisplay2.Text = preEq + ops;
                //textDisplay.ResetText();
                switch (preOps)
                {
                    case "+":
                        textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "+";
                        textDisplay.ResetText();
                        break;
                    case "-":
                        textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "-";
                        textDisplay.ResetText();
                        break;
                    case "/":
                        textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "/";
                        textDisplay.ResetText();
                        break;
                    case "X":
                        textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "X";
                        textDisplay.ResetText();
                        break;
                }
                //textDisplay2.Text = textDisplay2.Text + textDisplay.Text + "X";
                //textDisplay.ResetText();
            }
            else if(preOps=="mod")
            {
                preOps = ops;
                answer = Convert.ToDouble(preEq) % Convert.ToDouble(textDisplay.Text);
                preEq = answer.ToString();
            }
        }
    }
}
