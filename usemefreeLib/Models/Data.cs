namespace usemefreeLib.Models;
public class Data
{
    public int RecordCount { get; set; } = 0;
    public string Message { get; set; } = string.Empty;
    public List<Info> Record { get; set; } 
}

public class Data1
{
    public int RecordCount { get; set; } = 0;
    public string Message { get; set; } = string.Empty;
    public dynamic Record { get; set; }
}