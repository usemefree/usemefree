using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using usemefreeLib.Ado;
using usemefreeLib.Models;
using static Microsoft.Identity.Client.BrokerOptions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using OperatingSystems = usemefreeLib.Models.OperatingSystems;

namespace usemefreeApp;

public partial class Form1 : Form
{
    const string PostApiKey = "CC2ED0CB-B957-4F65-A3D2-C2E5F2C3D02C";
    const string PutApiKey = "15E7D8A8-3E70-4EAD-B054-38D4F6B7A9A0";
    const string GetApiKey = "5F46B761-956F-4985-A7D2-FEE8B1866F89";

    private readonly HttpClient client;

    public DownloadPackageInfo info { get; set; }
    public List<OperatingSystems> operatingSystems { get; set; }
    public List<SoftwareCategory> softwareCategory { get; set; }

    bool IsEdit = true;
    public Form1()
    {
        InitializeComponent();
        client = new HttpClient();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        CB_Os.DataSource = operatingSystems;
        CB_Os.DisplayMember = "Name";
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
            CB_Os.Text = operatingSystems.FirstOrDefault(x => x.id == info.os).Name;
            CB_category.Text = softwareCategory.FirstOrDefault(x => x.id == info.category).Name;
            txt_Name.Text = info.name;
            txt_Img.Text = info.imgsrc;
            txt_summary.Text = info.summary;
            txt_weblink.Text = info.weblink;
            txt_DownloadLink.Text = info.downloadlink;
            rtxt_Details.Text = info.details;
        }
    }

    private async void btn_Save_Click(object sender, EventArgs e)
    {
        int os = operatingSystems?.FirstOrDefault(x => x.Name.ToUpper().Equals(CB_Os.Text.ToUpper()))?.id ?? 1;
        int category = softwareCategory?.FirstOrDefault(x => x.Name.ToUpper().Equals(CB_category.Text.ToUpper()))?.id ?? 1;
        var info = new DownloadPackageInfo
        {
            id = IsEdit ? Convert.ToInt32(txt_id.Text) : 0,
            isactive = chk_Isactive.Checked,
            os = os,
            category = category,
            name = txt_Name.Text,
            imgsrc = txt_Img.Text,
            summary = txt_summary.Text,
            weblink = txt_weblink.Text,
            downloadlink = txt_DownloadLink.Text,
            details = rtxt_Details.Text
        };
        if (IsEdit)
            await Putdata(info);
        else
            await Postdata(info);

        // string query = string.Empty;
        //List<SqlParameter> parameters = new List<SqlParameter>();
        // parameters.Add(new SqlParameter("@isactive", chk_Isactive.Checked));
        // parameters.Add(new SqlParameter("@os", txt_OS.Text));
        // parameters.Add(new SqlParameter("@name", txt_Name.Text));
        // parameters.Add(new SqlParameter("@imgsrc", txt_Img.Text));
        // parameters.Add(new SqlParameter("@summary", txt_summary.Text));
        // parameters.Add(new SqlParameter("@weblink", txt_weblink.Text));
        // parameters.Add(new SqlParameter("@downloadlink", txt_DownloadLink.Text));
        // parameters.Add(new SqlParameter("@details", rtxt_Details.Text));

        // if (IsEdit) {
        //     parameters.Add(new SqlParameter("@id", txt_id.Text));
        //     //update
        //     query = $" update info set isactive=@isactive,os=@os, name=@name, imgsrc=@imgsrc, summary=@summary, weblink=@weblink, downloadlink=@downloadlink, details=@details where id = @id;";
        // }
        // else {
        //     //insert
        //     query = $" insert into info (isactive, os, name, imgsrc, summary, weblink, downloadlink, details) values(@isactive, @os, @name, @imgsrc, @summary, @weblink, @downloadlink, @details);";
        // }
        // SelectQuery selectQuery = new SelectQuery();
        // selectQuery.InsertUpdate(query, parameters.ToArray());
        // MessageBox.Show("Done..");
    }

    async Task Postdata(DownloadPackageInfo info)
    {
        var jsonBody = JsonConvert.SerializeObject(info);
        var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
        client.DefaultRequestHeaders.Add("ApiKey", PostApiKey);

        var response = await client.PostAsync("https://api.usemefree.com/api/DownloadPackageInfo/AddData", content);

        if (response.IsSuccessStatusCode)
        {
            MessageBox.Show("Item created successfully!");
        }
        else
        {
            MessageBox.Show($"Oops! Something went wrong: {response.StatusCode}");
        }
    }
    async Task Putdata(DownloadPackageInfo info)
    {
        var jsonBody = JsonConvert.SerializeObject(info);
        var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
        client.DefaultRequestHeaders.Add("ApiKey", PutApiKey);

        var response = await client.PutAsync("https://api.usemefree.com/api/DownloadPackageInfo/EditData", content);

        if (response.IsSuccessStatusCode)
        {
            MessageBox.Show("Item update successfully!");
        }
        else
        {
            MessageBox.Show($"Oops! Something went wrong: {response.StatusCode}");
        }
    }

    //public async Task getOperatingSystems()
    //{
    //    var request = new HttpRequestMessage(HttpMethod.Get, "https://api.usemefree.com/api/OperatingSystem/GetData");
    //    request.Headers.Add("ApiKey", GetApiKey);
    //    var response = await client.SendAsync(request);
    //    if (response.IsSuccessStatusCode)
    //    {
    //        var content = await response.Content.ReadAsStringAsync();
    //        var record = JsonConvert.DeserializeObject<Data1>(content);
    //        operatingSystems = ((JArray)record.Record)
    //               .Select(x => new OperatingSystems
    //               {
    //                   id = (int)x["id"],
    //                   isactive = (bool)x["isactive"],
    //                   dateis = (DateTime)x["dateis"],
    //                   Name = (string)x["Name"]
    //               }).ToList();
    //    }
    //    else
    //    {
    //        MessageBox.Show($"Oops! Something went wrong: {response.StatusCode}");
    //    }
    //}
    //public async Task getSoftwareCategory()
    //{
    //    var request = new HttpRequestMessage(HttpMethod.Get, "https://api.usemefree.com/api/OperatingSystem/GetData");
    //    request.Headers.Add("ApiKey", GetApiKey);
    //    var response = await client.SendAsync(request);
    //    if (response.IsSuccessStatusCode)
    //    {
    //        var content = await response.Content.ReadAsStringAsync();
    //        var record = JsonConvert.DeserializeObject<Data1>(content);
    //        softwareCategory = ((JArray)record.Record)
    //                .Select(x => new SoftwareCategory
    //                {
    //                    id = (int)x["id"],
    //                    isactive = (bool)x["isactive"],
    //                    dateis = (DateTime)x["dateis"],
    //                    Name = (string)x["Name"]
    //                }).ToList();
    //    }
    //    else
    //    {
    //        MessageBox.Show($"Oops! Something went wrong: {response.StatusCode}");
    //    }
    //}
}
