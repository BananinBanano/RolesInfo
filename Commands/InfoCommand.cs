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
            if (p.Role == RoleType.ClassD)
            {
                response = "Class-D personnel have to escape the facility without being watched by Guards or MTF's. You can cooperate with Chaos Insurgency.";
                return true;
            }
            if (p.Role == RoleType.Scientist)
            {
                response = "Scientist personnel must cooperate with Guards and MTF's to escape the facility.";
                return true;
            }
            if (p.Role == RoleType.NtfCaptain)
            {
                response = "MTF's must help scientist to escape and arrest Class-D personnel.";
                return true;
            }
            if (p.Role == RoleType.NtfPrivate)
            {
                response = "MTF's must help scientist to escape and arrest Class-D personnel.";
                return true;
            }
            if (p.Role == RoleType.NtfSergeant)
            {
                response = "MTF's must help scientist to escape and arrest Class-D personnel.";
                return true;
            }
            if (p.Role == RoleType.NtfSpecialist)
            {
                response = "MTF's must help scientist to escape and arrest Class-D personnel.";
                return true;
            }
            if (p.Role == RoleType.ChaosConscript)
            {
                response = "Chaos Isurgency must help Class-D to escape, arrest Scientist personnel and kill MTF's.";
                return true;
            }
            if (p.Role == RoleType.ChaosMarauder)
            {
                response = "Chaos Isurgency must help Class-D to escape, arrest Scientist personnel and kill MTF's.";
                return true;
            }
            if (p.Role == RoleType.ChaosRepressor)
            {
                response = "Chaos Isurgency must help Class-D to escape, arrest Scientist personnel and kill MTF's.";
                return true;
            }
            if (p.Role == RoleType.ChaosRifleman)
            {
                response = "Chaos Isurgency must help Class-D to escape, arrest Scientist personnel and kill MTF's.";
                return true;
            }
            if (p.Role == RoleType.FacilityGuard)
            {
                response = "Facility Guard have to help Scientist to help and arrest Class-D personnel.";
                return true;
            }
            if (p.Role == RoleType.Scp0492)
            {
                response = "You are a SCP-049-2 you have to help others SCP's.";
                return true;
            }
            if (p.Role == RoleType.Scp173)
            {
                response = "You are the SCP-173 you have to kill everyone but be careful, if someone look at you, you will not be able to move.";
                return true;
            }
            if (p.Role == RoleType.Scp049)
            {
                response = "When you kill someone, you can revive him pressing 'E' in his corpse.";
                return true;
            }
            if (p.Role == RoleType.Scp106)
            {
                response = "You can teleport by pressing 'Create portal' in the TAB menu, then press 'Teleport to portal'.";
                return true;
            }
            if (p.Role == RoleType.Scp096)
            {
                response = "Your goal is to someone look your face, if they do that, you rage, then, you can kill them.";
                return true;
            }
            if (p.Role == RoleType.Scp079)
            {
                response = "You have to help your teamates opening/blocking them doors.";
                return true;
            }
            if (p.Role == RoleType.Scp93989)
            {
                response = "You can't see anything, you just can see people if they make sounds. They can hear you if you run (SHIFT key) but you're so silent when you dont press it.";
                return true;
            }
            if (p.Role == RoleType.Scp93953)
            {
                response = "You can't see anything, you just can see people if they make sounds. They can hear you if you run (SHIFT key) but you're so silent when you dont press it.";
                return true;
            }
            response = "NULL";
            return false;
        }
    }
}
