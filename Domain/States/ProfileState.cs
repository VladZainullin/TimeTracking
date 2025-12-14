using Domain.Entities;

namespace Domain.States;

public sealed class ProfileState : UserState
{
    public override string Message => "Выберите изменение";

    public override void ToStart(User user)
    {
        user.ChangeState(Start);
    }

    public override void ToName(User user)
    {
        user.ChangeState(Name);
    }

    public override void ToSurname(User user)
    {
        user.ChangeState(Surname);
    }
}