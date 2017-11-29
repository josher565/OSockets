using System;
using Owin;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;

namespace OSockets.Hub {
    public class OSocketsHub : Microsoft.AspNet.SignalR.Hub
    {
        public void Send(string name, string message){
            Clients.All.addMessage(name, message);
        }
    }
}