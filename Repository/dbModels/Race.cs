namespace SSS.Repository.dbModels;

public class Race
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public required DateTime StartTime { get; set; }
    public DateTime? StartTime2 { get; set; }
}
