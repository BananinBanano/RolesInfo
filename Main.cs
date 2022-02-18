using System;
using Exiled.API.Features;

namespace RolesInfo
{
    public class Main : Plugin<Config>
    {
        public static Main singleton;
        public override string Author { get; } = "BANANO";
        public override string Name { get; } = "RolesInfoCommand";
        public override string Prefix { get; } = "Roles Info";
        public override Version Version { get; } = new Version(0, 2, 0);
        public override Version RequiredExiledVersion { get; } = new Version(4, 2, 3);
        public override void OnEnabled()
        {
            singleton = this;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {

            singleton = null;

            base.OnDisabled();
        }
    }
}
