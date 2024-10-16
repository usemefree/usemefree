namespace usemefreeJsonFile
{
    partial class Frm_AddEdit
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
            panel1 = new Panel();
            CB_category = new ComboBox();
            lbl_category = new Label();
            CB_Os = new ComboBox();
            btn_Save = new Button();
            lbl_DownloadLink = new Label();
            txt_DownloadLink = new TextBox();
            lbl_weblink = new Label();
            txt_weblink = new TextBox();
            lbl_summary = new Label();
            txt_summary = new TextBox();
            lbl_Img = new Label();
            txt_Img = new TextBox();
            lbl_Name = new Label();
            txt_Name = new TextBox();
            lbl_OS = new Label();
            lbl_Id = new Label();
            chk_Isactive = new CheckBox();
            txt_id = new TextBox();
            rtxt_Details = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(CB_category);
            panel1.Controls.Add(lbl_category);
            panel1.Controls.Add(CB_Os);
            panel1.Controls.Add(btn_Save);
            panel1.Controls.Add(lbl_DownloadLink);
            panel1.Controls.Add(txt_DownloadLink);
            panel1.Controls.Add(lbl_weblink);
            panel1.Controls.Add(txt_weblink);
            panel1.Controls.Add(lbl_summary);
            panel1.Controls.Add(txt_summary);
            panel1.Controls.Add(lbl_Img);
            panel1.Controls.Add(txt_Img);
            panel1.Controls.Add(lbl_Name);
            panel1.Controls.Add(txt_Name);
            panel1.Controls.Add(lbl_OS);
            panel1.Controls.Add(lbl_Id);
            panel1.Controls.Add(chk_Isactive);
            panel1.Controls.Add(txt_id);
            panel1.Controls.Add(rtxt_Details);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 589);
            panel1.TabIndex = 1;
            // 
            // CB_category
            // 
            CB_category.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_category.FormattingEnabled = true;
            CB_category.Location = new Point(116, 137);
            CB_category.Name = "CB_category";
            CB_category.Size = new Size(206, 28);
            CB_category.TabIndex = 19;
            // 
            // lbl_category
            // 
            lbl_category.AutoSize = true;
            lbl_category.Location = new Point(45, 141);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new Size(69, 20);
            lbl_category.TabIndex = 18;
            lbl_category.Text = "Category";
            // 
            // CB_Os
            // 
            CB_Os.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Os.FormattingEnabled = true;
            CB_Os.Location = new Point(116, 94);
            CB_Os.Name = "CB_Os";
            CB_Os.Size = new Size(206, 28);
            CB_Os.TabIndex = 17;
            // 
            // btn_Save
            // 
            btn_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Save.Location = new Point(228, 543);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(94, 29);
            btn_Save.TabIndex = 16;
            btn_Save.Text = "&Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // lbl_DownloadLink
            // 
            lbl_DownloadLink.AutoSize = true;
            lbl_DownloadLink.Location = new Point(3, 442);
            lbl_DownloadLink.Name = "lbl_DownloadLink";
            lbl_DownloadLink.Size = new Size(104, 20);
            lbl_DownloadLink.TabIndex = 15;
            lbl_DownloadLink.Text = "DownloadLink";
            // 
            // txt_DownloadLink
            // 
            txt_DownloadLink.Location = new Point(116, 439);
            txt_DownloadLink.Name = "txt_DownloadLink";
            txt_DownloadLink.Size = new Size(206, 27);
            txt_DownloadLink.TabIndex = 14;
            // 
            // lbl_weblink
            // 
            lbl_weblink.AutoSize = true;
            lbl_weblink.Location = new Point(46, 283);
            lbl_weblink.Name = "lbl_weblink";
            lbl_weblink.Size = new Size(63, 20);
            lbl_weblink.TabIndex = 13;
            lbl_weblink.Text = "webLink";
            // 
            // txt_weblink
            // 
            txt_weblink.Location = new Point(116, 279);
            txt_weblink.Name = "txt_weblink";
            txt_weblink.Size = new Size(206, 27);
            txt_weblink.TabIndex = 12;
            // 
            // lbl_summary
            // 
            lbl_summary.AutoSize = true;
            lbl_summary.Location = new Point(39, 496);
            lbl_summary.Name = "lbl_summary";
            lbl_summary.Size = new Size(69, 20);
            lbl_summary.TabIndex = 11;
            lbl_summary.Text = "summary";
            // 
            // txt_summary
            // 
            txt_summary.Location = new Point(116, 491);
            txt_summary.Name = "txt_summary";
            txt_summary.Size = new Size(206, 27);
            txt_summary.TabIndex = 10;
            // 
            // lbl_Img
            // 
            lbl_Img.AutoSize = true;
            lbl_Img.Location = new Point(49, 234);
            lbl_Img.Name = "lbl_Img";
            lbl_Img.Size = new Size(67, 20);
            lbl_Img.TabIndex = 9;
            lbl_Img.Text = "Img Path";
            // 
            // txt_Img
            // 
            txt_Img.Location = new Point(116, 231);
            txt_Img.Name = "txt_Img";
            txt_Img.Size = new Size(206, 27);
            txt_Img.TabIndex = 8;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(60, 184);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(49, 20);
            lbl_Name.TabIndex = 7;
            lbl_Name.Text = "Name";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(116, 180);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(206, 27);
            txt_Name.TabIndex = 6;
            // 
            // lbl_OS
            // 
            lbl_OS.AutoSize = true;
            lbl_OS.Location = new Point(81, 97);
            lbl_OS.Name = "lbl_OS";
            lbl_OS.Size = new Size(28, 20);
            lbl_OS.TabIndex = 5;
            lbl_OS.Text = "OS";
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize = true;
            lbl_Id.Location = new Point(81, 29);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(22, 20);
            lbl_Id.TabIndex = 3;
            lbl_Id.Text = "Id";
            // 
            // chk_Isactive
            // 
            chk_Isactive.AutoSize = true;
            chk_Isactive.Location = new Point(49, 58);
            chk_Isactive.Name = "chk_Isactive";
            chk_Isactive.RightToLeft = RightToLeft.Yes;
            chk_Isactive.Size = new Size(82, 24);
            chk_Isactive.TabIndex = 2;
            chk_Isactive.Text = "IsActive";
            chk_Isactive.UseVisualStyleBackColor = true;
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.White;
            txt_id.Location = new Point(116, 25);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(206, 27);
            txt_id.TabIndex = 1;
            // 
            // rtxt_Details
            // 
            rtxt_Details.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtxt_Details.Location = new Point(383, 17);
            rtxt_Details.Name = "rtxt_Details";
            rtxt_Details.Size = new Size(668, 555);
            rtxt_Details.TabIndex = 0;
            rtxt_Details.Text = "";
            // 
            // Frm_AddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 607);
            Controls.Add(panel1);
            Name = "Frm_AddEdit";
            Text = "Frm_AddEdit";
            Load += Frm_AddEdit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox CB_category;
        private Label lbl_category;
        private ComboBox CB_Os;
        private Button btn_Save;
        private Label lbl_DownloadLink;
        private TextBox txt_DownloadLink;
        private Label lbl_weblink;
        private TextBox txt_weblink;
        private Label lbl_summary;
        private TextBox txt_summary;
        private Label lbl_Img;
        private TextBox txt_Img;
        private Label lbl_Name;
        private TextBox txt_Name;
        private Label lbl_OS;
        private Label lbl_Id;
        private CheckBox chk_Isactive;
        private TextBox txt_id;
        private RichTextBox rtxt_Details;
    }
}