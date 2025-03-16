using Newtonsoft.Json;
using System.IO;

namespace usemefreeHttpClient;

public partial class Frm_ShowData : Form
{
    List<PackageInfo> packageInfos = null;
    List<OperatingSystems> operatingSystems = null;
    List<SoftwareCategory> softwareCategory = null;
    OSEnum oSEnum = OSEnum.WINDOWS;
    int MaxId = 0;
    private readonly string BaseUrl;
    public Frm_ShowData()
    {
        InitializeComponent();
        BaseUrl = "https://www.usemefree.com/";
        packageInfos = new List<PackageInfo>();
        operatingSystems = new List<OperatingSystems>();
        softwareCategory = new List<SoftwareCategory>();
    }

    private async void Frm_ShowData_Load(object sender, EventArgs e)
    {
        var os = await client($"{BaseUrl}assets/data/operatingSystems.json");
        operatingSystems = JsonConvert.DeserializeObject<List<OperatingSystems>>(os);

        var category = await client($"{BaseUrl}assets/data/softwareCategory.json");
        softwareCategory = JsonConvert.DeserializeObject<List<SoftwareCategory>>(category);


    }
    private async void btnLoad_Click(object sender, EventArgs e)
    {
        oSEnum = OSEnum.WINDOWS;
        var jsonString = await client($"{BaseUrl}assets/data/packagewindows.json");
        packageInfos = JsonConvert.DeserializeObject<List<PackageInfo>>(jsonString);
        if (packageInfos?.Count > 0)
        {
            DataLoad();
        }
    }
    private async void btnLoadLin_Click(object sender, EventArgs e)
    {
        oSEnum = OSEnum.LINUX;
        var jsonString = await client($"{BaseUrl}assets/data/packageLinux.json");
        packageInfos = JsonConvert.DeserializeObject<List<PackageInfo>>(jsonString);
        if (packageInfos?.Count > 0)
        {
            DataLoad();
        }
    }

    private async void btnLoadMac_Click(object sender, EventArgs e)
    {
        oSEnum = OSEnum.MAC;
        var jsonString = await client($"{BaseUrl}assets/data/packageMac.json");
        packageInfos = JsonConvert.DeserializeObject<List<PackageInfo>>(jsonString);
        if (packageInfos?.Count > 0)
        {
            DataLoad();
        }
    }

    private async void btnLoadAnd_Click(object sender, EventArgs e)
    {
        oSEnum = OSEnum.ANDROID;
        var jsonString = await client($"{BaseUrl}assets/data/packageAndroid.json");
        packageInfos = JsonConvert.DeserializeObject<List<PackageInfo>>(jsonString);
        if (packageInfos?.Count > 0)
        {
            DataLoad();
        }

    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        Frm_AddEdit frm = new Frm_AddEdit();
        frm.operatingSystems = this.operatingSystems;
        frm.softwareCategory = this.softwareCategory;
        frm.Id = MaxId + 1;
        frm.ShowDialog();
        if (frm.IsSave)
        {
            if (packageInfos.FirstOrDefault(x => x.id == frm.info.id) == null)
            {
                packageInfos.Add(frm.info);
            }
            WrieJsonFile(true);
        }
        DataLoad();
    }

    private void dgv_Show_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex >= 0 && e.ColumnIndex == 10)
        {
            var Id = Convert.ToInt32(dgv_Show.Rows[e.RowIndex].Cells[dgv_Id.Index].Value.ToString());
            MessageBox.Show(Id.ToString());
            Frm_AddEdit frm = new Frm_AddEdit();
            frm.operatingSystems = this.operatingSystems;
            frm.softwareCategory = this.softwareCategory;
            frm.info = packageInfos.FirstOrDefault(x => x.id == Id);
            frm.Id = Id;
            frm.ShowDialog();
            if (frm.IsSave)
            {
                var itemToUpdate = packageInfos.FirstOrDefault(x => x.id == frm.info.id);
                if (itemToUpdate != null)
                {
                    itemToUpdate.isactive = frm.info.isactive;
                    itemToUpdate.os = frm.info.os;
                    itemToUpdate.category = frm.info.category;
                    itemToUpdate.name = frm.info.name;
                    itemToUpdate.imgsrc = frm.info.imgsrc;
                    itemToUpdate.summary = frm.info.summary;
                    itemToUpdate.weblink = frm.info.weblink;
                    itemToUpdate.downloadlink = frm.info.downloadlink;
                    itemToUpdate.details = frm.info.details;
                }
                WrieJsonFile(true);
            }
            DataLoad();
        }
    }
    void DataLoad()
    {
        dgv_Show.DataSource = null;
        if (packageInfos?.Count > 0)
        {
            MaxId = packageInfos.Max(x => x.id);
            dgv_Show.AutoGenerateColumns = false;
            dgv_Show.DataSource = packageInfos;
        }
        else
        {
            MessageBox.Show("No record found");
        }
    }
    public async Task<string> client(string Url)
    {
        try
        {
            // Create an instance of HttpClient
            using (HttpClient client = new HttpClient())
            {
                // Make a GET request
                HttpResponseMessage response = await client.GetAsync(Url);

                // Check if the response is successful (status code 200-299)
                if (response.IsSuccessStatusCode)
                {
                    // Read and display the response body
                    string content = await response.Content.ReadAsStringAsync();
                    return content;
                }
                else
                {
                    Console.WriteLine($"Request failed with status code {response.StatusCode}");
                    return "No Data Found";
                }
            }
        }
        catch (Exception ex) { return ex.Message; }

    }
    public void WrieJsonFile(bool IsAutoSave = true)
    {
        if (!string.IsNullOrWhiteSpace(txt_FilePath.Text))
        {
            if (Directory.Exists(Path.GetDirectoryName(txt_FilePath.Text)))
            {
                if (IsAutoSave)
                {
                    File.WriteAllText(
                        Path.Combine(Path.GetDirectoryName(txt_FilePath.Text), $"Package{oSEnum.ToString()}_{DateTime.Now.ToString(format: "yyyyMMMdd_hhmmssffffff")}.json"),
                        JsonConvert.SerializeObject(packageInfos)
                        );
                }
                else
                {
                    if (MessageBox.Show($"{Path.GetDirectoryName(txt_FilePath.Text)}\nAre you went to sure...", "Export", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        File.WriteAllText(
                        Path.Combine(Path.GetDirectoryName(txt_FilePath.Text), $"Package{oSEnum.ToString()}_{DateTime.Now.ToString(format: "yyyyMMMdd_hhmmssffffff")}.json"),
                        JsonConvert.SerializeObject(packageInfos)
                        );
                    }
                }
            }
        }
    }

   
}
public enum OSEnum
{
    WINDOWS=1,
    LINUX,
    MAC,
    ANDROID
}