using Domain.Entities;

namespace Domain.States;

public class SurnameState : UserState
{
    public override string Message => "Введите вашу фамилию";

    public override void ToProfile(User user)
    {
        base.ToProfile(user);
    }
}