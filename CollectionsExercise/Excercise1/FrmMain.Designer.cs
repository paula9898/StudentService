namespace CollectionsExercise.Exercise1
{
    partial class Collections
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxbOne = new System.Windows.Forms.TextBox();
            this.TxbTwo = new System.Windows.Forms.TextBox();
            this.TxbThree = new System.Windows.Forms.TextBox();
            this.TxbFour = new System.Windows.Forms.TextBox();
            this.TxbFive = new System.Windows.Forms.TextBox();
            this.TxbSix = new System.Windows.Forms.TextBox();
            this.BtnAddition = new System.Windows.Forms.Button();
            this.BtnMinMax = new System.Windows.Forms.Button();
            this.BtnCountElements = new System.Windows.Forms.Button();
            this.BtnDividedByThree = new System.Windows.Forms.Button();
            this.BtnElement = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblAddResult = new System.Windows.Forms.Label();
            this.LblMinMax = new System.Windows.Forms.Label();
            this.LblNumberOfElements = new System.Windows.Forms.Label();
            this.LblNumbersDividedByThree = new System.Windows.Forms.Label();
            this.LblElement = new System.Windows.Forms.Label();
            this.LblSort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxbOne
            // 
            this.TxbOne.Location = new System.Drawing.Point(37, 12);
            this.TxbOne.Name = "TxbOne";
            this.TxbOne.Size = new System.Drawing.Size(125, 27);
            this.TxbOne.TabIndex = 0;
            this.TxbOne.TextChanged += new System.EventHandler(this.TxbOne_TextChanged);
            // 
            // TxbTwo
            // 
            this.TxbTwo.Location = new System.Drawing.Point(37, 45);
            this.TxbTwo.Name = "TxbTwo";
            this.TxbTwo.Size = new System.Drawing.Size(125, 27);
            this.TxbTwo.TabIndex = 1;
            this.TxbTwo.TextChanged += new System.EventHandler(this.TxbTwo_TextChanged);
            // 
            // TxbThree
            // 
            this.TxbThree.Location = new System.Drawing.Point(37, 82);
            this.TxbThree.Name = "TxbThree";
            this.TxbThree.Size = new System.Drawing.Size(125, 27);
            this.TxbThree.TabIndex = 2;
            this.TxbThree.TextChanged += new System.EventHandler(this.TxbThree_TextChanged);
            // 
            // TxbFour
            // 
            this.TxbFour.Location = new System.Drawing.Point(37, 125);
            this.TxbFour.Name = "TxbFour";
            this.TxbFour.Size = new System.Drawing.Size(125, 27);
            this.TxbFour.TabIndex = 3;
            this.TxbFour.TextChanged += new System.EventHandler(this.TxbFour_TextChanged);
            // 
            // TxbFive
            // 
            this.TxbFive.Location = new System.Drawing.Point(37, 169);
            this.TxbFive.Name = "TxbFive";
            this.TxbFive.Size = new System.Drawing.Size(125, 27);
            this.TxbFive.TabIndex = 4;
            this.TxbFive.TextChanged += new System.EventHandler(this.TxbFive_TextChanged);
            // 
            // TxbSix
            // 
            this.TxbSix.Location = new System.Drawing.Point(37, 216);
            this.TxbSix.Name = "TxbSix";
            this.TxbSix.Size = new System.Drawing.Size(125, 27);
            this.TxbSix.TabIndex = 5;
            this.TxbSix.TextChanged += new System.EventHandler(this.TxbSix_TextChanged);
            // 
            // BtnAddition
            // 
            this.BtnAddition.Location = new System.Drawing.Point(216, 12);
            this.BtnAddition.Name = "BtnAddition";
            this.BtnAddition.Size = new System.Drawing.Size(113, 29);
            this.BtnAddition.TabIndex = 6;
            this.BtnAddition.Text = "Addition";
            this.BtnAddition.UseVisualStyleBackColor = true;
            this.BtnAddition.Click += new System.EventHandler(this.BtnAddition_Click);
            // 
            // BtnMinMax
            // 
            this.BtnMinMax.Location = new System.Drawing.Point(216, 47);
            this.BtnMinMax.Name = "BtnMinMax";
            this.BtnMinMax.Size = new System.Drawing.Size(113, 29);
            this.BtnMinMax.TabIndex = 7;
            this.BtnMinMax.Text = "Min/Max";
            this.BtnMinMax.UseVisualStyleBackColor = true;
            this.BtnMinMax.Click += new System.EventHandler(this.BtnMinMax_Click);
            // 
            // BtnCountElements
            // 
            this.BtnCountElements.Location = new System.Drawing.Point(216, 82);
            this.BtnCountElements.Name = "BtnCountElements";
            this.BtnCountElements.Size = new System.Drawing.Size(113, 29);
            this.BtnCountElements.TabIndex = 8;
            this.BtnCountElements.Text = "AmountOfElem";
            this.BtnCountElements.UseVisualStyleBackColor = true;
            this.BtnCountElements.Click += new System.EventHandler(this.BtnCountElements_Click);
            // 
            // BtnDividedByThree
            // 
            this.BtnDividedByThree.Location = new System.Drawing.Point(216, 125);
            this.BtnDividedByThree.Name = "BtnDividedByThree";
            this.BtnDividedByThree.Size = new System.Drawing.Size(113, 27);
            this.BtnDividedByThree.TabIndex = 9;
            this.BtnDividedByThree.Text = "Numbers/3";
            this.BtnDividedByThree.UseVisualStyleBackColor = true;
            this.BtnDividedByThree.Click += new System.EventHandler(this.BtnDividedByThree_Click);
            // 
            // BtnElement
            // 
            this.BtnElement.Location = new System.Drawing.Point(216, 169);
            this.BtnElement.Name = "BtnElement";
            this.BtnElement.Size = new System.Drawing.Size(94, 29);
            this.BtnElement.TabIndex = 10;
            this.BtnElement.Text = "Element";
            this.BtnElement.UseVisualStyleBackColor = true;
            this.BtnElement.Click += new System.EventHandler(this.BtnElement_Click);
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(216, 216);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(94, 29);
            this.BtnSort.TabIndex = 11;
            this.BtnSort.Text = "Sort";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 12;
            // 
            // LblAddResult
            // 
            this.LblAddResult.AutoSize = true;
            this.LblAddResult.Location = new System.Drawing.Point(74, 297);
            this.LblAddResult.Name = "LblAddResult";
            this.LblAddResult.Size = new System.Drawing.Size(50, 20);
            this.LblAddResult.TabIndex = 13;
            this.LblAddResult.Text = "label2";
            // 
            // LblMinMax
            // 
            this.LblMinMax.AutoSize = true;
            this.LblMinMax.Location = new System.Drawing.Point(74, 329);
            this.LblMinMax.Name = "LblMinMax";
            this.LblMinMax.Size = new System.Drawing.Size(50, 20);
            this.LblMinMax.TabIndex = 14;
            this.LblMinMax.Text = "label3";
            // 
            // LblNumberOfElements
            // 
            this.LblNumberOfElements.AutoSize = true;
            this.LblNumberOfElements.Location = new System.Drawing.Point(74, 370);
            this.LblNumberOfElements.Name = "LblNumberOfElements";
            this.LblNumberOfElements.Size = new System.Drawing.Size(50, 20);
            this.LblNumberOfElements.TabIndex = 15;
            this.LblNumberOfElements.Text = "label4";
            // 
            // LblNumbersDividedByThree
            // 
            this.LblNumbersDividedByThree.AutoSize = true;
            this.LblNumbersDividedByThree.Location = new System.Drawing.Point(74, 403);
            this.LblNumbersDividedByThree.Name = "LblNumbersDividedByThree";
            this.LblNumbersDividedByThree.Size = new System.Drawing.Size(50, 20);
            this.LblNumbersDividedByThree.TabIndex = 16;
            this.LblNumbersDividedByThree.Text = "label5";
            // 
            // LblElement
            // 
            this.LblElement.AutoSize = true;
            this.LblElement.Location = new System.Drawing.Point(74, 439);
            this.LblElement.Name = "LblElement";
            this.LblElement.Size = new System.Drawing.Size(50, 20);
            this.LblElement.TabIndex = 17;
            this.LblElement.Text = "label6";
            // 
            // LblSort
            // 
            this.LblSort.AutoSize = true;
            this.LblSort.Location = new System.Drawing.Point(74, 469);
            this.LblSort.Name = "LblSort";
            this.LblSort.Size = new System.Drawing.Size(50, 20);
            this.LblSort.TabIndex = 18;
            this.LblSort.Text = "label7";
            // 
            // Collections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(492, 590);
            this.Controls.Add(this.LblSort);
            this.Controls.Add(this.LblElement);
            this.Controls.Add(this.LblNumbersDividedByThree);
            this.Controls.Add(this.LblNumberOfElements);
            this.Controls.Add(this.LblMinMax);
            this.Controls.Add(this.LblAddResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.BtnElement);
            this.Controls.Add(this.BtnDividedByThree);
            this.Controls.Add(this.BtnCountElements);
            this.Controls.Add(this.BtnMinMax);
            this.Controls.Add(this.BtnAddition);
            this.Controls.Add(this.TxbSix);
            this.Controls.Add(this.TxbFive);
            this.Controls.Add(this.TxbFour);
            this.Controls.Add(this.TxbThree);
            this.Controls.Add(this.TxbTwo);
            this.Controls.Add(this.TxbOne);
            this.Name = "Collections";
            this.Text = "Collections";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxbOne;
        private TextBox TxbTwo;
        private TextBox TxbThree;
        private TextBox TxbFour;
        private TextBox TxbFive;
        private TextBox TxbSix;
        private Button BtnAddition;
        private Button BtnMinMax;
        private Button BtnCountElements;
        private Button BtnDividedByThree;
        private Button BtnElement;
        private Button BtnSort;
        private Label label1;
        private Label LblAddResult;
        private Label LblMinMax;
        private Label LblNumberOfElements;
        private Label LblNumbersDividedByThree;
        private Label LblElement;
        private Label LblSort;
    }
}