using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Interfaces;

namespace StaffCall
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public string AdminReceivedMessage { get; set; } = "Admins received your message.";

        public string AdminNotPresent { get; set; } = "No Admin present ingame";

    }
}
