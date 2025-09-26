namespace Evaluator.UI.Windows
{
    public partial class txtDisplay : Form
    {
        public txtDisplay()
        {
            InitializeComponent();
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
            textBox1.Size = new Size(560, 43);
            textBox1.TabIndex = 0;
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
            btn7.Click += btn7_Click;
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
            //
            // txtDisplay
            //
            AccessibleName = "";
            ClientSize = new Size(576, 531);
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
            Name = "txtDisplay";
            Text = "Function Evaluator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnDot;
        private Button btn0;
        private Button btnResult;
        private Button btnOpenParenthesis;
        private Button btnPlus;
        private Button btnDivide;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnCloseParenthesis;
        private Button btnClear;
        private Button btnDelete;
        private Button btnPow;
        private TextBox textBox1;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btn7_Click(object sender, EventArgs e)
        {
        }
    }
}