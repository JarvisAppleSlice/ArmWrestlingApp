public class MatchRequest
{
    public int Id { get; set; }

    public int FromAthleteId { get; set; }
    public int ToAthleteId { get; set; }

    public ArmType Arm { get; set; }

    public MatchStatus Status { get; set; }

}