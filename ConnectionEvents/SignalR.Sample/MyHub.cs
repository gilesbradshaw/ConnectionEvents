using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SignalR.Hubs;

namespace SignalR
{
    [HubName("myHub")]
    public class MyHub : Hub, IDisconnect, IConnected
    {
        
        
        public string GetString()
        {
            System.Diagnostics.Debug.WriteLine(Context.ConnectionId);
            return "hello";
        }

        private static int y = 0;
        private static int x = 0;
        public System.Threading.Tasks.Task Disconnect()
        {
            x = x - 1;
            System.Diagnostics.Debug.WriteLine("disconnecting: " + x.ToString() + "  : " + y++.ToString());
            return new Task(() => { });

        }

        public System.Threading.Tasks.Task Connect()
        {
            x = x + 1;
            System.Diagnostics.Debug.WriteLine("connecting: " + x.ToString());
            return new Task(() => { });
        }

        public System.Threading.Tasks.Task Reconnect(IEnumerable<string> groups)
        {
            return new Task(() => { });
        }
    }
}