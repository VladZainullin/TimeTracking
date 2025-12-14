namespace Domain.Entities;

public class User
{
    public int Id { get; set; }

    public State State { get; set; }
}

public enum State
{
    Start,
    Profile,
    Name,
    Surname,
    Chief,
    CompensatoryTimeUsed,
    CompensatoryTimeUsedStart,
    CompensatoryTimeUsedEnd,
    CompensatoryTimeUsedDescription,
    CompensatoryTimeEarned,
    CompensatoryTimeEarnedStart,
    CompensatoryTimeEarnedEnd,
    CompensatoryTimeEarnedDescription,
}