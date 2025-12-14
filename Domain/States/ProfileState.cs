using Domain.Entities;

namespace Domain.States;

public sealed class ProfileState : ChatState
{
    public override string Message => "Выберите изменение";

    public override void ToStart(Chat chat)
    {
        chat.ChangeState(Start);
    }

    public override void ToName(Chat chat)
    {
        chat.ChangeState(Name);
    }

    public override void ToSurname(Chat chat)
    {
        chat.ChangeState(Surname);
    }
}