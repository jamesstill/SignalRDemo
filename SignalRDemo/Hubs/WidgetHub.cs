using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRDemo.Hubs
{
    [HubName("widgets")]
    public class WidgetHub : Hub { }
}