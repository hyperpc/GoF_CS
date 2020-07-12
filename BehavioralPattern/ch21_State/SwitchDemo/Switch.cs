namespace ch21_State.SwitchDemo
{
    public class Switch
    {
        private static SwitchState currentSate, onSate, offState;
        private string name;
        public Switch(string name){
            this.name = name;
            onSate = new OnState();
            offState=new OffState();
            currentSate=onSate;
        }
        public void SetState(SwitchState state){
            currentSate = state;
        }
        public static SwitchState GetState(string type){
            if(type.Equals("on")){
                return onSate;
            }else{
                return offState;
            }
        }
        public void On(){
            System.Console.WriteLine(name);
            currentSate.On(this);
        }
        public void Off(){
            System.Console.WriteLine(name);
            currentSate.Off(this);
        }
    }
}