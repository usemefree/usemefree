using Newtonsoft.Json;
namespace usemefreeJsonFile;

public partial class FrmShowData : Form
{
    List<PackageInfo> packageInfos = new List<PackageInfo>();
    List<OperatingSystems> operatingSystems;
    List<SoftwareCategory> softwareCategory;
    int MaxId = 0;
    public FrmShowData()
    {
        InitializeComponent();
        operatingSystems = getOperatingSystems();
        softwareCategory = getSoftwareCategory();
    }

    private void btnImport_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "json file (*.json)|*.json";
        openFileDialog.Title = "Select a json file";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            txt_FilePath.Text = openFileDialog.FileName;
        }

        if (File.Exists(txt_FilePath.Text))
        {
            var jsonString = File.ReadAllText(txt_FilePath.Text);
            packageInfos = JsonConvert.DeserializeObject<List<PackageInfo>>(jsonString);
            DataLoad();
        }
        else
        {
            MessageBox.Show("File not found given path");
        }
    }

    private void btn_Export_Click(object sender, EventArgs e)
    {
        WrieJsonFile(false);
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
    void WrieJsonFile(bool IsAutoSave = true)
    {
        if (!string.IsNullOrWhiteSpace(txt_FilePath.Text))
        {
            if (Directory.Exists(Path.GetDirectoryName(txt_FilePath.Text)))
            {
                if (IsAutoSave)
                {
                    File.WriteAllText(
                        Path.Combine(Path.GetDirectoryName(txt_FilePath.Text), $"Package_{DateTime.Now.ToString(format: "yyyyMMMdd_hhmmssffffff")}.json"),
                        JsonConvert.SerializeObject(packageInfos)
                        );
                }
                else
                {
                    if (MessageBox.Show($"{Path.GetDirectoryName(txt_FilePath.Text)}\nAre you went to sure...", "Export", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        File.WriteAllText(
                        Path.Combine(Path.GetDirectoryName(txt_FilePath.Text), $"Package_{DateTime.Now.ToString(format: "yyyyMMMdd_hhmmssffffff")}.json"),
                        JsonConvert.SerializeObject(packageInfos)
                        );
                    }
                }
            }
        }
    }
    List<OperatingSystems> getOperatingSystems()
    {
        return new List<OperatingSystems> {
            new OperatingSystems {
                id=1,
                isactive=true,
                dateis=DateTime.Now,
                Name="Windows"
            },
            new OperatingSystems {
                id=2,
                isactive=true,
                dateis=DateTime.Now,
                Name="Linux"
            },
            new OperatingSystems {
                id=3,
                isactive=true,
                dateis=DateTime.Now,
                Name="Mac"
            },
            new OperatingSystems {
                id=4,
                isactive=true,
                dateis=DateTime.Now,
                Name="Android"
            }
        };
    }
    List<SoftwareCategory> getSoftwareCategory()
    {
        return new List<SoftwareCategory> {
            new SoftwareCategory {
                id=1,
                isactive=true,
                dateis=DateTime.Now,
                Name="Tools"
            },
            new SoftwareCategory {
                id=2,
                isactive=true,
                dateis=DateTime.Now,
                Name="Browser"
            },
            new SoftwareCategory {
                id=3,
                isactive=true,
                dateis=DateTime.Now,
                Name="AntiVirus"
            },
            new SoftwareCategory {
                id=4,
                isactive=true,
                dateis=DateTime.Now,
                Name="Dev Tools"
            }
        };
    }
}
