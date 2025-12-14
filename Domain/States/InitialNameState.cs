using Domain.Entities;

namespace Domain.States;

public sealed class InitialNameState : UserState
{
    public override string Message => "Введите ваше имя";

    public override void ToStart(User user)
    {
        user.ChangeState(Start);
    }

    public override void ToInitialSurname(User user)
    {
        user.ChangeState(InitialSurname);
    }
}