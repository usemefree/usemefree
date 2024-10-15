namespace usemefreeJsonFile
{
    partial class FrmShowData
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
            dgv_Show = new DataGridView();
            btnNew = new Button();
            txt_FilePath = new TextBox();
            lbl_FilePath = new Label();
            btnImport = new Button();
            btn_Export = new Button();
            dgv_Id = new DataGridViewTextBoxColumn();
            dgv_IsActive = new DataGridViewCheckBoxColumn();
            dgv_Os = new DataGridViewTextBoxColumn();
            dgv_Category = new DataGridViewTextBoxColumn();
            dgv_Name = new DataGridViewTextBoxColumn();
            dgv_imgsrc = new DataGridViewTextBoxColumn();
            dgv_Summary = new DataGridViewTextBoxColumn();
            dgv_Weblink = new DataGridViewTextBoxColumn();
            dgv_Downloadlink = new DataGridViewTextBoxColumn();
            dgv_counting = new DataGridViewTextBoxColumn();
            dgv_Edit = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_Show).BeginInit();
            SuspendLayout();
            // 
            // dgv_Show
            // 
            dgv_Show.AllowUserToAddRows = false;
            dgv_Show.AllowUserToDeleteRows = false;
            dgv_Show.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Show.Columns.AddRange(new DataGridViewColumn[] { dgv_Id, dgv_IsActive, dgv_Os, dgv_Category, dgv_Name, dgv_imgsrc, dgv_Summary, dgv_Weblink, dgv_Downloadlink, dgv_counting, dgv_Edit });
            dgv_Show.Location = new Point(2, 47);
            dgv_Show.MultiSelect = false;
            dgv_Show.Name = "dgv_Show";
            dgv_Show.ReadOnly = true;
            dgv_Show.RowHeadersVisible = false;
            dgv_Show.RowHeadersWidth = 51;
            dgv_Show.Size = new Size(1062, 698);
            dgv_Show.TabIndex = 0;
            dgv_Show.CellMouseClick += dgv_Show_CellMouseClick;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.Location = new Point(960, 9);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 1;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txt_FilePath
            // 
            txt_FilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_FilePath.Location = new Point(82, 11);
            txt_FilePath.Name = "txt_FilePath";
            txt_FilePath.Size = new Size(700, 27);
            txt_FilePath.TabIndex = 2;
            // 
            // lbl_FilePath
            // 
            lbl_FilePath.AutoSize = true;
            lbl_FilePath.Location = new Point(12, 15);
            lbl_FilePath.Name = "lbl_FilePath";
            lbl_FilePath.Size = new Size(64, 20);
            lbl_FilePath.TabIndex = 3;
            lbl_FilePath.Text = "File Path";
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImport.Location = new Point(788, 10);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(66, 29);
            btnImport.TabIndex = 4;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btn_Export
            // 
            btn_Export.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Export.Location = new Point(860, 10);
            btn_Export.Name = "btn_Export";
            btn_Export.Size = new Size(66, 29);
            btn_Export.TabIndex = 5;
            btn_Export.Text = "Export";
            btn_Export.UseVisualStyleBackColor = true;
            btn_Export.Click += btn_Export_Click;
            // 
            // dgv_Id
            // 
            dgv_Id.DataPropertyName = "id";
            dgv_Id.HeaderText = "Id";
            dgv_Id.MinimumWidth = 6;
            dgv_Id.Name = "dgv_Id";
            dgv_Id.ReadOnly = true;
            dgv_Id.Width = 125;
            // 
            // dgv_IsActive
            // 
            dgv_IsActive.DataPropertyName = "isactive";
            dgv_IsActive.HeaderText = "Is Active";
            dgv_IsActive.MinimumWidth = 6;
            dgv_IsActive.Name = "dgv_IsActive";
            dgv_IsActive.ReadOnly = true;
            dgv_IsActive.Width = 125;
            // 
            // dgv_Os
            // 
            dgv_Os.DataPropertyName = "os";
            dgv_Os.HeaderText = "OS";
            dgv_Os.MinimumWidth = 6;
            dgv_Os.Name = "dgv_Os";
            dgv_Os.ReadOnly = true;
            dgv_Os.Width = 125;
            // 
            // dgv_Category
            // 
            dgv_Category.DataPropertyName = "category";
            dgv_Category.HeaderText = "Category";
            dgv_Category.MinimumWidth = 6;
            dgv_Category.Name = "dgv_Category";
            dgv_Category.ReadOnly = true;
            dgv_Category.Width = 125;
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
            dgv_imgsrc.HeaderText = "ImgUrl";
            dgv_imgsrc.MinimumWidth = 6;
            dgv_imgsrc.Name = "dgv_imgsrc";
            dgv_imgsrc.ReadOnly = true;
            dgv_imgsrc.Width = 125;
            // 
            // dgv_Summary
            // 
            dgv_Summary.DataPropertyName = "summary";
            dgv_Summary.HeaderText = "Summary";
            dgv_Summary.MinimumWidth = 6;
            dgv_Summary.Name = "dgv_Summary";
            dgv_Summary.ReadOnly = true;
            dgv_Summary.Width = 125;
            // 
            // dgv_Weblink
            // 
            dgv_Weblink.DataPropertyName = "weblink";
            dgv_Weblink.HeaderText = "Weblink";
            dgv_Weblink.MinimumWidth = 6;
            dgv_Weblink.Name = "dgv_Weblink";
            dgv_Weblink.ReadOnly = true;
            dgv_Weblink.Width = 125;
            // 
            // dgv_Downloadlink
            // 
            dgv_Downloadlink.DataPropertyName = "downloadlink";
            dgv_Downloadlink.HeaderText = "Download Link";
            dgv_Downloadlink.MinimumWidth = 6;
            dgv_Downloadlink.Name = "dgv_Downloadlink";
            dgv_Downloadlink.ReadOnly = true;
            dgv_Downloadlink.Width = 125;
            // 
            // dgv_counting
            // 
            dgv_counting.DataPropertyName = "counting";
            dgv_counting.HeaderText = "Counting";
            dgv_counting.MinimumWidth = 6;
            dgv_counting.Name = "dgv_counting";
            dgv_counting.ReadOnly = true;
            dgv_counting.Width = 125;
            // 
            // dgv_Edit
            // 
            dgv_Edit.HeaderText = "Edit";
            dgv_Edit.MinimumWidth = 6;
            dgv_Edit.Name = "dgv_Edit";
            dgv_Edit.ReadOnly = true;
            dgv_Edit.Width = 125;
            // 
            // FrmShowData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 748);
            Controls.Add(btn_Export);
            Controls.Add(btnImport);
            Controls.Add(lbl_FilePath);
            Controls.Add(txt_FilePath);
            Controls.Add(btnNew);
            Controls.Add(dgv_Show);
            Name = "FrmShowData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UseMeFree.com";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgv_Show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Show;
        private Button btnNew;
        private TextBox txt_FilePath;
        private Label lbl_FilePath;
        private Button btnImport;
        private Button btn_Export;
        private DataGridViewTextBoxColumn dgv_Id;
        private DataGridViewCheckBoxColumn dgv_IsActive;
        private DataGridViewTextBoxColumn dgv_Os;
        private DataGridViewTextBoxColumn dgv_Category;
        private DataGridViewTextBoxColumn dgv_Name;
        private DataGridViewTextBoxColumn dgv_imgsrc;
        private DataGridViewTextBoxColumn dgv_Summary;
        private DataGridViewTextBoxColumn dgv_Weblink;
        private DataGridViewTextBoxColumn dgv_Downloadlink;
        private DataGridViewTextBoxColumn dgv_counting;
        private DataGridViewButtonColumn dgv_Edit;
    }
}