using Bot.Handlers;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;

namespace Bot;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var telegramBotClient = new TelegramBotClient("910988441:AAEkb8QeyZZgD6WBlT-UOfoCJBtkppS-z8Q");

        var receiverOptions = new ReceiverOptions
        {
            AllowedUpdates =
            [
                UpdateType.Message,
                UpdateType.CallbackQuery
            ],
            DropPendingUpdates = true
        };
        var handler = new StartHandler();
        await telegramBotClient.ReceiveAsync(handler, receiverOptions);
    }
}