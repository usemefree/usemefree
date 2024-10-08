using Microsoft.AspNetCore.Components;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using usemefreeLib.Ado;
using usemefreeLib.Models;

namespace usemefreeApi.Services;

public class OperatingSystemService
{
    private readonly RecordSet recordSet;
    public OperatingSystemService()
    {
        recordSet = new RecordSet();
    }
    public List<OperatingSystems> GetData(bool isActive = true)
    {
        List<OperatingSystems> operatingSystems = new List<OperatingSystems>();
        SqlParameter[] parameters = { 
            new SqlParameter("@isactive", isActive) 
        };

        string query = $"select * from OperatingSystems (nolock) where isactive = @isactive";

        DataTable dt = recordSet.getData(query, parameters, commandType: CommandType.Text);
        if (dt?.Rows.Count > 0)
        {
            operatingSystems = dt.AsEnumerable().Select(x => new OperatingSystems
            {
                id = x.Field<int>("id"),
                isactive = x.Field<bool>("isactive"),
                dateis = x.Field<DateTime>("dateis"),
                Name = x.Field<string>("name"),
            }).ToList();
        }
        return operatingSystems;
    }
}
