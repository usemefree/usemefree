namespace usemefreeApp
{
    partial class FrmShow
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
            dgv_show = new DataGridView();
            btn_new = new Button();
            CB_Os = new ComboBox();
            LB_Os = new Label();
            dgv_isactive = new DataGridViewCheckBoxColumn();
            dgv_Id = new DataGridViewTextBoxColumn();
            dgv_Os = new DataGridViewTextBoxColumn();
            dgv_category = new DataGridViewTextBoxColumn();
            dgv_Name = new DataGridViewTextBoxColumn();
            dgv_imgsrc = new DataGridViewTextBoxColumn();
            dgv_summary = new DataGridViewTextBoxColumn();
            dgv_weblink = new DataGridViewTextBoxColumn();
            dgv_downloadlink = new DataGridViewTextBoxColumn();
            dgv_details = new DataGridViewTextBoxColumn();
            dgv_edit = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_show).BeginInit();
            SuspendLayout();
            // 
            // dgv_show
            // 
            dgv_show.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_show.Columns.AddRange(new DataGridViewColumn[] { dgv_isactive, dgv_Id, dgv_Os, dgv_category, dgv_Name, dgv_imgsrc, dgv_summary, dgv_weblink, dgv_downloadlink, dgv_details, dgv_edit });
            dgv_show.Location = new Point(0, 57);
            dgv_show.Name = "dgv_show";
            dgv_show.RowHeadersVisible = false;
            dgv_show.RowHeadersWidth = 51;
            dgv_show.Size = new Size(1166, 613);
            dgv_show.TabIndex = 0;
            dgv_show.CellClick += dgv_show_CellClick;
            // 
            // btn_new
            // 
            btn_new.Location = new Point(1045, 12);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(94, 29);
            btn_new.TabIndex = 1;
            btn_new.Text = "new";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // CB_Os
            // 
            CB_Os.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Os.FormattingEnabled = true;
            CB_Os.Items.AddRange(new object[] { "windows", "linux", "mac", "android" });
            CB_Os.Location = new Point(136, 17);
            CB_Os.Name = "CB_Os";
            CB_Os.Size = new Size(151, 28);
            CB_Os.TabIndex = 2;
            CB_Os.SelectedIndexChanged += CB_Os_SelectedIndexChanged;
            // 
            // LB_Os
            // 
            LB_Os.AutoSize = true;
            LB_Os.Location = new Point(80, 21);
            LB_Os.Name = "LB_Os";
            LB_Os.Size = new Size(28, 20);
            LB_Os.TabIndex = 3;
            LB_Os.Text = "OS";
            // 
            // dgv_isactive
            // 
            dgv_isactive.DataPropertyName = "isactive";
            dgv_isactive.HeaderText = "isactive";
            dgv_isactive.MinimumWidth = 6;
            dgv_isactive.Name = "dgv_isactive";
            dgv_isactive.ReadOnly = true;
            dgv_isactive.Width = 125;
            // 
            // dgv_Id
            // 
            dgv_Id.DataPropertyName = "id";
            dgv_Id.HeaderText = "Id";
            dgv_Id.MinimumWidth = 6;
            dgv_Id.Name = "dgv_Id";
            dgv_Id.ReadOnly = true;
            dgv_Id.Visible = false;
            dgv_Id.Width = 125;
            // 
            // dgv_Os
            // 
            dgv_Os.DataPropertyName = "OSshow";
            dgv_Os.HeaderText = "OS";
            dgv_Os.MinimumWidth = 6;
            dgv_Os.Name = "dgv_Os";
            dgv_Os.ReadOnly = true;
            dgv_Os.Width = 125;
            // 
            // dgv_category
            // 
            dgv_category.DataPropertyName = "SCshow";
            dgv_category.HeaderText = "Category";
            dgv_category.MinimumWidth = 6;
            dgv_category.Name = "dgv_category";
            dgv_category.ReadOnly = true;
            dgv_category.Resizable = DataGridViewTriState.True;
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
            dgv_imgsrc.Resizable = DataGridViewTriState.True;
            dgv_imgsrc.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_imgsrc.Width = 125;
            // 
            // dgv_summary
            // 
            dgv_summary.DataPropertyName = "summary";
            dgv_summary.HeaderText = "summary";
            dgv_summary.MinimumWidth = 6;
            dgv_summary.Name = "dgv_summary";
            dgv_summary.ReadOnly = true;
            dgv_summary.Resizable = DataGridViewTriState.True;
            dgv_summary.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_summary.Width = 125;
            // 
            // dgv_weblink
            // 
            dgv_weblink.DataPropertyName = "weblink";
            dgv_weblink.HeaderText = "weblink";
            dgv_weblink.MinimumWidth = 6;
            dgv_weblink.Name = "dgv_weblink";
            dgv_weblink.ReadOnly = true;
            dgv_weblink.Resizable = DataGridViewTriState.True;
            dgv_weblink.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_weblink.Width = 125;
            // 
            // dgv_downloadlink
            // 
            dgv_downloadlink.DataPropertyName = "downloadlink";
            dgv_downloadlink.HeaderText = "downloadlink";
            dgv_downloadlink.MinimumWidth = 6;
            dgv_downloadlink.Name = "dgv_downloadlink";
            dgv_downloadlink.ReadOnly = true;
            dgv_downloadlink.Resizable = DataGridViewTriState.True;
            dgv_downloadlink.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            // dgv_edit
            // 
            dgv_edit.HeaderText = "Edit";
            dgv_edit.MinimumWidth = 6;
            dgv_edit.Name = "dgv_edit";
            dgv_edit.Width = 125;
            // 
            // FrmShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 670);
            Controls.Add(LB_Os);
            Controls.Add(CB_Os);
            Controls.Add(btn_new);
            Controls.Add(dgv_show);
            Name = "FrmShow";
            Text = "FrmShow";
            Load += FrmShow_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_show;
        private Button btn_new;
        private ComboBox CB_Os;
        private Label LB_Os;
        private DataGridViewCheckBoxColumn dgv_isactive;
        private DataGridViewTextBoxColumn dgv_Id;
        private DataGridViewTextBoxColumn dgv_Os;
        private DataGridViewTextBoxColumn dgv_category;
        private DataGridViewTextBoxColumn dgv_Name;
        private DataGridViewTextBoxColumn dgv_imgsrc;
        private DataGridViewTextBoxColumn dgv_summary;
        private DataGridViewTextBoxColumn dgv_weblink;
        private DataGridViewTextBoxColumn dgv_downloadlink;
        private DataGridViewTextBoxColumn dgv_details;
        private DataGridViewButtonColumn dgv_edit;
    }
}