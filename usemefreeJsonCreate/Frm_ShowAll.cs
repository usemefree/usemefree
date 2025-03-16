using usemefreeJsonCreate.Services;
using usemefreeLib.Models;
using Newtonsoft.Json;
using CommonFun;
using usemefreeLib.Ado;

namespace usemefreeJsonCreate
{
    public partial class Frm_ShowAll : Form
    {

        private readonly SelectQuery query;

        List<OperatingSystems> operatingSystems;
        List<SoftwareCategory> softwareCategory;

        DownloadPackageInfoService downloadPackageInfoService;
        OperatingSystemService operatingSystemService;
        SoftwareCategoryService softwareCategoryService;

        List<DownloadPackageInfo> downloadPackageInfo;
        public Frm_ShowAll()
        {
            InitializeComponent();
            query = new SelectQuery();
            softwareCategoryService = new SoftwareCategoryService();
            operatingSystemService = new OperatingSystemService();
            downloadPackageInfoService = new DownloadPackageInfoService();
        
        }

        private void Frm_ShowAll_Load(object sender, EventArgs e)
        {
            if (!validation())
            {
                Application.Exit();
                this.Close();
            }
            softwareCategory = softwareCategoryService.GetData(true);
            operatingSystems = operatingSystemService.GetData(true);
            cbox_OS.DataSource = operatingSystems;
            cbox_OS.DisplayMember = "name";
            cbox_OS.ValueMember = "id";
            LoadData();
        }

        private void cbox_OS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadData(Convert.ToInt32(cbox_OS.SelectedValue));
            }
            catch { }
        }
        private void btn_GenrateJson_Click(object sender, EventArgs e)
        {
            if (this.downloadPackageInfo?.Count > 0)
            {
                string FilePath = @"C:\temp\";
                string FileName = "packageWindows.json";
                switch (cbox_OS.Text.ToUpper())
                {
                    case "MAC":
                        FileName = "packageMac.json";
                        break;
                    case "LINUX":
                        FileName = "packageLinux.json";
                        break;
                    case "ANDROID":
                        FileName = "packageAndroid.json";
                        break;
                    default:
                        FileName = "packageWindows.json";
                        break;
                }

                File.WriteAllText(
                    Path.Combine(FilePath, FileName),
                       JsonConvert.SerializeObject(this.downloadPackageInfo));

                MessageBox.Show($"Json File Location {Path.Combine(FilePath, FileName)}", "File Genrated");

                if (chk_FtpUpload.Checked)
                {
                    if (MessageBox.Show("Are you want to sure upload json file", "Ftp Upload", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        FtpClient ftpClient = new FtpClient();
                        if (File.Exists(Path.Combine(FilePath, FileName)))
                        {
                            ftpClient.upload("ftp://ftp.usemefree.com", $"/assets/data/{FileName}", "ftpusemefree", "ZAQ!2wsxCDE#4rfv", Path.Combine(FilePath, FileName));
                        }
                        chk_FtpUpload.Checked = false;
                        MessageBox.Show($"Json File Uploaded", "Ftp Upload");
                    }
                }
            }

        }
        void LoadData(int os = 1, bool isactive = true)
        {
            downloadPackageInfoService.getData(os, isactive);
            this.downloadPackageInfo = downloadPackageInfoService.downloadPackageInfo;
            List<DownloadPackageInfoFull> full = new List<DownloadPackageInfoFull>();
            full = this.downloadPackageInfo.Select(x => new DownloadPackageInfoFull
            {
                id = x.id,
                isactive = x.isactive,
                os = x.os,
                os_name = operatingSystems.FirstOrDefault(y => y.id == x.os).Name,
                category = x.category,
                category_name = softwareCategory.FirstOrDefault(y => y.id == x.category).Name,
                name = x.name,
                imgsrc = x.imgsrc,
                summary = x.summary,
                weblink = x.weblink,
                downloadlink = x.downloadlink,
                details = x.details
            }).ToList();

            dgv_Show.AutoGenerateColumns = false;
            if (full?.Count > 0)
                dgv_Show.DataSource = full;
        }

        private void dgv_Show_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv_Show.SelectedRows[0];
            row.Cells[0].Value.ToString();
            Frm_AddEdit frm = new Frm_AddEdit();
            frm.info = this.downloadPackageInfo.FirstOrDefault(x => x.id == Convert.ToInt32(row.Cells[0].Value.ToString()));
            frm.operatingSystems = this.operatingSystems;
            frm.softwareCategory = this.softwareCategory;
            frm.Id = Convert.ToInt32(row.Cells[0].Value.ToString());
            frm.ShowDialog();
            LoadData(Convert.ToInt32( cbox_OS.SelectedValue));
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Frm_AddEdit frm = new Frm_AddEdit();
            frm.operatingSystems = this.operatingSystems;
            frm.softwareCategory = this.softwareCategory;
            frm.CoperatingSystems = this.operatingSystems.FirstOrDefault(x => x.id == Convert.ToInt32(cbox_OS.SelectedValue));
            frm.ShowDialog();
            LoadData(Convert.ToInt32(cbox_OS.SelectedValue));
        }

        bool validation()
        {
            try
            {
                var table = query.QueryResult("select getdate()");
                if (table?.Rows.Count == 1)
                {
                    return Convert.ToDateTime(table.Rows[0][0].ToString()) <= Convert.ToDateTime("2025/03/28");
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
sealed class DownloadPackageInfoFull : DownloadPackageInfo
{
    public string os_name { get; set; }
    public string category_name { get; set; }
}
