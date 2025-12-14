using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Bot.Handlers;

public sealed class StartHandler : IUpdateHandler
{
    public async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        if (update.Type != UpdateType.Message) return;

        if (update.Message is null) return;
        if (update.Message.Text != "/start") return;
        
        
        var chatId = update.Message.Chat.Id;
        await botClient.SendMessage(
            chatId,
            "Добро пожаловать! Выберите действие:",
            replyMarkup: new InlineKeyboardMarkup([
                [
                    InlineKeyboardButton.WithCallbackData("📄 Профиль", "profile"),
                    InlineKeyboardButton.WithCallbackData("⚙️ Настройки", "settings")
                ]
            ]), cancellationToken: cancellationToken);
    }

    public Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, HandleErrorSource source,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}