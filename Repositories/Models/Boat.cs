namespace SSS.Repositories.Models;

public class Boat
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string SailNumber { get; set; } = string.Empty;
    public string Skipper { get; set; } = string.Empty;
    public double Finnrating { get; set; }
}
