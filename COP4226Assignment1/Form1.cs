using System;
using System.Data;
using System.Windows.Forms;

namespace COP4226Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendTextToTextBox(string str)
        {
            this.textBox1.Text += str;
        }

        private void ClearTextBox()
        {
            this.textBox1.Text = "";
        }

        private void CalculateResult(object sender, EventArgs e)
        {
            string text = this.textBox1.Text;
            DataTable dt = new DataTable();
            var v = new object();
            try
            {
                Console.WriteLine("text: ", text);
                v = dt.Compute(text, "");
                Console.WriteLine("v: ", v);
            }
            catch (Exception x)
            {
                v = "NaN";
                Console.WriteLine("exception e: ", x);
            }


            this.textBox1.Text = v.ToString();
        }

        private void AddButtonValueToTextBox(object sender, EventArgs e)
        {
            string buttonValue = (sender as Button).Text;
            this.SendTextToTextBox(buttonValue);
        }

        private void ClearButtonHandler(object sender, EventArgs e)
        {
            this.ClearTextBox();
        }
    }
}
