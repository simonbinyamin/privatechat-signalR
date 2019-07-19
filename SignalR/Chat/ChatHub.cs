using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Chat
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        /// <summary>
        /// Template on how to create a private chat
        /// </summary>
        public async void PrivateChat(string message)
        {
            var t1 = new
            {
                fName="",
                sName="",
                responseConnId = ""
            };

            List<string> connIds = new List<string>();
            connIds.Add(Context.ConnectionId);
            connIds.Add(t1.responseConnId);

            await Clients.Clients(connIds).SendAsync("ReceiveMessage", t1, message);

        }
    }
}
