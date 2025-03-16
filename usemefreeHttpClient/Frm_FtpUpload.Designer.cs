namespace usemefreeHttpClient
{
    partial class Frm_FtpUpload
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
            GBox_Upload = new GroupBox();
            btn_SelectLocalFile = new Button();
            btn_upload = new Button();
            lbl_ftpFile = new Label();
            txt_ftpFile = new TextBox();
            lbl_LocalFile = new Label();
            txt_LocalFile = new TextBox();
            lbl_LocalPath = new Label();
            txt_LocalPath = new TextBox();
            GBox_Upload.SuspendLayout();
            SuspendLayout();
            // 
            // GBox_Upload
            // 
            GBox_Upload.Controls.Add(btn_SelectLocalFile);
            GBox_Upload.Controls.Add(btn_upload);
            GBox_Upload.Controls.Add(lbl_ftpFile);
            GBox_Upload.Controls.Add(txt_ftpFile);
            GBox_Upload.Controls.Add(lbl_LocalFile);
            GBox_Upload.Controls.Add(txt_LocalFile);
            GBox_Upload.Controls.Add(lbl_LocalPath);
            GBox_Upload.Controls.Add(txt_LocalPath);
            GBox_Upload.Location = new Point(12, 12);
            GBox_Upload.Name = "GBox_Upload";
            GBox_Upload.Size = new Size(776, 426);
            GBox_Upload.TabIndex = 0;
            GBox_Upload.TabStop = false;
            GBox_Upload.Text = "Ftp Upload";
            // 
            // btn_SelectLocalFile
            // 
            btn_SelectLocalFile.Location = new Point(733, 117);
            btn_SelectLocalFile.Name = "btn_SelectLocalFile";
            btn_SelectLocalFile.Size = new Size(27, 29);
            btn_SelectLocalFile.TabIndex = 7;
            btn_SelectLocalFile.Text = "...";
            btn_SelectLocalFile.UseVisualStyleBackColor = true;
            btn_SelectLocalFile.Click += btn_SelectLocalFile_Click;
            // 
            // btn_upload
            // 
            btn_upload.Location = new Point(633, 166);
            btn_upload.Name = "btn_upload";
            btn_upload.Size = new Size(94, 29);
            btn_upload.TabIndex = 6;
            btn_upload.Text = "&Upload";
            btn_upload.UseVisualStyleBackColor = true;
            btn_upload.Click += btn_upload_Click;
            // 
            // lbl_ftpFile
            // 
            lbl_ftpFile.AutoSize = true;
            lbl_ftpFile.Location = new Point(29, 54);
            lbl_ftpFile.Name = "lbl_ftpFile";
            lbl_ftpFile.Size = new Size(57, 20);
            lbl_ftpFile.TabIndex = 5;
            lbl_ftpFile.Text = "Ftp File";
            // 
            // txt_ftpFile
            // 
            txt_ftpFile.Location = new Point(147, 51);
            txt_ftpFile.Name = "txt_ftpFile";
            txt_ftpFile.Size = new Size(580, 27);
            txt_ftpFile.TabIndex = 4;
            // 
            // lbl_LocalFile
            // 
            lbl_LocalFile.AutoSize = true;
            lbl_LocalFile.Location = new Point(29, 120);
            lbl_LocalFile.Name = "lbl_LocalFile";
            lbl_LocalFile.Size = new Size(71, 20);
            lbl_LocalFile.TabIndex = 3;
            lbl_LocalFile.Text = "Local File";
            // 
            // txt_LocalFile
            // 
            txt_LocalFile.Location = new Point(147, 117);
            txt_LocalFile.Name = "txt_LocalFile";
            txt_LocalFile.Size = new Size(580, 27);
            txt_LocalFile.TabIndex = 2;
            // 
            // lbl_LocalPath
            // 
            lbl_LocalPath.AutoSize = true;
            lbl_LocalPath.Location = new Point(29, 87);
            lbl_LocalPath.Name = "lbl_LocalPath";
            lbl_LocalPath.Size = new Size(76, 20);
            lbl_LocalPath.TabIndex = 1;
            lbl_LocalPath.Text = "Local Path";
            // 
            // txt_LocalPath
            // 
            txt_LocalPath.Location = new Point(147, 84);
            txt_LocalPath.Name = "txt_LocalPath";
            txt_LocalPath.Size = new Size(580, 27);
            txt_LocalPath.TabIndex = 0;
            // 
            // Frm_FtpUpload
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GBox_Upload);
            Name = "Frm_FtpUpload";
            Text = "Frm_FtpUpload";
            Load += Frm_FtpUpload_Load;
            GBox_Upload.ResumeLayout(false);
            GBox_Upload.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GBox_Upload;
        private Label lbl_LocalPath;
        private TextBox txt_LocalPath;
        private Label lbl_LocalFile;
        private TextBox txt_LocalFile;
        private Button btn_upload;
        private Label lbl_ftpFile;
        private TextBox txt_ftpFile;
        private Button btn_SelectLocalFile;
    }
}