using RST.Command;

namespace SBT.Test
{
    public class MoveCommandDecorator : ICommand
    {
        protected ICommand _command;

        public MoveCommandDecorator(ICommand component)
        {
            _command = component;
        }

        public void Execute(IUnit unit)
        {
            if (_command != null)
            {
                switch (unit)
                {
                    case Chopper chopper:
                        chopper.Move();
                        break;
                    default:
                        _command.Execute(unit);
                        break;
                }
            }
        }
    }
}
