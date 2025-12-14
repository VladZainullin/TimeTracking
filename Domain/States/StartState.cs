using Domain.Entities;

namespace Domain.States;

public sealed class StartState : UserState
{
    public override string Message => "Здравствуйте! Заполните ваши данные";

    public override void ToInitialName(User user)
    {
        user.ChangeState(InitialName);
    }
}