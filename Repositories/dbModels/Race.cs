namespace SSS.Repositories.dbModels;

public class Race
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;
    public DateTime? RaceDay { get; set; }
    public required DateTime StartTime { get; set; }
    public DateTime? StartTime2 { get; set; }
    public int ThrowOuts { get; set; }
}
