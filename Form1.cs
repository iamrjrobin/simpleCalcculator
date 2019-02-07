using System;
using System.Linq;
using System.Windows.Forms;

namespace NewCalculators
{
    public partial class kryptonCalc : Form
    {
        public kryptonCalc()
        {
            InitializeComponent();
        }
        public static string preOps = "", preEq = "", ops = "";
        public static double answer = 0;

        private void AllButtonCLick(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch(btn.Name)
            {
                case "buttonDel":
                    if(textDisplay.Text.Length>0)
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

                case"buttonPulsMin":
                    if(textDisplay.Text.Length>0)
                    {
                        if(!textDisplay.Text.Contains("-"))
                        {
                            textDisplay.Text = "-" + textDisplay.Text;
                        }
                        else if(textDisplay.Text.Contains("-"))
                        {
                            textDisplay.Text = textDisplay.Text.Substring(1, textDisplay.Text.Length - 1);
                        }

                    }
                    break;
                default:
                    if(ops=="=")
                    {
                        ops = "";
                        textDisplay.ResetText();
                    }
                    textDisplay.Text += btn.Text;

                    break;
                    
            }
        }
        private void kryptonCalc_Load(object sender, EventArgs e)
        {

        }

        private void textDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpsClick(object sender, EventArgs e)
        {
            Button opsBtn = sender as Button;
            switch(opsBtn.Text)
            {
                case "+":
                    if(textDisplay.Text.Length>0)
                    {
                        if(ops==""||ops=="=")
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
                            ops="+";
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
                    if(textDisplay.Text.Length>0)
                    {
                        ops = "=";
                        multiEquation();
                        textDisplay2.ResetText();
                        textDisplay.Text = answer.ToString();
                    }
                    break;
            }
        }

        private void multiEquation()
        {
            if(preOps=="+")
            {
                preOps = ops;
                answer = Convert.ToDouble(preEq) + Convert.ToDouble(textDisplay.Text);
                preEq = answer.ToString();
               // textDisplay2.Text = preEq + ops;
               // textDisplay.ResetText();
               switch(preOps)
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
            else if(preOps=="-")
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
        }
    }
}