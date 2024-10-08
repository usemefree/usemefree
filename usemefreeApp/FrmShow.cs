using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using usemefreeLib.Models;
using static Microsoft.Identity.Client.BrokerOptions;

namespace usemefreeApp;

public partial class FrmShow : Form
{
    const string apiurl = "https://api.usemefree.com/api/DownloadPackageInfo/GetData";
    const string GetApiKey = "5F46B761-956F-4985-A7D2-FEE8B1866F89";
    private readonly HttpClient client;

    public List<DownloadPackageInfo> getInfo { get; private set; }
    public int TotalRecord { get; private set; }
    public List<usemefreeLib.Models.OperatingSystems> operatingSystems { get; private set; }
    public List<SoftwareCategory> softwareCategory { get; private set; }

    Form1 frm = null;
    public FrmShow()
    {
        InitializeComponent();
        client = new HttpClient();
        operatingSystems = new List<usemefreeLib.Models.OperatingSystems>();
        softwareCategory = new List<SoftwareCategory>();
    }

    private void FrmShow_Load(object sender, EventArgs e)
    {
        getOperatingSystems();
        getSoftwareCategory();
        CB_Os.SelectedIndex = 0;
        Loaded(CB_Os.Text);
    }
    private void CB_Os_SelectedIndexChanged(object sender, EventArgs e)
    {
        Loaded(CB_Os.Text);
    }
    private void dgv_show_CellClick(object sender, DataGridViewCellEventArgs e)
    {

        if (e.ColumnIndex == 10 && e.RowIndex >= 0)
        {
            frm = new Form1();
            frm.info = getInfo.FirstOrDefault(x => x.id == (int)dgv_show.Rows[e.RowIndex].Cells[dgv_Id.DisplayIndex].Value);
            frm.operatingSystems = this.operatingSystems;
            frm.softwareCategory = this.softwareCategory;
            frm.ShowDialog();
            Loaded(CB_Os.Text);
        }
    }
    async Task getdata(string os = "windows")
    {
        var request = new HttpRequestMessage(HttpMethod.Get, apiurl);
        request.Headers.Add("ApiKey", GetApiKey);
        request.Headers.Add("os", os);
        var response = await client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var record = JsonConvert.DeserializeObject<Data1>(content);
            if (record != null && record.Message == "Success")
            {
                TotalRecord = record.RecordCount;
                getInfo = ((JArray)record.Record)
                    .Select(x => new DownloadPackageInfo
                    {
                        id = (int)x["id"],
                        isactive = (bool)x["isactive"],
                        os = (int)x["os"],
                        category = (int)x["category"],
                        name = (string)x["name"],
                        imgsrc = (string)x["imgsrc"],
                        summary = (string)x["summary"],
                        weblink = (string)x["weblink"],
                        downloadlink = (string)x["downloadlink"],
                        details = (string)x["details"],
                        counting = (int)x["counting"]
                    }).ToList();

            }
            else
            {
                MessageBox.Show(record.Message);
            }
        }
        else
        {
            MessageBox.Show($"Oops! Something went wrong: {response.StatusCode}");
        }
    }
    async Task Loaded(string os = "windows")
    {
        await getdata(os);
        if (getInfo?.Count > 0)
        {
           var show = getInfo.Select(x => new DownloadPackageShow
           {
               id = x.id,
               isactive = x.isactive,
               os = x.os,
               OSshow = operatingSystems.FirstOrDefault(y=>y.id==x.os).Name,
               category = x.category,
               SCshow =softwareCategory.FirstOrDefault(y=>y.id==x.category).Name,
               name = x.name,
               imgsrc = x.imgsrc,
               summary = x.summary,
               weblink = x.weblink,
               downloadlink = x.downloadlink,
               details = x.details,
               counting = x.counting,
           }).ToList();



            dgv_show.AutoGenerateColumns = false;
            dgv_show.DataSource = show;
        }
    }

    private void btn_new_Click(object sender, EventArgs e)
    {
        frm = new Form1();
        frm.operatingSystems = this.operatingSystems;
        frm.softwareCategory = this.softwareCategory;
        frm.ShowDialog();
    }
    public async Task getOperatingSystems()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://api.usemefree.com/api/OperatingSystem/GetData");
        request.Headers.Add("ApiKey", GetApiKey);
        var response = await client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var record = JsonConvert.DeserializeObject<Data1>(content);
            operatingSystems = ((JArray)record.Record)
                   .Select(x => new usemefreeLib.Models.OperatingSystems
                   {
                       id = (int)x["id"],
                       isactive = (bool)x["isactive"],
                       dateis = (DateTime)x["dateis"],
                       Name = (string)x["name"]
                   }).ToList();
        }
        else
        {
            MessageBox.Show($"Oops! Something went wrong: {response.StatusCode}");
        }
    }
    public async Task getSoftwareCategory()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://api.usemefree.com/api/SoftwareCategory/GetData");
        request.Headers.Add("ApiKey", GetApiKey);
        var response = await client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var record = JsonConvert.DeserializeObject<Data1>(content);
            softwareCategory = ((JArray)record.Record)
                    .Select(x => new SoftwareCategory
                    {
                        id = (int)x["id"],
                        isactive = (bool)x["isactive"],
                        dateis = (DateTime)x["dateis"],
                        Name = (string)x["name"]
                    }).ToList();
        }
        else
        {
            MessageBox.Show($"Oops! Something went wrong: {response.StatusCode}");
        }
    }

}


public class DownloadPackageShow : DownloadPackageInfo
{
    public string OSshow { get; set; }
    public string SCshow { get; set; }
}