using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;


using var cts = new CancellationTokenSource();
string token = "7506939631:AAETEyiZrwK00aMQD0FOtrJd5LUMgabaSsQ"; // Токен телеграм-бота
var bot = new TelegramBotClient(token, cancellationToken: cts.Token); // Создания бота
var me = await bot.GetMe(); // Получение информации о боте
bot.OnMessage += OnMessage; // Подписка на события сообщений

Console.WriteLine($"Характеристика бота\nИмя: {me.FirstName}\nUsername: {me.Username}");
Console.ReadLine();
cts.Cancel();

Task OnMessage(Message mess, UpdateType type) // Обработчик сообщений
{
    BotMethods.HandleUpdateAsync(token, mess);
    return Task.CompletedTask;
}