using Domain.Entities;

namespace Domain.States;

public class SurnameState : ChatState
{
    public override string Message => "Введите вашу фамилию";

    public override void ToProfile(Chat chat)
    {
        base.ToProfile(chat);
    }
}