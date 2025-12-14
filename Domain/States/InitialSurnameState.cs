using Domain.Entities;

namespace Domain.States;

public sealed class InitialSurnameState : UserState
{
    public override string Message => "Введите вашу фамилию";

    public override void ToInitialName(User user)
    {
        user.ChangeState(InitialName);
    }
}