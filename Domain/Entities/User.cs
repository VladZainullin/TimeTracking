using Domain.States;

namespace Domain.Entities;

public sealed class User
{
    public int Id { get; set; }

    public UserState State { get; set; } = null!;
    
    internal void ChangeState(UserState state)
    {
        State = state;
    }
}