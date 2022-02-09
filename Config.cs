using Exiled.API.Interfaces;
using System.ComponentModel;

namespace RolesInfo
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;
    }
}
