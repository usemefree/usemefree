namespace usemefreeJsonCreate
{
    partial class Frm_ShowAll
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
            dgv_Show = new DataGridView();
            dgv_id = new DataGridViewTextBoxColumn();
            dgv_isactive = new DataGridViewTextBoxColumn();
            dgv_DateIs = new DataGridViewTextBoxColumn();
            dgv_os = new DataGridViewTextBoxColumn();
            dgv_category = new DataGridViewTextBoxColumn();
            dgv_Name = new DataGridViewTextBoxColumn();
            dgv_imgsrc = new DataGridViewTextBoxColumn();
            dgv_summary = new DataGridViewTextBoxColumn();
            dgv_weblink = new DataGridViewTextBoxColumn();
            dgv_downloadlink = new DataGridViewTextBoxColumn();
            dgv_details = new DataGridViewTextBoxColumn();
            dgv_counting = new DataGridViewTextBoxColumn();
            cbox_OS = new ComboBox();
            lbl_OS = new Label();
            btn_GenrateJson = new Button();
            btn_New = new Button();
            chk_FtpUpload = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Show).BeginInit();
            SuspendLayout();
            // 
            // dgv_Show
            // 
            dgv_Show.AllowUserToAddRows = false;
            dgv_Show.AllowUserToDeleteRows = false;
            dgv_Show.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Show.Columns.AddRange(new DataGridViewColumn[] { dgv_id, dgv_isactive, dgv_DateIs, dgv_os, dgv_category, dgv_Name, dgv_imgsrc, dgv_summary, dgv_weblink, dgv_downloadlink, dgv_details, dgv_counting });
            dgv_Show.Location = new Point(1, 46);
            dgv_Show.MultiSelect = false;
            dgv_Show.Name = "dgv_Show";
            dgv_Show.ReadOnly = true;
            dgv_Show.RowHeadersVisible = false;
            dgv_Show.RowHeadersWidth = 51;
            dgv_Show.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Show.Size = new Size(1284, 615);
            dgv_Show.TabIndex = 0;
            dgv_Show.CellDoubleClick += dgv_Show_CellDoubleClick;
            // 
            // dgv_id
            // 
            dgv_id.DataPropertyName = "id";
            dgv_id.HeaderText = "Id";
            dgv_id.MinimumWidth = 6;
            dgv_id.Name = "dgv_id";
            dgv_id.ReadOnly = true;
            dgv_id.Width = 125;
            // 
            // dgv_isactive
            // 
            dgv_isactive.DataPropertyName = "isactive";
            dgv_isactive.HeaderText = "IsActive";
            dgv_isactive.MinimumWidth = 6;
            dgv_isactive.Name = "dgv_isactive";
            dgv_isactive.ReadOnly = true;
            dgv_isactive.Width = 125;
            // 
            // dgv_DateIs
            // 
            dgv_DateIs.HeaderText = "DateIs";
            dgv_DateIs.MinimumWidth = 6;
            dgv_DateIs.Name = "dgv_DateIs";
            dgv_DateIs.ReadOnly = true;
            dgv_DateIs.Width = 125;
            // 
            // dgv_os
            // 
            dgv_os.DataPropertyName = "os_name";
            dgv_os.HeaderText = "OS";
            dgv_os.MinimumWidth = 6;
            dgv_os.Name = "dgv_os";
            dgv_os.ReadOnly = true;
            dgv_os.Width = 125;
            // 
            // dgv_category
            // 
            dgv_category.DataPropertyName = "category_name";
            dgv_category.HeaderText = "Category";
            dgv_category.MinimumWidth = 6;
            dgv_category.Name = "dgv_category";
            dgv_category.ReadOnly = true;
            dgv_category.Width = 125;
            // 
            // dgv_Name
            // 
            dgv_Name.DataPropertyName = "name";
            dgv_Name.HeaderText = "Name";
            dgv_Name.MinimumWidth = 6;
            dgv_Name.Name = "dgv_Name";
            dgv_Name.ReadOnly = true;
            dgv_Name.Width = 125;
            // 
            // dgv_imgsrc
            // 
            dgv_imgsrc.DataPropertyName = "imgsrc";
            dgv_imgsrc.HeaderText = "imgsrc";
            dgv_imgsrc.MinimumWidth = 6;
            dgv_imgsrc.Name = "dgv_imgsrc";
            dgv_imgsrc.ReadOnly = true;
            dgv_imgsrc.Width = 125;
            // 
            // dgv_summary
            // 
            dgv_summary.DataPropertyName = "summary";
            dgv_summary.HeaderText = "summary";
            dgv_summary.MinimumWidth = 6;
            dgv_summary.Name = "dgv_summary";
            dgv_summary.ReadOnly = true;
            dgv_summary.Width = 125;
            // 
            // dgv_weblink
            // 
            dgv_weblink.DataPropertyName = "weblink";
            dgv_weblink.HeaderText = "weblink";
            dgv_weblink.MinimumWidth = 6;
            dgv_weblink.Name = "dgv_weblink";
            dgv_weblink.ReadOnly = true;
            dgv_weblink.Width = 125;
            // 
            // dgv_downloadlink
            // 
            dgv_downloadlink.DataPropertyName = "downloadlink";
            dgv_downloadlink.HeaderText = "downloadlink";
            dgv_downloadlink.MinimumWidth = 6;
            dgv_downloadlink.Name = "dgv_downloadlink";
            dgv_downloadlink.ReadOnly = true;
            dgv_downloadlink.Width = 125;
            // 
            // dgv_details
            // 
            dgv_details.DataPropertyName = "details";
            dgv_details.HeaderText = "details";
            dgv_details.MinimumWidth = 6;
            dgv_details.Name = "dgv_details";
            dgv_details.ReadOnly = true;
            dgv_details.Width = 125;
            // 
            // dgv_counting
            // 
            dgv_counting.DataPropertyName = "counting";
            dgv_counting.HeaderText = "counting";
            dgv_counting.MinimumWidth = 6;
            dgv_counting.Name = "dgv_counting";
            dgv_counting.ReadOnly = true;
            dgv_counting.Width = 125;
            // 
            // cbox_OS
            // 
            cbox_OS.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_OS.FormattingEnabled = true;
            cbox_OS.Location = new Point(161, 10);
            cbox_OS.Name = "cbox_OS";
            cbox_OS.Size = new Size(274, 28);
            cbox_OS.TabIndex = 1;
            cbox_OS.SelectedIndexChanged += cbox_OS_SelectedIndexChanged;
            // 
            // lbl_OS
            // 
            lbl_OS.AutoSize = true;
            lbl_OS.Location = new Point(29, 13);
            lbl_OS.Name = "lbl_OS";
            lbl_OS.Size = new Size(127, 20);
            lbl_OS.TabIndex = 2;
            lbl_OS.Text = "Operating System";
            // 
            // btn_GenrateJson
            // 
            btn_GenrateJson.Location = new Point(1069, 9);
            btn_GenrateJson.Name = "btn_GenrateJson";
            btn_GenrateJson.Size = new Size(162, 29);
            btn_GenrateJson.TabIndex = 3;
            btn_GenrateJson.Text = "Genrate Json";
            btn_GenrateJson.UseVisualStyleBackColor = true;
            btn_GenrateJson.Click += btn_GenrateJson_Click;
            // 
            // btn_New
            // 
            btn_New.Location = new Point(508, 9);
            btn_New.Name = "btn_New";
            btn_New.Size = new Size(94, 29);
            btn_New.TabIndex = 4;
            btn_New.Text = "Add New";
            btn_New.UseVisualStyleBackColor = true;
            btn_New.Click += btn_New_Click;
            // 
            // chk_FtpUpload
            // 
            chk_FtpUpload.AutoSize = true;
            chk_FtpUpload.Location = new Point(957, 12);
            chk_FtpUpload.Name = "chk_FtpUpload";
            chk_FtpUpload.RightToLeft = RightToLeft.Yes;
            chk_FtpUpload.Size = new Size(105, 24);
            chk_FtpUpload.TabIndex = 5;
            chk_FtpUpload.Text = "Ftp Upload";
            chk_FtpUpload.UseVisualStyleBackColor = true;
            // 
            // Frm_ShowAll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 663);
            Controls.Add(chk_FtpUpload);
            Controls.Add(btn_New);
            Controls.Add(btn_GenrateJson);
            Controls.Add(lbl_OS);
            Controls.Add(cbox_OS);
            Controls.Add(dgv_Show);
            Name = "Frm_ShowAll";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Frm_ShowAll_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Show;
        private ComboBox cbox_OS;
        private Label lbl_OS;
        private Button btn_GenrateJson;
        private Button btn_New;
        private DataGridViewTextBoxColumn dgv_id;
        private DataGridViewTextBoxColumn dgv_isactive;
        private DataGridViewTextBoxColumn dgv_DateIs;
        private DataGridViewTextBoxColumn dgv_os;
        private DataGridViewTextBoxColumn dgv_category;
        private DataGridViewTextBoxColumn dgv_Name;
        private DataGridViewTextBoxColumn dgv_imgsrc;
        private DataGridViewTextBoxColumn dgv_summary;
        private DataGridViewTextBoxColumn dgv_weblink;
        private DataGridViewTextBoxColumn dgv_downloadlink;
        private DataGridViewTextBoxColumn dgv_details;
        private DataGridViewTextBoxColumn dgv_counting;
        private CheckBox chk_FtpUpload;
    }
}
