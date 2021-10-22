using RST.Command;

namespace SBT.Test
{
    public class RotateCommand : ICommand
    {
        public void Execute(IUnit unit)
        {
            switch (unit)
            {
                case Chopper chopper:
                    chopper.Rotate();
                    break;
            }
        }
    }
}
