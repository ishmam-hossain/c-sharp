namespace WindowsFormsTest
{
    partial class Calculator
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
            this.btnOne = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOneOverX = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btnModulas = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearEverything = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnDecimalPoint = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOne.CausesValidation = false;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnOne.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOne.Location = new System.Drawing.Point(9, 272);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(76, 41);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.btnOneOverX);
            this.panel1.Controls.Add(this.btnDivision);
            this.panel1.Controls.Add(this.btnMultiplication);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Controls.Add(this.btnEqual);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.btnSquare);
            this.panel1.Controls.Add(this.btnRoot);
            this.panel1.Controls.Add(this.btnModulas);
            this.panel1.Controls.Add(this.btnBackspace);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnClearEverything);
            this.panel1.Controls.Add(this.btnNine);
            this.panel1.Controls.Add(this.btnEight);
            this.panel1.Controls.Add(this.btnSeven);
            this.panel1.Controls.Add(this.btnSix);
            this.panel1.Controls.Add(this.btnFive);
            this.panel1.Controls.Add(this.btnDecimalPoint);
            this.panel1.Controls.Add(this.btnZero);
            this.panel1.Controls.Add(this.btnPlusMinus);
            this.panel1.Controls.Add(this.btnThree);
            this.panel1.Controls.Add(this.btnTwo);
            this.panel1.Controls.Add(this.btnFour);
            this.panel1.Controls.Add(this.btnOne);
            this.panel1.Location = new System.Drawing.Point(3, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 369);
            this.panel1.TabIndex = 1;
            // 
            // btnOneOverX
            // 
            this.btnOneOverX.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOneOverX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneOverX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnOneOverX.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOneOverX.Location = new System.Drawing.Point(255, 82);
            this.btnOneOverX.Name = "btnOneOverX";
            this.btnOneOverX.Size = new System.Drawing.Size(76, 41);
            this.btnOneOverX.TabIndex = 23;
            this.btnOneOverX.Text = "1/x";
            this.btnOneOverX.UseVisualStyleBackColor = false;
            this.btnOneOverX.Click += new System.EventHandler(this.btnOneOverX_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnDivision.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDivision.Location = new System.Drawing.Point(255, 129);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(76, 41);
            this.btnDivision.TabIndex = 22;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMultiplication.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMultiplication.Location = new System.Drawing.Point(255, 176);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(76, 41);
            this.btnMultiplication.TabIndex = 21;
            this.btnMultiplication.Text = "x";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMinus.Location = new System.Drawing.Point(255, 223);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(76, 41);
            this.btnMinus.TabIndex = 20;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEqual.Location = new System.Drawing.Point(255, 319);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(76, 41);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPlus.Location = new System.Drawing.Point(255, 272);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(76, 41);
            this.btnPlus.TabIndex = 18;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSquare.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSquare.Location = new System.Drawing.Point(173, 82);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(76, 41);
            this.btnSquare.TabIndex = 17;
            this.btnSquare.Text = "x^2";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnRoot
            // 
            this.btnRoot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnRoot.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRoot.Location = new System.Drawing.Point(91, 82);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(76, 41);
            this.btnRoot.TabIndex = 16;
            this.btnRoot.Text = "√ ";
            this.btnRoot.UseVisualStyleBackColor = false;
            this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // btnModulas
            // 
            this.btnModulas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnModulas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnModulas.Location = new System.Drawing.Point(9, 82);
            this.btnModulas.Name = "btnModulas";
            this.btnModulas.Size = new System.Drawing.Size(76, 41);
            this.btnModulas.TabIndex = 15;
            this.btnModulas.Text = "%";
            this.btnModulas.UseVisualStyleBackColor = false;
            this.btnModulas.Click += new System.EventHandler(this.btnModulas_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBackspace.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBackspace.Location = new System.Drawing.Point(173, 129);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(76, 41);
            this.btnBackspace.TabIndex = 14;
            this.btnBackspace.Text = "⌫";
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear.Location = new System.Drawing.Point(91, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 41);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearEverything
            // 
            this.btnClearEverything.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearEverything.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearEverything.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnClearEverything.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClearEverything.Location = new System.Drawing.Point(9, 129);
            this.btnClearEverything.Name = "btnClearEverything";
            this.btnClearEverything.Size = new System.Drawing.Size(76, 41);
            this.btnClearEverything.TabIndex = 12;
            this.btnClearEverything.Text = "CE";
            this.btnClearEverything.UseVisualStyleBackColor = false;
            this.btnClearEverything.Click += new System.EventHandler(this.btnClearEverything_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnNine.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNine.Location = new System.Drawing.Point(173, 176);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(76, 41);
            this.btnNine.TabIndex = 11;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnEight.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEight.Location = new System.Drawing.Point(91, 176);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(76, 41);
            this.btnEight.TabIndex = 10;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSeven.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSeven.Location = new System.Drawing.Point(9, 176);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(76, 41);
            this.btnSeven.TabIndex = 9;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSix.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSix.Location = new System.Drawing.Point(173, 223);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(76, 41);
            this.btnSix.TabIndex = 8;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnFive.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFive.Location = new System.Drawing.Point(91, 223);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(76, 41);
            this.btnFive.TabIndex = 7;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnDecimalPoint
            // 
            this.btnDecimalPoint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDecimalPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecimalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnDecimalPoint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDecimalPoint.Location = new System.Drawing.Point(173, 319);
            this.btnDecimalPoint.Name = "btnDecimalPoint";
            this.btnDecimalPoint.Size = new System.Drawing.Size(76, 41);
            this.btnDecimalPoint.TabIndex = 6;
            this.btnDecimalPoint.Text = ".";
            this.btnDecimalPoint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDecimalPoint.UseVisualStyleBackColor = false;
            this.btnDecimalPoint.Click += new System.EventHandler(this.btnDecimalPoint_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnZero.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnZero.Location = new System.Drawing.Point(91, 319);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(76, 41);
            this.btnZero.TabIndex = 5;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnPlusMinus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPlusMinus.Location = new System.Drawing.Point(9, 319);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(76, 41);
            this.btnPlusMinus.TabIndex = 4;
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnThree.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnThree.Location = new System.Drawing.Point(173, 272);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(76, 41);
            this.btnThree.TabIndex = 3;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTwo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTwo.Location = new System.Drawing.Point(91, 272);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(76, 41);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnFour.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFour.Location = new System.Drawing.Point(9, 223);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(76, 41);
            this.btnFour.TabIndex = 1;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblResult.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblResult.Location = new System.Drawing.Point(9, 29);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(92, 31);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(746, 476);
            this.Controls.Add(this.panel1);
            this.Name = "Calculator";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnDecimalPoint;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnOneOverX;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btnModulas;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearEverything;
        private System.Windows.Forms.Label lblResult;
    }
}

