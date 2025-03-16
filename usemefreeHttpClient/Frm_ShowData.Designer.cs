namespace usemefreeHttpClient
{
    partial class Frm_ShowData
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
            btnLoadWin = new Button();
            btnLoadLin = new Button();
            btnLoadAnd = new Button();
            btnLoadMac = new Button();
            txt_FilePath = new TextBox();
            btnNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Show).BeginInit();
            SuspendLayout();
            // 
            // dgv_Show
            // 
            dgv_Show.AllowUserToAddRows = false;
            dgv_Show.AllowUserToDeleteRows = false;
            dgv_Show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Show.Columns.AddRange(new DataGridViewColumn[] { dgv_Id, dgv_IsActive, dgv_Os, dgv_Category, dgv_Name, dgv_imgsrc, dgv_Summary, dgv_Weblink, dgv_Downloadlink, dgv_counting, dgv_Edit });
            dgv_Show.Dock = DockStyle.Bottom;
            dgv_Show.Location = new Point(0, 99);
            dgv_Show.MultiSelect = false;
            dgv_Show.Name = "dgv_Show";
            dgv_Show.ReadOnly = true;
            dgv_Show.RowHeadersVisible = false;
            dgv_Show.RowHeadersWidth = 51;
            dgv_Show.Size = new Size(1229, 600);
            dgv_Show.TabIndex = 1;
            dgv_Show.CellMouseClick += dgv_Show_CellMouseClick;
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
            // btnLoadWin
            // 
            btnLoadWin.Location = new Point(510, 28);
            btnLoadWin.Name = "btnLoadWin";
            btnLoadWin.Size = new Size(81, 29);
            btnLoadWin.TabIndex = 2;
            btnLoadWin.Text = "Window";
            btnLoadWin.UseVisualStyleBackColor = true;
            btnLoadWin.Click += btnLoad_Click;
            // 
            // btnLoadLin
            // 
            btnLoadLin.Location = new Point(626, 28);
            btnLoadLin.Name = "btnLoadLin";
            btnLoadLin.Size = new Size(81, 29);
            btnLoadLin.TabIndex = 3;
            btnLoadLin.Text = "Linux";
            btnLoadLin.UseVisualStyleBackColor = true;
            btnLoadLin.Click += btnLoadLin_Click;
            // 
            // btnLoadAnd
            // 
            btnLoadAnd.Location = new Point(873, 28);
            btnLoadAnd.Name = "btnLoadAnd";
            btnLoadAnd.Size = new Size(81, 29);
            btnLoadAnd.TabIndex = 5;
            btnLoadAnd.Text = "Android";
            btnLoadAnd.UseVisualStyleBackColor = true;
            btnLoadAnd.Click += btnLoadAnd_Click;
            // 
            // btnLoadMac
            // 
            btnLoadMac.Location = new Point(757, 28);
            btnLoadMac.Name = "btnLoadMac";
            btnLoadMac.Size = new Size(81, 29);
            btnLoadMac.TabIndex = 4;
            btnLoadMac.Text = "Mac";
            btnLoadMac.UseVisualStyleBackColor = true;
            btnLoadMac.Click += btnLoadMac_Click;
            // 
            // txt_FilePath
            // 
            txt_FilePath.Location = new Point(87, 30);
            txt_FilePath.Name = "txt_FilePath";
            txt_FilePath.Size = new Size(298, 27);
            txt_FilePath.TabIndex = 6;
            txt_FilePath.Text = "C:\\Temp\\";
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.Location = new Point(1113, 30);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 7;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // Frm_ShowData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 699);
            Controls.Add(btnNew);
            Controls.Add(txt_FilePath);
            Controls.Add(btnLoadAnd);
            Controls.Add(btnLoadMac);
            Controls.Add(btnLoadLin);
            Controls.Add(btnLoadWin);
            Controls.Add(dgv_Show);
            Name = "Frm_ShowData";
            Text = "Frm_ShowData";
            Load += Frm_ShowData_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Show;
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
        private Button btnLoadWin;
        private Button btnLoadLin;
        private Button btnLoadAnd;
        private Button btnLoadMac;
        private TextBox txt_FilePath;
        private Button btnNew;
    }
}
