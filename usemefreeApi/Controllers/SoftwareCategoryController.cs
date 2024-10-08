using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using usemefreeApi.Services;
using usemefreeLib.Models;

namespace usemefreeApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SoftwareCategoryController : ControllerBase
{
    private readonly ApiKeyService apiKeyService;
    private readonly SoftwareCategoryService _servcies;
    public SoftwareCategoryController()
    {
        apiKeyService = new ApiKeyService();
        _servcies =new SoftwareCategoryService();
    }
    [HttpGet("GetData")]
    public async Task<IActionResult> GetData([FromHeader] string ApiKey)
    {
        if (string.IsNullOrEmpty(ApiKey))
            return BadRequest("ApiKey is requierd");

        if (apiKeyService.IsKeyActive(new Guid(ApiKey)))
        {
            var result = _servcies.GetData(true);
            return Ok(new Data1 { RecordCount = result.Count, Message = "Success", Record = result });
        }
        else
        {
            return BadRequest("ApiKey Not found");
        }
    }
}
