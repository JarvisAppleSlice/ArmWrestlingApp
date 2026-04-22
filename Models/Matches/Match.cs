public class Match
{
    public int Id { get; set; }

    public int ChallengerId { get; set; }
    public int OpponentId { get; set; }

    public ArmType Arm { get; set; }

    public MatchStatus Status { get; set; }

    public DateTime? MatchDate { get; set; }

    public MatchResult Result { get; set; }
}