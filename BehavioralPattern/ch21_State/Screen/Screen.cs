namespace ch21_State.Screen
{
    public class Screen
    {
        private ScreenState currentState, normalState, largerState, largestState;
        public Screen(){
            this.normalState = new NormalState();
            this.largerState=new LargerState();
            this.largestState=new LargestState();
            this.currentState=normalState;
            this.currentState.Display();
        }
        public void SetState(ScreenState state){
            this.currentState=state;
        }
        public void OnClick(){
            if(this.currentState==normalState){
                this.SetState(largerState);
                this.currentState.Display();
            } else if(this.currentState==largerState){
                this.SetState(largestState);
                this.currentState.Display();
            } else if(this.currentState ==largestState){
                this.SetState(normalState);
                this.currentState.Display();
            }
        }
    }
}