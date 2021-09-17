
namespace COP4226Assignment1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numZero = new System.Windows.Forms.Button();
            this.numNine = new System.Windows.Forms.Button();
            this.numEight = new System.Windows.Forms.Button();
            this.numSeven = new System.Windows.Forms.Button();
            this.numSix = new System.Windows.Forms.Button();
            this.numFive = new System.Windows.Forms.Button();
            this.numFour = new System.Windows.Forms.Button();
            this.numThree = new System.Windows.Forms.Button();
            this.numTwo = new System.Windows.Forms.Button();
            this.numOne = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.Dec = new System.Windows.Forms.Button();
            this.leftParenthesis = new System.Windows.Forms.Button();
            this.rightParenthesis = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(8, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(328, 75);
            this.textBox1.TabIndex = 0;
            this.textBox1.Click += new System.EventHandler(this.ClearButtonHandler);
            // 
            // numZero
            // 
            this.numZero.Location = new System.Drawing.Point(8, 360);
            this.numZero.Margin = new System.Windows.Forms.Padding(2);
            this.numZero.Name = "numZero";
            this.numZero.Size = new System.Drawing.Size(79, 63);
            this.numZero.TabIndex = 1;
            this.numZero.Text = "0";
            this.numZero.UseVisualStyleBackColor = true;
            this.numZero.Click += new System.EventHandler(this.AddButtonValueToTextBox);
            // 
            // numNine
            // 
            this.numNine.Location = new System.Drawing.Point(173, 159);
            this.numNine.Margin = new System.Windows.Forms.Padding(2);
            this.numNine.Name = "numNine";
            this.numNine.Size = new System.Drawing.Size(79, 63);
            this.numNine.TabIndex = 2;
            this.numNine.Text = "9";
            this.numNine.UseVisualStyleBackColor = true;
            this.numNine.Click += new System.EventHandler(this.AddButtonValueToTextBox);
            // 
            // numEight
            // 
            this.numEight.Location = new System.Drawing.Point(91, 159);
            this.numEight.Margin = new System.Windows.Forms.Padding(2);
            this.numEight.Name = "numEight";
            this.numEight.Size = new System.Drawing.Size(79, 63);
            this.numEight.TabIndex = 3;
            this.numEight.Text = "8";
            this.numEight.UseVisualStyleBackColor = true;
            this.numEight.Click += new System.EventHandler(this.AddButtonValueToTextBox);
            // 
            // numSeven
            // 
            this.numSeven.Location = new System.Drawing.Point(8, 159);
            this.numSeven.Margin = new System.Windows.Forms.Padding(2);
            this.numSeven.Name = "numSeven";
            this.numSeven.Size = new System.Drawing.Size(79, 63);
            this.numSeven.TabIndex = 4;
            this.numSeven.Text = "7";
            this.numSeven.UseVisualStyleBackColor = true;
            this.numSeven.Click += new System.EventHandler(this.AddButtonValueToTextBox);
            // 
            // numSix
            // 
            this.numSix.Location = new System.Drawing.Point(173, 226);
            this.numSix.Margin = new System.Windows.Forms.Padding(2);
            this.numSix.Name = "numSix";
            this.numSix.Size = new System.Drawing.Size(79, 63);
            this.numSix.TabIndex = 5;
            this.numSix.Text = "6";
            this.numSix.UseVisualStyleBackColor = true;
            this.numSix.Click += new System.EventHandler(this.AddButtonValueToTextBox);
            // 
            // numFive
            // 
            this.numFive.Location = new System.Drawing.Point(91, 226);
            this.numFive.Margin = new System.Windows.Forms.Padding(2);
            this.numFive.Name = "numFive";
            this.numFive.Size = new System.Drawing.Size(79, 63);
            this.numFive.TabIndex = 6;
            this.numFive.Text = "5";
            this.numFive.UseVisualStyleBackColor = true;
            this.numFive.Click += new System.EventHandler(this.AddButtonValueToTextBox);
            // 
            // numFour
            // 
            this.numFour.Location = new System.Drawing.Point(8, 226);
            this.numFour.Margin = new System.Windows.Forms.Padding(2);
            this.numFour.Name = "numFour";
            this.numFour.Size = new System.Drawing.Size(79, 63);
            this.numFour.TabIndex = 7;
            this.numFour.Text = "4";
            this.numFour.UseVisualStyleBackColor = true;
            this.numFour.Click += new System.EventHandler(this.AddButtonValueToTextBox);
            // 
            // numThree
            // 
            this.numThree.Location = new System.Drawing.Point(173, 293);
            this.numThree.Margin = new System.Windows.Forms.Padding(2);
            this.numThree.Name = "numThree";
            this.numThree.Size = new System.Drawing.Size(79, 63);
            this.numThree.TabIndex = 8;
            this.numThree.Text = "3";
            this.numThree.UseVisualStyleBackColor = true;
            this.numThree.Click += new System.EventHandler(this.AddButtonValueToTextBox);
            // 
            // numTwo
            // 
            this.numTwo.Location = new System.Drawing.Point(91, 293);
            this.numTwo.Margin = new System.Windows.Forms.Padding(2);
            this.numTwo.Name = "numTwo";
            this.numTwo.Size = new System.Drawing.Size(79, 63);
            this.numTwo.TabIndex = 9;
            this.numTwo.Text = "2";
            this.numTwo.UseVisualStyleBackColor = true;
            this.numTwo.Click += new System.EventHandler(this.AddButtonValueToTextBox);
            // 
            // numOne
            // 
            this.numOne.Location = new System.Drawing.Point(8, 293);
            this.numOne.Margin = new System.Windows.Forms.Padding(2);
            this.numOne.Name = "numOne";
            this.numOne.Size = new System.Drawing.Size(79, 63);
            this.numOne.TabIndex = 10;
            this.numOne.Text = "1";
            this.numOne.UseVisualStyleBackColor = true;
            this.numOne.Click += new System.EventHandler(this.AddButtonValueToTextBox);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(256, 159);
            this.divide.Margin = new System.Windows.Forms.Padding(2);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(79, 63);
            this.divide.TabIndex = 11;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.AddButtonValueToTextBox);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(256, 226);
            this.multiply.Margin = new System.Windows.Forms.Padding(2);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(79, 63);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.AddButtonValueToTextBox);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(256, 293);
            this.minus.Margin = new System.Windows.Forms.Padding(2);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(79, 63);
            this.minus.TabIndex = 13;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.AddButtonValueToTextBox);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(256, 360);
            this.plus.Margin = new System.Windows.Forms.Padding(2);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(79, 63);
            this.plus.TabIndex = 14;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.AddButtonValueToTextBox);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(173, 360);
            this.equals.Margin = new System.Windows.Forms.Padding(2);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(79, 63);
            this.equals.TabIndex = 15;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.CalculateResult);
            // 
            // Dec
            // 
            this.Dec.Location = new System.Drawing.Point(91, 360);
            this.Dec.Margin = new System.Windows.Forms.Padding(2);
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(79, 63);
            this.Dec.TabIndex = 16;
            this.Dec.Text = ".";
            this.Dec.UseVisualStyleBackColor = true;
            this.Dec.Click += new System.EventHandler(this.AddButtonValueToTextBox);
            // 
            // leftParenthesis
            // 
            this.leftParenthesis.Location = new System.Drawing.Point(91, 92);
            this.leftParenthesis.Margin = new System.Windows.Forms.Padding(2);
            this.leftParenthesis.Name = "leftParenthesis";
            this.leftParenthesis.Size = new System.Drawing.Size(79, 63);
            this.leftParenthesis.TabIndex = 17;
            this.leftParenthesis.Text = "(";
            this.leftParenthesis.UseVisualStyleBackColor = true;
            this.leftParenthesis.Click += new System.EventHandler(this.AddButtonValueToTextBox);
            // 
            // rightParenthesis
            // 
            this.rightParenthesis.Location = new System.Drawing.Point(173, 92);
            this.rightParenthesis.Margin = new System.Windows.Forms.Padding(2);
            this.rightParenthesis.Name = "rightParenthesis";
            this.rightParenthesis.Size = new System.Drawing.Size(79, 63);
            this.rightParenthesis.TabIndex = 18;
            this.rightParenthesis.Text = ")";
            this.rightParenthesis.UseVisualStyleBackColor = true;
            this.rightParenthesis.Click += new System.EventHandler(this.AddButtonValueToTextBox);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(256, 92);
            this.reset.Margin = new System.Windows.Forms.Padding(2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(79, 63);
            this.reset.TabIndex = 19;
            this.reset.Text = "clear";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.ClearButtonHandler);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 432);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.rightParenthesis);
            this.Controls.Add(this.leftParenthesis);
            this.Controls.Add(this.Dec);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.numOne);
            this.Controls.Add(this.numTwo);
            this.Controls.Add(this.numThree);
            this.Controls.Add(this.numFour);
            this.Controls.Add(this.numFive);
            this.Controls.Add(this.numSix);
            this.Controls.Add(this.numSeven);
            this.Controls.Add(this.numEight);
            this.Controls.Add(this.numNine);
            this.Controls.Add(this.numZero);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button numZero;
        private System.Windows.Forms.Button numNine;
        private System.Windows.Forms.Button numEight;
        private System.Windows.Forms.Button numSeven;
        private System.Windows.Forms.Button numSix;
        private System.Windows.Forms.Button numFive;
        private System.Windows.Forms.Button numFour;
        private System.Windows.Forms.Button numThree;
        private System.Windows.Forms.Button numTwo;
        private System.Windows.Forms.Button numOne;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button Dec;
        private System.Windows.Forms.Button leftParenthesis;
        private System.Windows.Forms.Button rightParenthesis;
        private System.Windows.Forms.Button reset;
    }
}

