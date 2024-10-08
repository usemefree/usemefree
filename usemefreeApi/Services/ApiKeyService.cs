using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using usemefreeLib.Ado;
using usemefreeLib.Models;

namespace usemefreeApi.Services;

public class ApiKeyService
{
    private readonly ScallerValue scallerValue;
    public ApiKeyService() => scallerValue = new ScallerValue();

    public bool IsKeyActive(Guid ApiKey,string httpVerb = "GET")
    {
        List<SqlParameter> parameters = new List<SqlParameter>();
        parameters.Add(new SqlParameter("@verb", httpVerb));
        parameters.Add(new SqlParameter("@apikey", ApiKey));

        var result = scallerValue.getScaller($"select top 1 1 from apikey (nolock) where isactive = 1 and Verb=@verb and apikey=@apikey", parameters.ToArray());
        return Convert.ToBoolean(result);
    }
}
