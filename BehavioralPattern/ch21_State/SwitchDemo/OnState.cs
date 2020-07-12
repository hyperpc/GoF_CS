using System.Diagnostics;
namespace ch21_State.SwitchDemo
{
    public class OnState : SwitchState
    {
        public override void On(Switch s)
        {
            System.Console.WriteLine("已经打开!");
        }
        public override void Off(Switch s)
        {
            System.Console.WriteLine("关闭!");
            s.SetState(Switch.GetState("off"));
        }
    }
}