using Microsoft.Data.SqlClient;
using System.Data;
using usemefreeLib.Ado;
using usemefreeLib.Models;

namespace usemefreeApi.Services;

public class SoftwareCategoryService
{
    private readonly RecordSet recordSet;
    public SoftwareCategoryService()
    {
        recordSet = new RecordSet();
    }
    public List<SoftwareCategory> GetData(bool isActive = true)
    {
        List<SoftwareCategory> softwareCategories = new List<SoftwareCategory>();
        SqlParameter[] parameters = {
            new SqlParameter("@isactive", isActive)
        };

        string query = $"select * from SoftwareCategory (nolock) where isactive = @isactive";

        DataTable dt = recordSet.getData(query, parameters, commandType: CommandType.Text);
        if (dt?.Rows.Count > 0)
        {
            softwareCategories = dt.AsEnumerable().Select(x => new SoftwareCategory
            {
                id = x.Field<int>("id"),
                isactive = x.Field<bool>("isactive"),
                dateis = x.Field<DateTime>("dateis"),
                Name = x.Field<string>("name"),
            }).ToList();
        }
        return softwareCategories;
    }
}
