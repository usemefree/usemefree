namespace usemefreeLib.Models;

public class SoftwareCategory
{
    public int id { get; set; } = 0;
    public bool isactive { get; set; } = false;
    public DateTime dateis { get; set; } = DateTime.Now;
    public string? Name { get; set; } = string.Empty;
}