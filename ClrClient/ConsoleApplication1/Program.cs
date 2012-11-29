using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client.Hubs;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            BeginListening();

            Console.ReadLine();

        }

        private static void BeginListening()
        {

            var conn = new HubConnection("http://localhost:3538/");
            var hub = conn.CreateHubProxy("SendHub");

            hub.On<string>("DisplayMessage", s => Console.Out.WriteLine(s));

            conn.Start();

        }
    }
}
