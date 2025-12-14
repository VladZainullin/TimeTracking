using Domain.Entities;

namespace Domain.States;

public sealed class InitialSurnameState : ChatState
{
    public override string Message => "Введите вашу фамилию";

    public override void ToInitialName(Chat chat)
    {
        chat.ChangeState(InitialName);
    }
}