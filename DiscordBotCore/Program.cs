using DiscordBotCore.Discord;
using DiscordBotCore.Discord.Entities;
using System;

namespace DiscordBotCore
{
    internal class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord");

            var discordBotConfig = new TutorialBotConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };

            var connection = Unity.Resolve<Connection>();

            Console.ReadKey();
        }
    }
}
