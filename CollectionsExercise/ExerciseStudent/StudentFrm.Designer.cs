namespace CollectionsExercise
{
    partial class FrmStudent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudent));
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tblpn3 = new System.Windows.Forms.TableLayoutPanel();
            this.LblSurname = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.Tblpn2 = new System.Windows.Forms.TableLayoutPanel();
            this.Tblpn4 = new System.Windows.Forms.TableLayoutPanel();
            this.CbAgeFrom = new System.Windows.Forms.ComboBox();
            this.LblSex = new System.Windows.Forms.Label();
            this.LblAgeFrom = new System.Windows.Forms.Label();
            this.CbAgeTo = new System.Windows.Forms.ComboBox();
            this.LblAgeTo = new System.Windows.Forms.Label();
            this.ClbSex = new System.Windows.Forms.CheckedListBox();
            this.LblAcademy = new System.Windows.Forms.Label();
            this.CmbAcademy = new System.Windows.Forms.ComboBox();
            this.DgvStudent = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tblpn1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.academyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.Tblpn3.SuspendLayout();
            this.Tblpn2.SuspendLayout();
            this.Tblpn4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudent)).BeginInit();
            this.Tblpn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataSource = typeof(CollectionsExercise.ExerciseStudent.Models.Student);
            // 
            // Tblpn3
            // 
            this.Tblpn3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Tblpn3.BackColor = System.Drawing.SystemColors.Info;
            this.Tblpn3.ColumnCount = 2;
            this.Tblpn3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.Tblpn3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tblpn3.Controls.Add(this.LblSurname, 1, 1);
            this.Tblpn3.Controls.Add(this.BtnDelete, 1, 0);
            this.Tblpn3.Controls.Add(this.BtnAdd, 0, 1);
            this.Tblpn3.Controls.Add(this.BtnModify, 0, 0);
            this.Tblpn3.Location = new System.Drawing.Point(3, 207);
            this.Tblpn3.Name = "Tblpn3";
            this.Tblpn3.RowCount = 2;
            this.Tblpn3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.Tblpn3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tblpn3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tblpn3.Size = new System.Drawing.Size(351, 259);
            this.Tblpn3.TabIndex = 1;
            // 
            // LblSurname
            // 
            this.LblSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(229, 184);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(0, 20);
            this.LblSurname.TabIndex = 10;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDelete.Location = new System.Drawing.Point(182, 50);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(94, 29);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAdd.Location = new System.Drawing.Point(17, 181);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(72, 25);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModify.Location = new System.Drawing.Point(16, 50);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(74, 29);
            this.BtnModify.TabIndex = 16;
            this.BtnModify.Text = "Edit";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // Tblpn2
            // 
            this.Tblpn2.ColumnCount = 1;
            this.Tblpn2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tblpn2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tblpn2.Controls.Add(this.Tblpn4, 0, 0);
            this.Tblpn2.Controls.Add(this.DgvStudent, 0, 1);
            this.Tblpn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tblpn2.Location = new System.Drawing.Point(360, 3);
            this.Tblpn2.Name = "Tblpn2";
            this.Tblpn2.RowCount = 2;
            this.Tblpn2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.05405F));
            this.Tblpn2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.94595F));
            this.Tblpn2.Size = new System.Drawing.Size(810, 463);
            this.Tblpn2.TabIndex = 0;
            // 
            // Tblpn4
            // 
            this.Tblpn4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tblpn4.ColumnCount = 4;
            this.Tblpn4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Tblpn4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.71429F));
            this.Tblpn4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.28571F));
            this.Tblpn4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.Tblpn4.Controls.Add(this.CbAgeFrom, 3, 0);
            this.Tblpn4.Controls.Add(this.LblSex, 0, 0);
            this.Tblpn4.Controls.Add(this.LblAgeFrom, 2, 0);
            this.Tblpn4.Controls.Add(this.CbAgeTo, 3, 1);
            this.Tblpn4.Controls.Add(this.LblAgeTo, 2, 1);
            this.Tblpn4.Controls.Add(this.ClbSex, 1, 0);
            this.Tblpn4.Controls.Add(this.LblAcademy, 0, 1);
            this.Tblpn4.Controls.Add(this.CmbAcademy, 1, 1);
            this.Tblpn4.Location = new System.Drawing.Point(3, 3);
            this.Tblpn4.Name = "Tblpn4";
            this.Tblpn4.RowCount = 2;
            this.Tblpn4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tblpn4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tblpn4.Size = new System.Drawing.Size(804, 128);
            this.Tblpn4.TabIndex = 0;
            // 
            // CbAgeFrom
            // 
            this.CbAgeFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbAgeFrom.FormattingEnabled = true;
            this.CbAgeFrom.Location = new System.Drawing.Point(643, 18);
            this.CbAgeFrom.Name = "CbAgeFrom";
            this.CbAgeFrom.Size = new System.Drawing.Size(158, 28);
            this.CbAgeFrom.TabIndex = 1;
            this.CbAgeFrom.SelectedIndexChanged += new System.EventHandler(this.CbAgeFrom_SelectedIndexChanged);
            // 
            // LblSex
            // 
            this.LblSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblSex.AutoSize = true;
            this.LblSex.Location = new System.Drawing.Point(34, 22);
            this.LblSex.Name = "LblSex";
            this.LblSex.Size = new System.Drawing.Size(32, 20);
            this.LblSex.TabIndex = 2;
            this.LblSex.Text = "Sex";
            // 
            // LblAgeFrom
            // 
            this.LblAgeFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblAgeFrom.AutoSize = true;
            this.LblAgeFrom.Location = new System.Drawing.Point(483, 22);
            this.LblAgeFrom.Name = "LblAgeFrom";
            this.LblAgeFrom.Size = new System.Drawing.Size(74, 20);
            this.LblAgeFrom.TabIndex = 3;
            this.LblAgeFrom.Text = "Age From";
            // 
            // CbAgeTo
            // 
            this.CbAgeTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbAgeTo.Location = new System.Drawing.Point(643, 82);
            this.CbAgeTo.Name = "CbAgeTo";
            this.CbAgeTo.Size = new System.Drawing.Size(158, 28);
            this.CbAgeTo.TabIndex = 4;
            this.CbAgeTo.SelectedIndexChanged += new System.EventHandler(this.CbAgeTo_SelectedIndexChanged);
            // 
            // LblAgeTo
            // 
            this.LblAgeTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblAgeTo.AutoSize = true;
            this.LblAgeTo.Location = new System.Drawing.Point(492, 86);
            this.LblAgeTo.Name = "LblAgeTo";
            this.LblAgeTo.Size = new System.Drawing.Size(56, 20);
            this.LblAgeTo.TabIndex = 5;
            this.LblAgeTo.Text = "Age To";
            // 
            // ClbSex
            // 
            this.ClbSex.CheckOnClick = true;
            this.ClbSex.FormattingEnabled = true;
            this.ClbSex.Location = new System.Drawing.Point(103, 3);
            this.ClbSex.Name = "ClbSex";
            this.ClbSex.Size = new System.Drawing.Size(150, 48);
            this.ClbSex.TabIndex = 6;
            this.ClbSex.SelectedIndexChanged += new System.EventHandler(this.ClbSex_SelectedIndexChanged);
            // 
            // LblAcademy
            // 
            this.LblAcademy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblAcademy.AutoSize = true;
            this.LblAcademy.Location = new System.Drawing.Point(14, 86);
            this.LblAcademy.Name = "LblAcademy";
            this.LblAcademy.Size = new System.Drawing.Size(71, 20);
            this.LblAcademy.TabIndex = 7;
            this.LblAcademy.Text = "Academy";
            // 
            // CmbAcademy
            // 
            this.CmbAcademy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbAcademy.DataSource = this.academyBindingSource;
            this.CmbAcademy.DisplayMember = "Name";
            this.CmbAcademy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAcademy.DropDownWidth = 286;
            this.CmbAcademy.FormattingEnabled = true;
            this.CmbAcademy.Location = new System.Drawing.Point(106, 82);
            this.CmbAcademy.Name = "CmbAcademy";
            this.CmbAcademy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmbAcademy.Size = new System.Drawing.Size(289, 28);
            this.CmbAcademy.TabIndex = 8;
            this.CmbAcademy.UseWaitCursor = true;
            this.CmbAcademy.SelectedIndexChanged += new System.EventHandler(this.CmbAcademy_SelectedIndexChanged);
            // 
            // DgvStudent
            // 
            this.DgvStudent.AutoGenerateColumns = false;
            this.DgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn5,
            this.Birthdate,
            this.Adddate});
            this.DgvStudent.DataSource = this.studentBindingSource1;
            this.DgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvStudent.Location = new System.Drawing.Point(3, 137);
            this.DgvStudent.Name = "DgvStudent";
            this.DgvStudent.RowHeadersWidth = 51;
            this.DgvStudent.RowTemplate.Height = 29;
            this.DgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvStudent.Size = new System.Drawing.Size(804, 323);
            this.DgvStudent.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IndexNumber";
            this.dataGridViewTextBoxColumn7.HeaderText = "IndexNumber";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sex";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // Birthdate
            // 
            this.Birthdate.DataPropertyName = "Birthdate";
            this.Birthdate.HeaderText = "Birthdate";
            this.Birthdate.MinimumWidth = 6;
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Width = 125;
            // 
            // Adddate
            // 
            this.Adddate.DataPropertyName = "Adddate";
            this.Adddate.HeaderText = "Adddate";
            this.Adddate.MinimumWidth = 6;
            this.Adddate.Name = "Adddate";
            this.Adddate.Width = 125;
            // 
            // Tblpn1
            // 
            this.Tblpn1.ColumnCount = 2;
            this.Tblpn1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.5F));
            this.Tblpn1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.5F));
            this.Tblpn1.Controls.Add(this.Tblpn2, 1, 0);
            this.Tblpn1.Controls.Add(this.Tblpn3, 0, 0);
            this.Tblpn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tblpn1.Location = new System.Drawing.Point(0, 0);
            this.Tblpn1.Name = "Tblpn1";
            this.Tblpn1.RowCount = 1;
            this.Tblpn1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tblpn1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tblpn1.Size = new System.Drawing.Size(1173, 469);
            this.Tblpn1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // academyBindingSource
            // 
            this.academyBindingSource.DataSource = typeof(CollectionsExercise.ExerciseStudent.Models.Academy);
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Tblpn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentFrm";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.Tblpn3.ResumeLayout(false);
            this.Tblpn3.PerformLayout();
            this.Tblpn2.ResumeLayout(false);
            this.Tblpn4.ResumeLayout(false);
            this.Tblpn4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudent)).EndInit();
            this.Tblpn1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource studentBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateAddDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn indexNumberDataGridViewTextBoxColumn;
        private BindingSource studentBindingSource1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private TableLayoutPanel Tblpn3;
        private Label LblSurname;
        private Button BtnDelete;
        private Button BtnAdd;
        private Button BtnModify;
        private TableLayoutPanel Tblpn2;
        private TableLayoutPanel Tblpn4;
        private ComboBox CbAgeFrom;
        private Label LblSex;
        private Label LblAgeFrom;
        private ComboBox CbAgeTo;
        private Label LblAgeTo;
        private CheckedListBox ClbSex;
        private DataGridView DgvStudent;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Birthdate;
        private DataGridViewTextBoxColumn Adddate;
        private TableLayoutPanel Tblpn1;
        private PictureBox pictureBox1;
        private Label LblAcademy;
        private ComboBox CmbAcademy;
        private BindingSource academyBindingSource;
    }
}