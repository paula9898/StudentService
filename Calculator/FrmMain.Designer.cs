namespace Calculator
{
    partial class FrmMain
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
            this.TbxNumberOne = new System.Windows.Forms.TextBox();
            this.TbxResult = new System.Windows.Forms.TextBox();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.TbxNumberTwo = new System.Windows.Forms.TextBox();
            this.BtnMultiplication = new System.Windows.Forms.Button();
            this.BtnSubstracion = new System.Windows.Forms.Button();
            this.BtnAddition = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.Tlpnl1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Tlpnl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbxNumberOne
            // 
            this.TbxNumberOne.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TbxNumberOne.Location = new System.Drawing.Point(3, 154);
            this.TbxNumberOne.Name = "TbxNumberOne";
            this.TbxNumberOne.Size = new System.Drawing.Size(211, 27);
            this.TbxNumberOne.TabIndex = 0;
            this.TbxNumberOne.Text = "2";
            // 
            // TbxResult
            // 
            this.TbxResult.Location = new System.Drawing.Point(108, 3);
            this.TbxResult.Name = "TbxResult";
            this.TbxResult.Size = new System.Drawing.Size(95, 27);
            this.TbxResult.TabIndex = 4;
            // 
            // BtnDivision
            // 
            this.BtnDivision.Location = new System.Drawing.Point(108, 45);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(94, 29);
            this.BtnDivision.TabIndex = 8;
            this.BtnDivision.Text = "/";
            this.BtnDivision.UseVisualStyleBackColor = true;
            this.BtnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // TbxNumberTwo
            // 
            this.TbxNumberTwo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TbxNumberTwo.Location = new System.Drawing.Point(3, 266);
            this.TbxNumberTwo.Name = "TbxNumberTwo";
            this.TbxNumberTwo.Size = new System.Drawing.Size(211, 27);
            this.TbxNumberTwo.TabIndex = 3;
            // 
            // BtnMultiplication
            // 
            this.BtnMultiplication.Location = new System.Drawing.Point(3, 45);
            this.BtnMultiplication.Name = "BtnMultiplication";
            this.BtnMultiplication.Size = new System.Drawing.Size(94, 29);
            this.BtnMultiplication.TabIndex = 6;
            this.BtnMultiplication.Text = "*";
            this.BtnMultiplication.UseVisualStyleBackColor = true;
            this.BtnMultiplication.Click += new System.EventHandler(this.BtnMultiplication_Click);
            // 
            // BtnSubstracion
            // 
            this.BtnSubstracion.Location = new System.Drawing.Point(108, 3);
            this.BtnSubstracion.Name = "BtnSubstracion";
            this.BtnSubstracion.Size = new System.Drawing.Size(94, 29);
            this.BtnSubstracion.TabIndex = 7;
            this.BtnSubstracion.Text = "-";
            this.BtnSubstracion.UseVisualStyleBackColor = true;
            this.BtnSubstracion.Click += new System.EventHandler(this.BtnSubstracion_Click);
            // 
            // BtnAddition
            // 
            this.BtnAddition.Location = new System.Drawing.Point(3, 3);
            this.BtnAddition.Name = "BtnAddition";
            this.BtnAddition.Size = new System.Drawing.Size(94, 29);
            this.BtnAddition.TabIndex = 1;
            this.BtnAddition.Text = "+";
            this.BtnAddition.UseVisualStyleBackColor = true;
            this.BtnAddition.Click += new System.EventHandler(this.BtnAddition_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(50, 3);
            this.LblResult.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.LblResult.Name = "LblResult";
            this.LblResult.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblResult.Size = new System.Drawing.Size(45, 25);
            this.LblResult.TabIndex = 5;
            this.LblResult.Text = "result";
            this.LblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Tlpnl1
            // 
            this.Tlpnl1.ColumnCount = 1;
            this.Tlpnl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlpnl1.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.Tlpnl1.Controls.Add(this.TbxNumberOne, 0, 1);
            this.Tlpnl1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.Tlpnl1.Controls.Add(this.TbxNumberTwo, 0, 2);
            this.Tlpnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlpnl1.Location = new System.Drawing.Point(0, 0);
            this.Tlpnl1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.Tlpnl1.Name = "Tlpnl1";
            this.Tlpnl1.RowCount = 4;
            this.Tlpnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tlpnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tlpnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tlpnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tlpnl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tlpnl1.Size = new System.Drawing.Size(220, 450);
            this.Tlpnl1.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LblResult, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TbxResult, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(211, 84);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnDivision, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnAddition, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnMultiplication, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnSubstracion, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 339);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(211, 84);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 450);
            this.Controls.Add(this.Tlpnl1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Tlpnl1.ResumeLayout(false);
            this.Tlpnl1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox TbxNumberOne;
        private TableLayoutPanel Tlpnl1;
        private TextBox TbxResult;
        private Button BtnDivision;
        private TextBox TbxNumberTwo;
        private Button BtnMultiplication;
        private Button BtnSubstracion;
        private Button BtnAddition;
        private Label LblResult;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}