namespace CollectionsExercise.ExerciseStudent
{
    partial class EditStudentFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudentFrm));
            this.TxbName = new System.Windows.Forms.TextBox();
            this.TxbSurname = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LblSex = new System.Windows.Forms.Label();
            this.DtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.DtpDateAdd = new System.Windows.Forms.DateTimePicker();
            this.LblBirthday = new System.Windows.Forms.Label();
            this.LlblMatriculation = new System.Windows.Forms.Label();
            this.CbSex = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxbStudentIndexNumber = new System.Windows.Forms.TextBox();
            this.IndexNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxbName
            // 
            this.TxbName.Location = new System.Drawing.Point(257, 64);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(256, 27);
            this.TxbName.TabIndex = 0;
            // 
            // TxbSurname
            // 
            this.TxbSurname.Location = new System.Drawing.Point(257, 131);
            this.TxbSurname.Name = "TxbSurname";
            this.TxbSurname.Size = new System.Drawing.Size(256, 27);
            this.TxbSurname.TabIndex = 1;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LblName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblName.Location = new System.Drawing.Point(92, 64);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(54, 20);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "NAME";
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LblSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSurname.Location = new System.Drawing.Point(92, 135);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(83, 20);
            this.LblSurname.TabIndex = 4;
            this.LblSurname.Text = "SURNAME";
            // 
            // LblSex
            // 
            this.LblSex.AutoSize = true;
            this.LblSex.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LblSex.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSex.Location = new System.Drawing.Point(92, 200);
            this.LblSex.Name = "LblSex";
            this.LblSex.Size = new System.Drawing.Size(35, 20);
            this.LblSex.TabIndex = 5;
            this.LblSex.Text = "SEX";
            // 
            // DtpBirthday
            // 
            this.DtpBirthday.Location = new System.Drawing.Point(263, 268);
            this.DtpBirthday.Name = "DtpBirthday";
            this.DtpBirthday.Size = new System.Drawing.Size(250, 27);
            this.DtpBirthday.TabIndex = 6;
            // 
            // DtpDateAdd
            // 
            this.DtpDateAdd.Location = new System.Drawing.Point(263, 327);
            this.DtpDateAdd.Name = "DtpDateAdd";
            this.DtpDateAdd.Size = new System.Drawing.Size(250, 27);
            this.DtpDateAdd.TabIndex = 7;
            // 
            // LblBirthday
            // 
            this.LblBirthday.AutoSize = true;
            this.LblBirthday.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LblBirthday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblBirthday.Location = new System.Drawing.Point(92, 272);
            this.LblBirthday.Name = "LblBirthday";
            this.LblBirthday.Size = new System.Drawing.Size(84, 20);
            this.LblBirthday.TabIndex = 8;
            this.LblBirthday.Text = "BIRTHDAY";
            // 
            // LlblMatriculation
            // 
            this.LlblMatriculation.AutoSize = true;
            this.LlblMatriculation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LlblMatriculation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LlblMatriculation.Location = new System.Drawing.Point(92, 329);
            this.LlblMatriculation.Name = "LlblMatriculation";
            this.LlblMatriculation.Size = new System.Drawing.Size(75, 20);
            this.LlblMatriculation.TabIndex = 9;
            this.LlblMatriculation.Text = "Date Add";
            // 
            // CbSex
            // 
            this.CbSex.FormattingEnabled = true;
            this.CbSex.Location = new System.Drawing.Point(263, 203);
            this.CbSex.Name = "CbSex";
            this.CbSex.Size = new System.Drawing.Size(133, 28);
            this.CbSex.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(530, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 173);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(644, 305);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(94, 29);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(631, 377);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(119, 41);
            this.BtnExit.TabIndex = 15;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // TxbStudentIndexNumber
            // 
            this.TxbStudentIndexNumber.Location = new System.Drawing.Point(263, 377);
            this.TxbStudentIndexNumber.Name = "TxbStudentIndexNumber";
            this.TxbStudentIndexNumber.Size = new System.Drawing.Size(153, 27);
            this.TxbStudentIndexNumber.TabIndex = 16;
            // 
            // IndexNumber
            // 
            this.IndexNumber.AutoSize = true;
            this.IndexNumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.IndexNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IndexNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IndexNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IndexNumber.Location = new System.Drawing.Point(92, 377);
            this.IndexNumber.Name = "IndexNumber";
            this.IndexNumber.Size = new System.Drawing.Size(106, 20);
            this.IndexNumber.TabIndex = 17;
            this.IndexNumber.Text = "IndexNumber";
            // 
            // EditStudentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IndexNumber);
            this.Controls.Add(this.TxbStudentIndexNumber);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CbSex);
            this.Controls.Add(this.LlblMatriculation);
            this.Controls.Add(this.LblBirthday);
            this.Controls.Add(this.DtpDateAdd);
            this.Controls.Add(this.DtpBirthday);
            this.Controls.Add(this.LblSex);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxbSurname);
            this.Controls.Add(this.TxbName);
            this.Name = "EditStudentFrm";
            this.Text = "EditFormStudent";
            this.Load += new System.EventHandler(this.EditStudentFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxbName;
        private TextBox TxbSurname;
        private Label LblName;
        private Label LblSurname;
        private Label LblSex;
        private DateTimePicker DtpBirthday;
        private DateTimePicker DtpDateAdd;
        private Label LblBirthday;
        private Label LlblMatriculation;
        private ComboBox CbSex;
        private PictureBox pictureBox1;
        private Button BtnSave;
        private Button BtnExit;
        private TextBox TxbStudentIndexNumber;
        private Label IndexNumber;
    }
}