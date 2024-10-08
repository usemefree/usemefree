using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;
using usemefreeApi.Services;
using usemefreeLib.Ado;
using usemefreeLib.Models;

namespace usemefreeApi.Controllers;



[Route("api/[controller]")]
[ApiController]
public class DownloadPackageInfoController : ControllerBase
{
    private readonly ApiKeyService apiKeyService;
    private readonly DownloadPackageInfoService services;
    private readonly OperatingSystemService operatingSystemService;
    private readonly SoftwareCategoryService softwareCategoryService;

    int os = 1;
    List<OperatingSystems> operatingSystems;

    public DownloadPackageInfoController()
    {
        apiKeyService = new ApiKeyService();
        services = new DownloadPackageInfoService();
        operatingSystemService = new OperatingSystemService();
        softwareCategoryService = new SoftwareCategoryService();

        operatingSystems = new List<OperatingSystems>();
        operatingSystems = operatingSystemService.GetData(true);
    }

    [HttpGet("GetData")]
    public async Task<IActionResult> GetData([FromHeader] string ApiKey, [FromHeader] string os = "windows")
    {
        if (string.IsNullOrEmpty(ApiKey))
            return BadRequest("ApiKey is requierd");

        this.os = operatingSystems.FirstOrDefault(x => x.Name.ToUpper() == os.ToUpper()).id;
        if (os is null)
            return BadRequest("OS not found");

        //if (softwareCategoryService.GetData(true)?.FirstOrDefault(x => x.Name == "")?.Name is null)
        //    return BadRequest("OS not found");

        if (apiKeyService.IsKeyActive(new Guid(ApiKey)))
        {
            services.getData(this.os);
            var result = services.downloadPackageInfo;
            return Ok(new Data1 { RecordCount = result.Count, Message = "Success", Record = result });
        }
        else
        {
            return BadRequest("ApiKey Not found");
        }
    }

    [HttpGet("GetDataPagination")]
    public async Task<IActionResult> GetDataPagination([FromHeader] string ApiKey, [FromHeader] string os = "windows", [FromQuery] int PageNo = 1, [FromQuery] int PageSize = 10)
    {
        if (string.IsNullOrEmpty(ApiKey))
            return BadRequest("ApiKey is requierd");

        this.os = operatingSystems.FirstOrDefault(x => x.Name.ToUpper() == os.ToUpper()).id;
        if (os is null)
            return BadRequest("OS not found");

        //if (softwareCategoryService.GetData(true)?.FirstOrDefault(x => x.Name == "")?.Name is null)
        //    return BadRequest("OS not found");

        if (apiKeyService.IsKeyActive(new Guid(ApiKey)))
        {
            services.getData(this.os);
            var result = services.downloadPackageInfo;

            var recordCount = result.Count();
            var totalPage = (int)Math.Ceiling((decimal)recordCount / PageSize);
            var pageData = result
                .Skip((PageNo - 1) * PageSize)
                .Take(PageSize)
                    .ToList();

            return Ok(new Data1 { RecordCount = recordCount, Message = "Success", Record = pageData });
        }
        else
        {
            return BadRequest("ApiKey Not found");
        }
    }

    [HttpPost("AddData")]
    public async Task<IActionResult> AddData([FromHeader] string ApiKey, [FromBody] DownloadPackageInfo info)
    {
        if (string.IsNullOrEmpty(ApiKey))
            return BadRequest("ApiKey is requierd");

        if (apiKeyService.IsKeyActive(new Guid(ApiKey), "POST"))
        {
            if (services.AddEdit(info, false) == 1)
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
    public async Task<IActionResult> EditData([FromHeader] string ApiKey, [FromBody] DownloadPackageInfo info)
    {
        SelectQuery selectQuery = new SelectQuery();
        if (string.IsNullOrEmpty(ApiKey))
            return BadRequest("ApiKey is requierd");
        if (apiKeyService.IsKeyActive(new Guid(ApiKey), "PUT"))
        {
            if (services.AddEdit(info, true) == 1)
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
}
