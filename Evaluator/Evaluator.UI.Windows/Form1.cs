using Evaluator.Core;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Evaluator.UI.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            toolTip1 = new ToolTip(components);
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnResult = new Button();
            btnOpenParenthesis = new Button();
            btnPlus = new Button();
            btnDivide = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnCloseParenthesis = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnPow = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.Green;
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(512, 43);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.ForeColor = Color.Black;
            btn7.Location = new Point(12, 78);
            btn7.Name = "btn7";
            btn7.Size = new Size(72, 61);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberButton_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.ForeColor = Color.Black;
            btn8.Location = new Point(90, 78);
            btn8.Name = "btn8";
            btn8.Size = new Size(72, 61);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberButton_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.ForeColor = Color.Black;
            btn9.Location = new Point(168, 78);
            btn9.Name = "btn9";
            btn9.Size = new Size(72, 61);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberButton_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.ForeColor = Color.Black;
            btn6.Location = new Point(168, 145);
            btn6.Name = "btn6";
            btn6.Size = new Size(72, 61);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberButton_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.ForeColor = Color.Black;
            btn5.Location = new Point(90, 145);
            btn5.Name = "btn5";
            btn5.Size = new Size(72, 61);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberButton_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.ForeColor = Color.Black;
            btn4.Location = new Point(12, 145);
            btn4.Name = "btn4";
            btn4.Size = new Size(72, 61);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberButton_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.ForeColor = Color.Black;
            btn3.Location = new Point(168, 212);
            btn3.Name = "btn3";
            btn3.Size = new Size(72, 61);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberButton_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(90, 212);
            btn2.Name = "btn2";
            btn2.Size = new Size(72, 61);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberButton_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(12, 212);
            btn1.Name = "btn1";
            btn1.Size = new Size(72, 61);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberButton_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.ForeColor = Color.Black;
            btnDot.Location = new Point(168, 279);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(72, 61);
            btnDot.TabIndex = 12;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += DecimalButton_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.ForeColor = Color.Black;
            btn0.Location = new Point(12, 279);
            btn0.Name = "btn0";
            btn0.Size = new Size(150, 61);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += NumberButton_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(255, 128, 0);
            btnResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResult.ForeColor = Color.Black;
            btnResult.Location = new Point(246, 279);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(275, 61);
            btnResult.TabIndex = 16;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += EqualsButton_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnOpenParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenParenthesis.ForeColor = Color.Black;
            btnOpenParenthesis.Location = new Point(246, 212);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(72, 61);
            btnOpenParenthesis.TabIndex = 15;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += OperatorButton_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 128, 0);
            btnPlus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.ForeColor = Color.Black;
            btnPlus.Location = new Point(246, 145);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(72, 61);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += OperatorButton_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 128, 0);
            btnDivide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.ForeColor = Color.Black;
            btnDivide.Location = new Point(246, 78);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(72, 61);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += OperatorButton_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 128, 0);
            btnMinus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.ForeColor = Color.Black;
            btnMinus.Location = new Point(324, 145);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(72, 61);
            btnMinus.TabIndex = 18;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += OperatorButton_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 128, 0);
            btnMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.ForeColor = Color.Black;
            btnMultiply.Location = new Point(324, 78);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(72, 61);
            btnMultiply.TabIndex = 17;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += OperatorButton_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnCloseParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseParenthesis.ForeColor = Color.Black;
            btnCloseParenthesis.Location = new Point(324, 212);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(72, 61);
            btnCloseParenthesis.TabIndex = 19;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += OperatorButton_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(402, 145);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 61);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += ClearButton_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(402, 78);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 61);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += DeleteButton_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.FromArgb(255, 128, 0);
            btnPow.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPow.ForeColor = Color.Black;
            btnPow.Location = new Point(402, 212);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(119, 61);
            btnPow.TabIndex = 23;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += OperatorButton_Click;
            // 
            // Form1
            // 
            AccessibleName = "";
            ClientSize = new Size(528, 344);
            Controls.Add(btnPow);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnMinus);
            Controls.Add(btnMultiply);
            Controls.Add(btnResult);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnPlus);
            Controls.Add(btnDivide);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(textBox1);
            ForeColor = Color.White;
            Location = new Point(12, 12);
            Name = "Form1";
            Text = "Function Evaluator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        private Button btn7, btn8, btn9, btn6, btn5, btn4, btn3, btn2, btn1, btn0;
        private Button btnDot, btnResult, btnOpenParenthesis, btnPlus, btnDivide;
        private Button btnMinus, btnMultiply, btnCloseParenthesis, btnClear, btnDelete, btnPow;
        private TextBox textBox1;

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textBox1.Text == "0" || textBox1.Text == "Error")
            {
                textBox1.Text = btn.Text;
            }
            else
            {
                textBox1.Text += btn.Text;
            }
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (textBox1.Text == "0" && btn.Text == "(")
            {
                textBox1.Text = btn.Text;
            }
            else if (textBox1.Text != "Error")
            {
                textBox1.Text += btn.Text;
            }
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Error") return;

            // Check if there is already a decimal point in the current number
            string[] operators = { "+", "-", "*", "/", "^", "(", ")" };
            string lastNumber = textBox1.Text;

            foreach (string op in operators)
            {
                if (textBox1.Text.Contains(op))
                {
                    int lastIndex = textBox1.Text.LastIndexOfAny(op.ToCharArray());
                    lastNumber = textBox1.Text.Substring(lastIndex + 1);
                    break;
                }
            }

            if (!lastNumber.Contains('.'))
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "0.";
                }
                else
                {
                    textBox1.Text += ".";
                }
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            try
            {
                double result = ExpressionEvaluator.Evaluate(textBox1.Text);
                textBox1.Text = result.ToString();
            }
            catch (Exception)
            {
                textBox1.Text = "Error";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Error")
            {
                textBox1.Text = "0";
                return;
            }

            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}