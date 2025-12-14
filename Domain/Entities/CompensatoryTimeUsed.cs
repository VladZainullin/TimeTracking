namespace Domain.Entities;

/// <summary>
///     Отгул
/// </summary>
public sealed class CompensatoryTimeUsed
{
    public DateTimeOffset StartAt { get; set; }

    public DateTimeOffset EndAt { get; set; }

    public int UserId { get; set; }
}