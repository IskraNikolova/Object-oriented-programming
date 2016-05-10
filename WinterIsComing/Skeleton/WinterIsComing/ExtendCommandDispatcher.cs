using WinterIsComing.Core;
using WinterIsComing.Core.Commands;

namespace WinterIsComing
{
    public class ExtendCommandDispatcher : CommandDispatcher
    {
        public override void SeedCommands()
        {
            this.commandsByName["toggle-effector"] = new ToggleEffectorCommand(this.Engine);
            base.SeedCommands();
        }
    }
}
