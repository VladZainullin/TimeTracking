using Bot.Handlers;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;

var telegramBotClientOptions = new TelegramBotClientOptions("910988441:AAEkb8QeyZZgD6WBlT-UOfoCJBtkppS-z8Q");

var telegramBotClient = new TelegramBotClient(telegramBotClientOptions);

var receiverOptions = new ReceiverOptions
{
    AllowedUpdates =
    [
        UpdateType.Message
    ],
    DropPendingUpdates = true
};
var handler = new StartHandler();
await telegramBotClient.ReceiveAsync(handler, receiverOptions);