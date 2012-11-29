using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR.Hubs;

namespace WebApplication1
{
    public class SendHub : Hub
    {

        public void SendMessage(string msg)
        {

            Clients.AllExcept(Context.ConnectionId).DisplayMessage(msg);

        }

    }
}