﻿using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordBotCore.Discord.Entities
{
    class TutorialBotConfig
    {
        public string Token { get; set; }
        public DiscordSocketConfig SocketConfig { get; set; }
    }
}