using Domain.Entities;

namespace Domain.States;

public abstract class ChatState
{
    public static readonly StartState Start = new();
    public static readonly InitialNameState InitialName = new();
    public static readonly InitialSurnameState InitialSurname = new();
    public static readonly ProfileState Profile = new();
    public static readonly NameState Name = new();
    public static readonly SurnameState Surname = new();
    
    public abstract string Message { get; }
    
    public virtual void ToStart(Chat chat)
    {
    }

    public virtual void ToInitialName(Chat chat)
    {
    }
    
    public virtual void ToInitialSurname(Chat chat)
    {
    }

    public virtual void ToProfile(Chat chat)
    {
    }

    public virtual void ToName(Chat chat)
    {
    }

    public virtual void ToSurname(Chat chat)
    {
    }
}