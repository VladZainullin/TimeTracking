using Domain.Entities;

namespace Domain.States;

public sealed class StartState : ChatState
{
    public override string Message => "Здравствуйте! Заполните ваши данные";

    public override void ToInitialName(Chat chat)
    {
        chat.ChangeState(InitialName);
    }
}