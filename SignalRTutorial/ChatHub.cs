using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRTutorial
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string username)
        {
            await this.Clients.All.InvokeAsync("Send", message, username);
        }
    }
}
