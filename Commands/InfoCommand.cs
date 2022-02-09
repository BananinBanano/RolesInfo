using System;
using CommandSystem;
using Exiled.API.Features;

namespace RolesInfo.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class InfoCommand : ICommand
    {
        public string Command { get; } = "Info";
        public string Description { get; } = null;
        public string[] Aliases { get; } = { "i" };

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player p = Player.Get((CommandSender)sender);
            switch (p.Role)
            {
                case RoleType.None:
                    response = "NULL";
                    return false;
                case RoleType.Scp173:
                    response = "You are the SCP-173 you have to kill everyone but be careful, if someone look at you, you will not be able to move.";
                    return true;
                case RoleType.ClassD:
                    response = "Class-D personnel have to escape the facility without being watched by Guards or MTF's. You can cooperate with Chaos Insurgency.";
                    return true;
                case RoleType.Spectator:
                    response = "You are dead wait for a respawn.";
                    return true;
                case RoleType.Scp106:
                    response = "You can teleport by pressing 'Create portal' in the TAB menu, then press 'Teleport to portal'.";
                    return true;
                case RoleType.NtfSpecialist:
                    response = "MTF's must help scientist to escape and arrest Class-D personnel.";
                    return true;
                case RoleType.Scp049:
                    response = "When you kill someone, you can revive him pressing 'E' in his corpse.";
                    return true;
                case RoleType.Scientist:
                    response = "Scientist personnel must cooperate with Guards and MTF's to escape the facility.";
                    return true;
                case RoleType.Scp079:
                    response = "You have to help your teamates opening/blocking them doors.";
                    return true;
                case RoleType.ChaosConscript:
                    response = "Chaos Isurgency must help Class-D to escape, arrest Scientist personnel and kill MTF's.";
                    return true;
                case RoleType.Scp096:
                    response = "Your goal is to someone look your face, if they do that, you rage, then, you can kill them.";
                    return true;
                case RoleType.Scp0492:
                    response = "You are a SCP-049-2 you have to help others SCP's.";
                    return true;
                case RoleType.NtfSergeant:
                    response = "MTF's must help scientist to escape and arrest Class-D personnel.";
                    return true;
                case RoleType.NtfCaptain:
                    response = "MTF's must help scientist to escape and arrest Class-D personnel.";
                    return true;
                case RoleType.NtfPrivate:
                    response = "MTF's must help scientist to escape and arrest Class-D personnel.";
                    return true;
                case RoleType.Tutorial:
                    response = "NULL";
                    return false;
                case RoleType.FacilityGuard:
                    response = "Facility Guard have to help Scientist to help and arrest Class-D personnel.";
                    return true;
                case RoleType.Scp93953:
                    response = "You can't see anything, you just can see people if they make sounds. They can hear you if you run (SHIFT key) but you're so silent when you dont press it.";
                    return true;
                case RoleType.Scp93989:
                    response = "You can't see anything, you just can see people if they make sounds. They can hear you if you run (SHIFT key) but you're so silent when you dont press it.";
                    return true;
                case RoleType.ChaosRifleman:
                    response = "Chaos Isurgency must help Class-D to escape, arrest Scientist personnel and kill MTF's.";
                    return true;
                case RoleType.ChaosRepressor:
                    response = "Chaos Isurgency must help Class-D to escape, arrest Scientist personnel and kill MTF's.";
                    return true;
                case RoleType.ChaosMarauder:
                    response = "Chaos Isurgency must help Class-D to escape, arrest Scientist personnel and kill MTF's.";
                    return true;
                default:
                    response = "NULL";
                    return false;
            }
        }
    }
}
