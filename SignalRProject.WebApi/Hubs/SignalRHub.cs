
using Microsoft.AspNetCore.SignalR;
using SignalRProject.DataAccessLayer.Concrete;

namespace SignalRProject.WebApi.Hubs
{
    public class SignalRHub : Hub
    {
        Context context = new Context();

        public async Task SendCategoryCount()
        {
            var value = context.categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount",value);
        }
    }
}
