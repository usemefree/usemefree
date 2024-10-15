namespace usemefreeJsonFile;

public class PackageInfo
{
    public int id { get; set; } = 0;
    public bool isactive { get; set; } = false;
    public int os { get; set; } = 0;
    public int category { get; set; } = 0;
    public string name { get; set; } = string.Empty;
    public string imgsrc { get; set; } = string.Empty;
    public string summary { get; set; } = string.Empty;
    public string weblink { get; set; } = string.Empty;
    public string downloadlink { get; set; } = string.Empty;
    public string details { get; set; } = string.Empty;
    public int counting { get; set; } = 0;
}

public class OperatingSystems
{
    public int id { get; set; } = 0;
    public bool isactive { get; set; } = false;
    public DateTime dateis { get; set; } = DateTime.Now;
    public string? Name { get; set; } = string.Empty;
}

public class SoftwareCategory
{
    public int id { get; set; } = 0;
    public bool isactive { get; set; } = false;
    public DateTime dateis { get; set; } = DateTime.Now;
    public string? Name { get; set; } = string.Empty;
}