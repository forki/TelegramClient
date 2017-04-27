namespace TelegramClient.Core
{
    using System;
    using System.Threading.Tasks;

    using Autofac;

    using TelegramClient.Entities;
    using TelegramClient.Entities.TL;

    public interface ITelegramClient
    {
        IComponentContext Container { get;}

        Task ConnectAsync(bool reconnect = false);

        Task<T> SendRequestAsync<T>(TlMethod methodToExecute);

        Task<TlAbsUpdates> SendMessageAsync(TlAbsInputPeer peer, string message);

        Task ReconnectToDcAsync(int dcId);

        Task SendPingAsync();
    }
}