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
        if (update is { Type: UpdateType.Message, Message.Text: "/start" })
        {
            var chatId = update.Message.Chat.Id;
            await botClient.SendMessage(
                chatId,
                "Добро пожаловать! Необходимо заполнить некоторые данные:",
                replyMarkup: new InlineKeyboardMarkup([
                    [
                        InlineKeyboardButton.WithCallbackData("Заполнить данные", "/initialName"),
                    ]
                ]), cancellationToken: cancellationToken);
        }

        if (update is { Type: UpdateType.CallbackQuery, CallbackQuery.Message.Text: "/initialName" })
        {
            var chatId = update.CallbackQuery.Message.Chat.Id;
            await botClient.SendMessage(
                chatId,
                "Введите ваше имя", cancellationToken: cancellationToken);
        }
    }

    public Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, HandleErrorSource source,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}