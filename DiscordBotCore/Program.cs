using System.Threading.Tasks;
using System.Data;
using DiscordBotCore.Storage;
using DiscordBotCore.Discord;
using DiscordBotCore.Discord.Entities;
using System;

namespace DiscordBotCore
{
    internal class Program
    {
        private static async Task Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord");

            var storage = Unity.Resolve<IDataStorage>();
            
            var connection = Unity.Resolve<Connection>();

            await connection.ConnectAsync(new TutorialBotConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken")
            });

            Console.ReadKey();
        }
    }
}
