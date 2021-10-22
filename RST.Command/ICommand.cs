namespace RST.Command
{
    public interface ICommand 
    {
        void Execute(IUnit unit);
    }

    public class MoveCommand : ICommand
    {
        public void Execute(IUnit unit)
        {
            switch (unit)
            {
                case Car car:
                    car.Move();
                    break;      
                    
                case Tank tank:
                    tank.Move();
                    break;
            }
        }
    }

    public class FireCommand : ICommand
    {
        public void Execute(IUnit unit)
        {
            switch (unit)
            {
                case Tank tank:
                    tank.Fire();
                    break;
            }
        }
    }
}