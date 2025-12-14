using Domain.Entities;

namespace Domain.States;

public sealed class NameState : UserState
{
    public override string Message => "Введите ваше имя";

    public override void ToStart(User user)
    {
        user.ChangeState(Profile);
    }
}