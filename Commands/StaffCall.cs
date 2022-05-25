using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteAdmin;
using CommandSystem;
using Exiled.API.Features;

namespace StaffCall
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class StaffCall : ICommand
    {
        public string Command { get; } = "call";
        public string[] Aliases { get; } = new string[] { };
        public string Description { get; } = "Send messages to admin";
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = Player.Get(sender);
            bool adminPresent = false;
            foreach (Player ply in Player.List)
            {
                if (ply.RemoteAdminAccess)
                {
                    ply.Broadcast(5, $"{player.Nickname} asking help:{string.Join(" ", arguments)}", Broadcast.BroadcastFlags.Normal);
                }
                adminPresent = true;
            }
            response = adminPresent ? "Admins received your message.": "No Admin present ingame";
            return true;
        }
    }
}
