namespace ch21_State.SwitchDemo
{
        public abstract class SwitchState{
            public abstract void On(Switch s);
            public abstract void Off(Switch s);
        }
}