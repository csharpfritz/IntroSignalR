﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR.Hubs;

namespace MoveShape_Backup
{

    [HubName("moveShape")]
    public class MoveShapeHub : Hub
    {

        public void MoveShape(int x, int y)
        {
            Clients.All.shapeMoved(Context.ConnectionId, x, y);
        }

    }
}