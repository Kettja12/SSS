namespace SSS.Repositories.dbModels;

public class Result
{
    public int Id { get; set; }
    public int RaceId { get; set; }
    public int BoatId { get; set; }
    public DateTime? FirstEndTime { get; set; }
    public DateTime? SecondEndTime { get; set; }
    public bool DNF1 { get; set; }
    public bool DNS1 { get; set; }
    public bool DNF2 { get; set; }
    public bool DNS2 { get; set; }
    public bool Registration { get; set; }
    public int Position { get; set; }
    public int PositionRace1 { get; set; }
    public int PositionRace2 { get; set; }


}
