namespace OperationFile
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.BtnAddFolder = new System.Windows.Forms.Button();
            this.TxbFolderName = new System.Windows.Forms.TextBox();
            this.BtnAddFile = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TxbFileName = new System.Windows.Forms.TextBox();
            this.LbPath = new System.Windows.Forms.Label();
            this.LbPathAddress = new System.Windows.Forms.Label();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.BtnAddText = new System.Windows.Forms.Button();
            this.RTxbText = new System.Windows.Forms.RichTextBox();
            this.BtnOverwrite = new System.Windows.Forms.Button();
            this.BtnClearRtxb = new System.Windows.Forms.Button();
            this.BtnReadText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddFolder
            // 
            this.BtnAddFolder.Location = new System.Drawing.Point(111, 163);
            this.BtnAddFolder.Name = "BtnAddFolder";
            this.BtnAddFolder.Size = new System.Drawing.Size(94, 29);
            this.BtnAddFolder.TabIndex = 0;
            this.BtnAddFolder.Text = "Add Folder";
            this.BtnAddFolder.UseVisualStyleBackColor = true;
            this.BtnAddFolder.Click += new System.EventHandler(this.BtnAddFolder_Click);
            // 
            // TxbFolderName
            // 
            this.TxbFolderName.Location = new System.Drawing.Point(277, 163);
            this.TxbFolderName.Name = "TxbFolderName";
            this.TxbFolderName.Size = new System.Drawing.Size(125, 27);
            this.TxbFolderName.TabIndex = 1;
            // 
            // BtnAddFile
            // 
            this.BtnAddFile.Location = new System.Drawing.Point(111, 267);
            this.BtnAddFile.Name = "BtnAddFile";
            this.BtnAddFile.Size = new System.Drawing.Size(94, 29);
            this.BtnAddFile.TabIndex = 2;
            this.BtnAddFile.Text = "Add File";
            this.BtnAddFile.UseVisualStyleBackColor = true;
            this.BtnAddFile.Click += new System.EventHandler(this.BtnAddFile_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TxbFileName
            // 
            this.TxbFileName.Location = new System.Drawing.Point(277, 267);
            this.TxbFileName.Name = "TxbFileName";
            this.TxbFileName.Size = new System.Drawing.Size(125, 27);
            this.TxbFileName.TabIndex = 4;
            // 
            // LbPath
            // 
            this.LbPath.AutoSize = true;
            this.LbPath.Location = new System.Drawing.Point(231, 117);
            this.LbPath.Name = "LbPath";
            this.LbPath.Size = new System.Drawing.Size(40, 20);
            this.LbPath.TabIndex = 5;
            this.LbPath.Text = "Path:";
            // 
            // LbPathAddress
            // 
            this.LbPathAddress.AutoSize = true;
            this.LbPathAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPathAddress.Location = new System.Drawing.Point(277, 112);
            this.LbPathAddress.Name = "LbPathAddress";
            this.LbPathAddress.Size = new System.Drawing.Size(0, 28);
            this.LbPathAddress.TabIndex = 6;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(111, 108);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(94, 29);
            this.BtnBrowse.TabIndex = 7;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // BtnAddText
            // 
            this.BtnAddText.Location = new System.Drawing.Point(577, 265);
            this.BtnAddText.Name = "BtnAddText";
            this.BtnAddText.Size = new System.Drawing.Size(82, 29);
            this.BtnAddText.TabIndex = 8;
            this.BtnAddText.Text = "Add Text";
            this.BtnAddText.UseVisualStyleBackColor = true;
            this.BtnAddText.Click += new System.EventHandler(this.BtnAddText_Click);
            // 
            // RTxbText
            // 
            this.RTxbText.Location = new System.Drawing.Point(577, 32);
            this.RTxbText.Name = "RTxbText";
            this.RTxbText.Size = new System.Drawing.Size(211, 227);
            this.RTxbText.TabIndex = 9;
            this.RTxbText.Text = "";
            // 
            // BtnOverwrite
            // 
            this.BtnOverwrite.Location = new System.Drawing.Point(705, 265);
            this.BtnOverwrite.Name = "BtnOverwrite";
            this.BtnOverwrite.Size = new System.Drawing.Size(83, 29);
            this.BtnOverwrite.TabIndex = 11;
            this.BtnOverwrite.Text = "Overwrite Text";
            this.BtnOverwrite.UseVisualStyleBackColor = true;
            this.BtnOverwrite.Click += new System.EventHandler(this.BtnOverwrite_Click);
            // 
            // BtnClearRtxb
            // 
            this.BtnClearRtxb.Location = new System.Drawing.Point(633, 399);
            this.BtnClearRtxb.Name = "BtnClearRtxb";
            this.BtnClearRtxb.Size = new System.Drawing.Size(94, 29);
            this.BtnClearRtxb.TabIndex = 12;
            this.BtnClearRtxb.Text = "Clear";
            this.BtnClearRtxb.UseVisualStyleBackColor = true;
            this.BtnClearRtxb.Click += new System.EventHandler(this.BtnClearRtxb_Click);
            // 
            // BtnReadText
            // 
            this.BtnReadText.Location = new System.Drawing.Point(633, 326);
            this.BtnReadText.Name = "BtnReadText";
            this.BtnReadText.Size = new System.Drawing.Size(94, 29);
            this.BtnReadText.TabIndex = 13;
            this.BtnReadText.Text = "Read Text";
            this.BtnReadText.UseVisualStyleBackColor = true;
            this.BtnReadText.Click += new System.EventHandler(this.BtnReadText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnReadText);
            this.Controls.Add(this.BtnClearRtxb);
            this.Controls.Add(this.BtnOverwrite);
            this.Controls.Add(this.RTxbText);
            this.Controls.Add(this.BtnAddText);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.LbPathAddress);
            this.Controls.Add(this.LbPath);
            this.Controls.Add(this.TxbFileName);
            this.Controls.Add(this.BtnAddFile);
            this.Controls.Add(this.TxbFolderName);
            this.Controls.Add(this.BtnAddFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnAddFolder;
        private TextBox TxbFolderName;
        private Button BtnAddFile;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox TxbFileName;
        private Label LbPath;
        private Label LbPathAddress;
        private Button BtnBrowse;
        private Button BtnAddText;
        private RichTextBox RTxbText;
        private Button BtnOverwrite;
        private Button BtnClearRtxb;
        private Button BtnReadText;
    }
}