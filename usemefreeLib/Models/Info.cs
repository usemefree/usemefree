namespace usemefreeLib.Models;

public class Info
{
    public int id { get; set; } = 0;
    public bool isactive { get; set; } = false;
    public string? os { get; set; } = string.Empty;
    public string? category { get; set; } = string.Empty;
    public string? name { get; set; } = string.Empty;
    public string? imgsrc { get; set; } = string.Empty;
    public string? summary { get; set; } = string.Empty;
    public string? weblink { get; set; } = string.Empty;
    public string? downloadlink { get; set; } = string.Empty;
    public string? details { get; set; } = string.Empty;
}