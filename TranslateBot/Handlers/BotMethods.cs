using System.Text.RegularExpressions;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using GTranslatorAPI;

public class BotMethods
{
    public static Dictionary<string, string> dictRusAndEng = new Dictionary<string, string> // Словарь для перевода с русского на английский
    {
        {"привет", "hello"},
        {"мир", "world"},
        {"работа", "work"}
    }; 
    
    public static Dictionary<string, string> dictRusAndEngAndFrench = new Dictionary<string, string> // Словарь для перевода с русского на английский и французский
    {
        {"привет", "hello; salut"},
        {"мир", "world; monde"},
        {"работа", "work; travail"}
    }; 
    
    public static async void HandleUpdateAsync(string token, Message mess) // Обработка сообщений
    {
        try
        {
            await HandlePollingErrorAsync(mess, token); // Обработка возможных ошибок
            string text = mess.Text;
            var bot = new TelegramBotClient(token);
            if (text == "/start") // Обработка команды /start
            {
                await bot.SendMessage(mess.Chat,
                    $"Привет, {mess.From.Username}! Этот бот позволяет переводить сообщения");
            }

            else
            {
                // if (dictRusAndEng.Keys.Contains(text)) // Перевод слова с русского на английский с помощью словаря dictRusAndEng
                // {
                //     await bot.SendMessage(
                //         chatId: mess.Chat,
                //         text: $"Перевод на английском: _{dictRusAndEng[text]}_", 
                //         parseMode: ParseMode.MarkdownV2);
                // }

                // else
                // {
                //     await bot.SendMessage(mess.Chat, "Я не понял");
                // }

                // if (dictRusAndEngAndFrench.Keys.Contains(text)) // Перевод слова с русского на английский и французский с помощью словаря dictRusAndEngAndFrench
                // {
                //     string[] dictSplitted = dictRusAndEngAndFrench[text].Split("; ");
                //     await bot.SendMessage(
                //         chatId: mess.Chat,
                //         text: $"Перевод на английском: _{dictSplitted[0]}_, перевод на французском: _{dictSplitted[1]}_", 
                //         parseMode: ParseMode.MarkdownV2);
                // }

                // else
                // {
                //     await bot.SendMessage(mess.Chat, "Я не понял");
                // }

                var translator = new GTranslatorAPIClient(); // Перевод слова с помощью nuget-пакета GTranslatorAPI
                Translation translEn = await translator.TranslateAsync("ru", "en", text);
                Translation translFr = await translator.TranslateAsync("ru", "fr", text);

                string textEn = translEn.TranslatedText;
                string textFr = translFr.TranslatedText;
                await bot.SendMessage(mess.Chat,
                    $"Перевод на английском: _{textEn}_, перевод на французском: _{textFr}_", ParseMode.MarkdownV2);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }


    public static async Task HandlePollingErrorAsync(Message mess, string token) // Обработка возможных ошибок
    {
        string text = mess.Text;
        var bot = new TelegramBotClient(token);
        
        if(string.IsNullOrEmpty(text)) // Если сообщение с пустым текстом
        {
            await bot.SendMessage(mess.Chat, "Сообщение не может быть пустым.");
            throw new Exception("Сообщение не может быть пустым.");
        }

        if (Regex.IsMatch(text, @"\P{IsCyrillic}")&& text != "/start") // Если сообщение написано не кириллицой и оно не команда /start
        {
            await bot.SendMessage(mess.Chat, "Слова могут содержать только буквы кириллицы.");
            throw new Exception("Слова могут содержать только буквы кириллицы.");
        }
    }
}