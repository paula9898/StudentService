namespace Calculator.Forms
{
    public partial class FrmCalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBackSpace = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnPoint = new System.Windows.Forms.Button();
            this.BtnZero = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnClick = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnSix = new System.Windows.Forms.Button();
            this.BtnFive = new System.Windows.Forms.Button();
            this.BtnMultiplication = new System.Windows.Forms.Button();
            this.BtnNine = new System.Windows.Forms.Button();
            this.BtnEight = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnFour = new System.Windows.Forms.Button();
            this.BtnSeven = new System.Windows.Forms.Button();
            this.TxbResult = new System.Windows.Forms.TextBox();
            this.LabelCurrentOperation = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxbResult, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelCurrentOperation, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.555555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(257, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.BtnBackSpace, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnEqual, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.BtnPoint, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.BtnZero, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.button21, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.BtnAdd, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.BtnThree, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.BtnTwo, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.BtnClick, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.BtnMinus, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.BtnSix, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.BtnFive, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.BtnMultiplication, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.BtnNine, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.BtnEight, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.BtnDivision, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.button7, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button6, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnReturn, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnClear, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnFour, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.BtnSeven, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 102);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(251, 345);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // BtnBackSpace
            // 
            this.BtnBackSpace.Location = new System.Drawing.Point(65, 52);
            this.BtnBackSpace.Name = "BtnBackSpace";
            this.BtnBackSpace.Size = new System.Drawing.Size(56, 39);
            this.BtnBackSpace.TabIndex = 1;
            this.BtnBackSpace.Text = "CE";
            this.BtnBackSpace.UseVisualStyleBackColor = true;
            // 
            // BtnEqual
            // 
            this.BtnEqual.Location = new System.Drawing.Point(189, 297);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(56, 43);
            this.BtnEqual.TabIndex = 23;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = true;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnPoint
            // 
            this.BtnPoint.Location = new System.Drawing.Point(127, 297);
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.Size = new System.Drawing.Size(56, 43);
            this.BtnPoint.TabIndex = 22;
            this.BtnPoint.Text = ".";
            this.BtnPoint.UseVisualStyleBackColor = true;
            this.BtnPoint.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // BtnZero
            // 
            this.BtnZero.Location = new System.Drawing.Point(65, 297);
            this.BtnZero.Name = "BtnZero";
            this.BtnZero.Size = new System.Drawing.Size(56, 43);
            this.BtnZero.TabIndex = 21;
            this.BtnZero.Text = "0";
            this.BtnZero.UseVisualStyleBackColor = true;
            this.BtnZero.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(3, 297);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(56, 43);
            this.button21.TabIndex = 20;
            this.button21.Text = "+/-";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(189, 248);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(56, 39);
            this.BtnAdd.TabIndex = 19;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnOperatorClick);
            // 
            // BtnThree
            // 
            this.BtnThree.Location = new System.Drawing.Point(127, 248);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(56, 39);
            this.BtnThree.TabIndex = 18;
            this.BtnThree.Text = "3";
            this.BtnThree.UseVisualStyleBackColor = true;
            this.BtnThree.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // BtnTwo
            // 
            this.BtnTwo.Location = new System.Drawing.Point(65, 248);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(56, 39);
            this.BtnTwo.TabIndex = 17;
            this.BtnTwo.Text = "2";
            this.BtnTwo.UseVisualStyleBackColor = true;
            this.BtnTwo.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // BtnClick
            // 
            this.BtnClick.Location = new System.Drawing.Point(3, 248);
            this.BtnClick.Name = "BtnClick";
            this.BtnClick.Size = new System.Drawing.Size(56, 39);
            this.BtnClick.TabIndex = 16;
            this.BtnClick.Text = "1";
            this.BtnClick.UseVisualStyleBackColor = true;
            this.BtnClick.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.Location = new System.Drawing.Point(189, 199);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(56, 39);
            this.BtnMinus.TabIndex = 15;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnOperatorClick);
            // 
            // BtnSix
            // 
            this.BtnSix.Location = new System.Drawing.Point(127, 199);
            this.BtnSix.Name = "BtnSix";
            this.BtnSix.Size = new System.Drawing.Size(56, 39);
            this.BtnSix.TabIndex = 14;
            this.BtnSix.Text = "6";
            this.BtnSix.UseVisualStyleBackColor = true;
            this.BtnSix.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // BtnFive
            // 
            this.BtnFive.Location = new System.Drawing.Point(65, 199);
            this.BtnFive.Name = "BtnFive";
            this.BtnFive.Size = new System.Drawing.Size(56, 39);
            this.BtnFive.TabIndex = 13;
            this.BtnFive.Text = "5";
            this.BtnFive.UseVisualStyleBackColor = true;
            this.BtnFive.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // BtnMultiplication
            // 
            this.BtnMultiplication.Location = new System.Drawing.Point(189, 150);
            this.BtnMultiplication.Name = "BtnMultiplication";
            this.BtnMultiplication.Size = new System.Drawing.Size(56, 39);
            this.BtnMultiplication.TabIndex = 11;
            this.BtnMultiplication.Text = "*";
            this.BtnMultiplication.UseVisualStyleBackColor = true;
            this.BtnMultiplication.Click += new System.EventHandler(this.BtnOperatorClick);
            // 
            // BtnNine
            // 
            this.BtnNine.Location = new System.Drawing.Point(127, 150);
            this.BtnNine.Name = "BtnNine";
            this.BtnNine.Size = new System.Drawing.Size(56, 39);
            this.BtnNine.TabIndex = 10;
            this.BtnNine.Text = "9";
            this.BtnNine.UseVisualStyleBackColor = true;
            this.BtnNine.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // BtnEight
            // 
            this.BtnEight.Location = new System.Drawing.Point(65, 150);
            this.BtnEight.Name = "BtnEight";
            this.BtnEight.Size = new System.Drawing.Size(56, 39);
            this.BtnEight.TabIndex = 9;
            this.BtnEight.Text = "8";
            this.BtnEight.UseVisualStyleBackColor = true;
            this.BtnEight.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.Location = new System.Drawing.Point(189, 101);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(56, 39);
            this.BtnDivision.TabIndex = 7;
            this.BtnDivision.Text = "/";
            this.BtnDivision.UseVisualStyleBackColor = true;
            this.BtnDivision.Click += new System.EventHandler(this.BtnOperatorClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(127, 101);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 39);
            this.button7.TabIndex = 6;
            this.button7.Text = "2**√x";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(65, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 39);
            this.button6.TabIndex = 5;
            this.button6.Text = "x**2";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 101);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 39);
            this.button5.TabIndex = 4;
            this.button5.Text = "1/x";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(189, 52);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(56, 39);
            this.BtnReturn.TabIndex = 3;
            this.BtnReturn.Text = "← ";
            this.BtnReturn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "%";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "M+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(127, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "M-";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClear.Location = new System.Drawing.Point(127, 52);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(56, 43);
            this.BtnClear.TabIndex = 24;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnFour
            // 
            this.BtnFour.Location = new System.Drawing.Point(3, 199);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(56, 39);
            this.BtnFour.TabIndex = 12;
            this.BtnFour.Text = "4";
            this.BtnFour.UseVisualStyleBackColor = true;
            this.BtnFour.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // BtnSeven
            // 
            this.BtnSeven.Location = new System.Drawing.Point(3, 150);
            this.BtnSeven.Name = "BtnSeven";
            this.BtnSeven.Size = new System.Drawing.Size(56, 39);
            this.BtnSeven.TabIndex = 8;
            this.BtnSeven.Text = "7";
            this.BtnSeven.UseVisualStyleBackColor = true;
            this.BtnSeven.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // TxbResult
            // 
            this.TxbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbResult.Enabled = false;
            this.TxbResult.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbResult.Location = new System.Drawing.Point(3, 36);
            this.TxbResult.Name = "TxbResult";
            this.TxbResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxbResult.Size = new System.Drawing.Size(251, 85);
            this.TxbResult.TabIndex = 3;
            this.TxbResult.Text = "0";
            this.TxbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelCurrentOperation
            // 
            this.LabelCurrentOperation.AutoSize = true;
            this.LabelCurrentOperation.Location = new System.Drawing.Point(3, 0);
            this.LabelCurrentOperation.Name = "LabelCurrentOperation";
            this.LabelCurrentOperation.Size = new System.Drawing.Size(0, 20);
            this.LabelCurrentOperation.TabIndex = 4;
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnEqual;
        private Button BtnPoint;
        private Button BtnZero;
        private Button button21;
        private Button BtnAdd;
        private Button BtnThree;
        private Button BtnTwo;
        private Button BtnClick;
        private Button BtnMinus;
        private Button BtnSix;
        private Button BtnFive;
        private Button BtnFour;
        private Button BtnMultiplication;
        private Button BtnNine;
        private Button BtnEight;
        private Button BtnSeven;
        private Button BtnDivision;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button BtnReturn;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button BtnBackSpace;
        private Button BtnClear;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox TxbResult;
        private Label LabelCurrentOperation;
    }
}