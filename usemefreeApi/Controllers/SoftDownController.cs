using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using usemefreeApi.Services;
using usemefreeLib.Ado;
using usemefreeLib.Models;

namespace usemefreeApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SoftDownController : ControllerBase
{
    private readonly ApiKeyService scallerValue;
    public SoftDownController()
    {
        scallerValue = new ApiKeyService();
    }

    [HttpGet("GetData")]
    public async Task<IActionResult> GetData([FromHeader] string ApiKey, [FromHeader] string os = "windows")
    {
        SelectQuery selectQuery = new SelectQuery();
        if (string.IsNullOrEmpty(ApiKey))
            return BadRequest("ApiKey is requierd");
        if (scallerValue.IsKeyActive(new Guid(ApiKey)))
        {
            DataTable dt = selectQuery.QueryResult($"select * from info (nolock) where isactive = 1 and os='{os}'");
            if (dt?.Rows.Count == 0)
                return NotFound("Record not found");
            var result = dt.AsEnumerable().Select(x => new Info
            {
                id = x.Field<int>("id"),
                isactive = x.Field<bool>("isactive"),
                os = x.Field<string?>("os"),
                category = x.Field<string?>("category"),
                name = x.Field<string?>("name"),
                imgsrc = x.Field<string?>("imgsrc"),
                summary = x.Field<string?>("summary"),
                weblink = x.Field<string?>("weblink"),
                downloadlink = x.Field<string?>("downloadlink"),
                details = x.Field<string?>("details")
            }).OrderBy(x => x.name).ToList();
            return Ok(new Data { RecordCount = result.Count, Message = "Success", Record = result });
        }
        else
        {
            return BadRequest("ApiKey Not found");
        }
    }

    [HttpGet("GetDataPagination")]
    public async Task<IActionResult> GetDataPagination([FromHeader] string ApiKey, [FromHeader] string os = "windows", [FromQuery] int PageNo = 1, [FromQuery] int PageSize = 10)
    {
        SelectQuery selectQuery = new SelectQuery();
        if (string.IsNullOrEmpty(ApiKey))
            return BadRequest("ApiKey is requierd");
        if (scallerValue.IsKeyActive(new Guid(ApiKey)))
        {
            DataTable dt = selectQuery.QueryResult($"select * from info (nolock) where isactive = 1 and os='{os}'");
            if (dt is null || dt.Rows.Count == 0)
                return NotFound("Record not found");
            var result = dt.AsEnumerable().Select(x => new Info
            {
                id = x.Field<int>("id"),
                isactive = x.Field<bool>("isactive"),
                os = x.Field<string?>("os"),
                category = x.Field<string?>("category"),
                name = x.Field<string?>("name"),
                imgsrc = x.Field<string?>("imgsrc"),
                summary = x.Field<string?>("summary"),
                weblink = x.Field<string?>("weblink"),
                downloadlink = x.Field<string?>("downloadlink"),
                details = x.Field<string?>("details")
            }).OrderBy(x => x.name).ToList();

            var recordCount = result.Count();
            var totalPage = (int)Math.Ceiling((decimal)recordCount / PageSize);
            var pageData = result
                .Skip((PageNo - 1) * PageSize)
                .Take(PageSize)
                    .ToList();

            return Ok(new Data { RecordCount = recordCount, Message = "Success", Record = pageData });
        }
        else
        {
            return BadRequest("ApiKey Not found");
        }
    }

    [HttpPost("AddData")]
    public async Task<IActionResult> AddData([FromHeader] string ApiKey, [FromBody] Info info)
    {
        SelectQuery selectQuery = new SelectQuery();
        if (string.IsNullOrEmpty(ApiKey))
            return BadRequest("ApiKey is requierd");
        if (selectQuery.getScaller("select top 1 1 from apikey (nolock) where isactive = 1 and Verb='POST' and apikey='" + ApiKey + "'"))
        {
            if (AddEdit(info, false) == 1)
            {
                return Ok("Data Uploaded Success fully");
            }
            else
            {
                return BadRequest("Fail to upload");
            }
        }
        else
        {
            return BadRequest("ApiKey Not found");
        }
    }
    [HttpPut("EditData")]
    public async Task<IActionResult> EditData([FromHeader] string ApiKey, [FromBody] Info info)
    {
        SelectQuery selectQuery = new SelectQuery();
        if (string.IsNullOrEmpty(ApiKey))
            return BadRequest("ApiKey is requierd");
        if (selectQuery.getScaller("select top 1 1 from apikey (nolock) where isactive = 1 and Verb='PUT' and apikey='" + ApiKey + "'"))
        {
            if (AddEdit(info, true) == 1)
            {
                return Ok("Record Updated Success fully");
            }
            else
            {
                return BadRequest("Fail to upload");
            }
        }
        else
        {
            return BadRequest("ApiKey Not found");
        }
    }
    private int AddEdit(Info info, bool IsEdit = true)
    {
        string query = string.Empty;
        List<SqlParameter> parameters = new List<SqlParameter>();
        parameters.Add(new SqlParameter("@isactive", info.isactive));
        parameters.Add(new SqlParameter("@os", info.os));
        parameters.Add(new SqlParameter("@category", info.category));
        parameters.Add(new SqlParameter("@name", info.name));
        parameters.Add(new SqlParameter("@imgsrc", info.imgsrc));
        parameters.Add(new SqlParameter("@summary", info.summary));
        parameters.Add(new SqlParameter("@weblink", info.weblink));
        parameters.Add(new SqlParameter("@downloadlink", info.downloadlink));
        parameters.Add(new SqlParameter("@details", info.details));

        if (IsEdit)
        {
            parameters.Add(new SqlParameter("@id", info.id));
            //update
            query = $" update info set isactive=@isactive,os=@os, category=@category, name=@name, imgsrc=@imgsrc, summary=@summary, weblink=@weblink, downloadlink=@downloadlink, details=@details where id = @id;";
        }
        else
        {
            //insert
            query = $" insert into info (isactive, os,category, name, imgsrc, summary, weblink, downloadlink, details) values(@isactive, @os, @category, @name, @imgsrc, @summary, @weblink, @downloadlink, @details);";
        }
        SelectQuery selectQuery = new SelectQuery();
        return selectQuery.InsertUpdate(query, parameters.ToArray(), commandType: CommandType.Text);
    }
}
