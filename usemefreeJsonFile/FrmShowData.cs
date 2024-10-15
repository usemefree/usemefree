using Newtonsoft.Json;
namespace usemefreeJsonFile;

public partial class FrmShowData : Form
{
    List<PackageInfo> packageInfos = new List<PackageInfo>();
    List<OperatingSystems> operatingSystems;
    List<SoftwareCategory> softwareCategory;
    public FrmShowData()
    {
        InitializeComponent();
        operatingSystems=getOperatingSystems();
        softwareCategory=getSoftwareCategory();
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
            if (packageInfos?.Count > 0)
            {
                dgv_Show.AutoGenerateColumns = false;
                dgv_Show.DataSource = packageInfos;
            }
        }
        else
        {
            MessageBox.Show("File not found given path");
        }
    }

    private void btn_Export_Click(object sender, EventArgs e)
    {

    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        Frm_AddEdit frm = new Frm_AddEdit();
        frm.operatingSystems = this.operatingSystems;
        frm.softwareCategory = this.softwareCategory;
        frm.ShowDialog();
    }

    private void dgv_Show_MouseClick(object sender, MouseEventArgs e)
    {
    }

    private void dgv_Show_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex >= 0 && e.ColumnIndex == 10)
        {
            var Id = Convert.ToInt32(dgv_Show.Rows[e.RowIndex].Cells[dgv_Id.Index].Value.ToString());
            MessageBox.Show(Id.ToString());
            Frm_AddEdit frm = new Frm_AddEdit();
            frm.operatingSystems=this.operatingSystems;
            frm.softwareCategory=this.softwareCategory;
            frm.info = packageInfos.FirstOrDefault(x => x.id == Id);
            frm.ShowDialog();

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
