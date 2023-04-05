namespace Question06.Console.Entities;

public record Bounty(
    Person Person,
    int Reward,
    Danger Danger,
    City City,
    bool DeadOrAlive)
{
    public int Attractiveness => throw new NotImplementedException();
}
