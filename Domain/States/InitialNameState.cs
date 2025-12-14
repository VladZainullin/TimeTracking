using Domain.Entities;

namespace Domain.States;

public sealed class InitialNameState : ChatState
{
    public override string Message => "Введите ваше имя";

    public override void ToStart(Chat chat)
    {
        chat.ChangeState(Start);
    }

    public override void ToInitialSurname(Chat chat)
    {
        chat.ChangeState(InitialSurname);
    }
}