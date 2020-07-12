namespace ch21_State.SwitchDemo
{
    public class OffState : SwitchState
    {        
        public override void On(Switch s)
        {
            System.Console.WriteLine("打开!");
            s.SetState(Switch.GetState("on"));
        }
        public override void Off(Switch s)
        {
            System.Console.WriteLine("已经关闭!");
        }
    }
}