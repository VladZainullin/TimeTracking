namespace Domain.Entities;

/// <summary>
///     Отработка
/// </summary>
public sealed class CompensatoryTimeEarned
{
    public DateTimeOffset StartAt { get; init; }
    
    public DateTimeOffset EndAt { get; init; }

    public string Description { get; init; } = null!;

    public int UserId { get; set; }
}