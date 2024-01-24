using Microsoft.AspNetCore.SignalR;

namespace HDNXUdemyServices.CommonFunction
{
    public class OutputOrderHub : Hub
    {
        public OutputOrderHub()
        { }

        public async Task RegisterForOrderHub(string idUser)
        {
            await this.Groups.AddToGroupAsync(this.Context.ConnectionId, idUser);
        }
    }
}