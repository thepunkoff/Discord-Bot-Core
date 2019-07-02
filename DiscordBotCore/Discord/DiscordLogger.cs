using System.Threading.Tasks;
using System;
using Discord;

namespace DiscordBotCore.Discord
{
    public class DiscordLogger
    {
        ILogger _logger;

        public DiscordLogger(ILogger logger)
        {
            _logger = logger;
        }


        public Task Log(LogMessage logMsg)
        {
            _logger.Log(logMsg.Message);
            return Task.CompletedTask;
        }
    }
}