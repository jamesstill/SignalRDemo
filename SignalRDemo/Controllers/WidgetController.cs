using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using SignalRDemo.Hubs;
using SignalRDemo.Models;

namespace SignalRDemo.Controllers
{
    public class WidgetController : SignalRBase<WidgetHub>
    {
        // POST api/<controller>
        public HttpResponseMessage Post(Widget item)
        {
            if (item == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            // add to database in a real app

            // notify all connected clients
            Hub.Clients.All.newWidget(item);

            // return the item inside of a 201 response
            return Request.CreateResponse(HttpStatusCode.Created, item);
        }
    }
}