using DiscordBotCore.Storage;
using DiscordBotCore.Storage.Implementations;
using System;

namespace DiscordBotCore
{
    internal class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();

            var a = Unity.Resolve<MyProfile>();
            var b = Unity.Resolve<MyProfile>();


            Console.WriteLine("Hello, Discord");
        }
    }

    public class MyProfile
    {

        private readonly IDataStorage _storage;

        public MyProfile(IDataStorage storage)
        {
            _storage = storage;
        }

        public void NewUser(string name)
        {
            var regTime = DateTime.UtcNow;
            _storage.StoreObject(regTime, name);
        }
    }
}
