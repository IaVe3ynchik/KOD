using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;


using var cts = new CancellationTokenSource();
string token = "7506939631:AAETEyiZrwK00aMQD0FOtrJd5LUMgabaSsQ";
var bot = new TelegramBotClient(token, cancellationToken: cts.Token);
var me = await bot.GetMe();
bot.OnMessage += OnMessage;

Console.WriteLine($"Характеристика бота\nИмя: {me.FirstName}\nUsername: {me.Username}");
Console.ReadLine();
cts.Cancel();

Task OnMessage(Message mess, UpdateType type)
{
    BotMethods.HandleUpdateAsync(token, mess);
    return Task.CompletedTask;
}