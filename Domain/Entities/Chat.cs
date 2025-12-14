using Domain.States;

namespace Domain.Entities;

public sealed class Chat
{
    public int Id { get; set; }

    public ChatState State { get; set; } = null!;
    
    internal void ChangeState(ChatState state)
    {
        State = state;
    }
}