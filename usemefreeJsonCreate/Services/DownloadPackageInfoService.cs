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

class DownloadPackageInfoService
{
    private readonly RecordSet recordSet;
    private readonly SelectQuery query;
    public DownloadPackageInfoService()
    {
        recordSet = new RecordSet();
        query = new SelectQuery();
    }
    public List<DownloadPackageInfo> downloadPackageInfo { get; private set; }
    public void getData(int Os = 1, bool isActive = true)
    {
        List<SqlParameter> parameters = new List<SqlParameter>();
        //parameters.Add(new SqlParameter("@isactive", isActive));
        parameters.Add(new SqlParameter("@os", Os));

        string query = $"select * from DownloadPackageInfo (nolock) where os=@os;";

        DataTable dt = recordSet.getData(query, parameters.ToArray(), commandType: CommandType.Text);
        if (dt?.Rows.Count > 0)
        {
            downloadPackageInfo = dt.AsEnumerable().Select(x => new DownloadPackageInfo
            {
                id = x.Field<int>("id"),
                isactive = x.Field<bool>("isactive"),
                os = x.Field<int>("os"),
                category = x.Field<int>("category"),
                name = x.Field<string?>("name"),
                imgsrc = x.Field<string?>("imgsrc"),
                summary = x.Field<string?>("summary"),
                weblink = x.Field<string?>("weblink"),
                downloadlink = x.Field<string?>("downloadlink"),
                details = x.Field<string?>("details"),
                counting = x.Field<int>("counting")
            }).ToList();
        }
    }

    public void setData(bool isEdit, DownloadPackageInfo downloadPackageInfo)
    {
        string sqlquery = string.Empty;

        List<SqlParameter> parameters = new List<SqlParameter>();
        parameters.Add(new SqlParameter("@id", downloadPackageInfo.id));
        parameters.Add(new SqlParameter("@isactive", downloadPackageInfo.isactive));
        parameters.Add(new SqlParameter("@os", downloadPackageInfo.os));
        parameters.Add(new SqlParameter("@category", downloadPackageInfo.category));
        parameters.Add(new SqlParameter("@name", downloadPackageInfo.name));
        parameters.Add(new SqlParameter("@imgsrc", downloadPackageInfo.imgsrc));
        parameters.Add(new SqlParameter("@summary", downloadPackageInfo.summary));
        parameters.Add(new SqlParameter("@weblink", downloadPackageInfo.weblink));
        parameters.Add(new SqlParameter("@downloadlink", downloadPackageInfo.downloadlink));
        parameters.Add(new SqlParameter("@details", downloadPackageInfo.details));
        parameters.Add(new SqlParameter("@counting", downloadPackageInfo.counting));

        if (isEdit)
            sqlquery = $"update DownloadPackageInfo set isactive=@isactive, os=@os, category=@category, name=@name, imgsrc=@imgsrc, summary=@summary, weblink=@weblink, downloadlink=@downloadlink, details=@details, counting=@counting where id=@id ";
        else
            sqlquery = $"Insert Into DownloadPackageInfo(isactive,os,category,name,imgsrc,summary,weblink,downloadlink,details,counting) values(@isactive,@os,@category,@name,@imgsrc,@summary,@weblink,@downloadlink,@details,@counting) ";

        query.InsertUpdate(sqlquery, parameters.ToArray(), CommandType.Text);
    }
}
