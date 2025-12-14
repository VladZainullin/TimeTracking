using Domain.Entities;

namespace Domain.States;

public sealed class NameState : ChatState
{
    public override string Message => "Введите ваше имя";

    public override void ToStart(Chat chat)
    {
        chat.ChangeState(Profile);
    }
}