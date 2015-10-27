using System.Threading.Tasks;
using XSockets.Core.XSocket;
using XSockets.Core.XSocket.Helpers;

namespace WebHost.Controllers
{
    public class DragController : XSocketController
    {
        public Task<bool> MoveStarted(MoveStartInfo info)
        {
            return this.PublishToAll(info, "MoveStarted");
        }

        public Task<bool> MoveCompleted(MoveDoneInfo info)
        {
            return this.PublishToAll(info, "MoveCompleted");
        }
    }
}
