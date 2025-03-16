using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using usemefreeLib.Ado;
using usemefreeLib.Models;

namespace usemefreeJsonCreate.Services;

class SoftwareCategoryService
{
    private readonly RecordSet recordSet;
    public SoftwareCategoryService()
    {
        recordSet = new RecordSet();
    }
    public List<SoftwareCategory> GetData(bool isActive = true)
    {
        List<SoftwareCategory> softwareCategory = new List<SoftwareCategory>();
        SqlParameter[] parameters = {
            new SqlParameter("@isactive", isActive)
        };

        string query = $"select * from SoftwareCategory (nolock) where isactive = @isactive";

        DataTable dt = recordSet.getData(query, parameters, commandType: CommandType.Text);
        if (dt?.Rows.Count > 0)
        {
            softwareCategory = dt.AsEnumerable().Select(x => new SoftwareCategory
            {
                id = x.Field<int>("id"),
                isactive = x.Field<bool>("isactive"),
                dateis = x.Field<DateTime>("dateis"),
                Name = x.Field<string>("name"),
            }).ToList();
        }
        return softwareCategory;
    }
}
