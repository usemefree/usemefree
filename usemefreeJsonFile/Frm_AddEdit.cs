using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usemefreeJsonFile;

public partial class Frm_AddEdit : Form
{
    public PackageInfo info { get; set; }
    bool IsEdit = true;
    public List<OperatingSystems> operatingSystems { get; set; }
    public List<SoftwareCategory> softwareCategory { get; set; }
    public Frm_AddEdit()
    {
        InitializeComponent();
    }

    private void Frm_AddEdit_Load(object sender, EventArgs e)
    {

        CB_Os.DataSource=operatingSystems;
        CB_Os.DisplayMember="Name";
        CB_Os.ValueMember = "id";

        CB_category.DataSource = softwareCategory;
        CB_category.DisplayMember = "Name";
        CB_category.ValueMember = "id";


        if (info is null)
        {
            IsEdit = false;
        }
        else
        {
            txt_id.Text = info.id.ToString();
            chk_Isactive.Checked = info.isactive;
            CB_Os.Text = operatingSystems.FirstOrDefault(x => x.id == info.os).Name ??"Windows";
            CB_category.Text = softwareCategory.FirstOrDefault(x => x.id == info.category).Name ??"Tools";
            txt_Name.Text = info.name;
            txt_Img.Text = info.imgsrc;
            txt_summary.Text = info.summary;
            txt_weblink.Text = info.weblink;
            txt_DownloadLink.Text = info.downloadlink;
            rtxt_Details.Text = info.details;
        }
    }
}
