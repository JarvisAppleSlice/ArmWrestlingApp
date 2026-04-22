public class Athlete
{
    public int Id { get; set; }
    public string UserId { get; set; }

    public string DisplayName { get; set; }
    public double Weight { get; set; }

    public Armstats LeftArm { get; set; }
    public Armstats RightArm { get; set; }
}