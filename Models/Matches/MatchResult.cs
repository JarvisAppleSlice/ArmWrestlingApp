public class MatchResult
{
    public int Id { get; set; }

    public int MatchId { get; set; }

    public int WinnerId { get; set; }
    public int LoserId { get; set; }

    public int WinnerScore { get; set; }
    public int LoserScore { get; set; }

    public bool IsConfirmed { get; set; }
}