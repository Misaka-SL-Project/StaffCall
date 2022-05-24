using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;

namespace StaffCall
{
    public class Plugin : Plugin<Config>
    {
    public override string Author { get; } = "Killla";
	public override string Name { get; } = "Staff Call";
	public override string Prefix { get; } = "SC";
	public override Version Version { get; } = new Version(1, 0, 0);
	public override Version RequiredExiledVersion { get; } = new Version(5, 0, 0);

        public override void OnEnabled()
        {
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            base.OnDisabled();
        }
    }
}
