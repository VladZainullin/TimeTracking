using Domain.Entities;

namespace Domain.States;

public abstract class UserState
{
    public static readonly StartState Start = new();
    public static readonly InitialNameState InitialName = new();
    public static readonly InitialSurnameState InitialSurname = new();
    public static readonly ProfileState Profile = new();
    public static readonly NameState Name = new();
    public static readonly SurnameState Surname = new();
    
    public abstract string Message { get; }
    
    public virtual void ToStart(User user)
    {
    }

    public virtual void ToInitialName(User user)
    {
    }
    
    public virtual void ToInitialSurname(User user)
    {
    }

    public virtual void ToProfile(User user)
    {
    }

    public virtual void ToName(User user)
    {
    }

    public virtual void ToSurname(User user)
    {
    }
}