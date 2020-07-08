namespace ch18_Mediator.CRM
{
    public abstract class Component
    {
        protected Mediator mediator;
        public void SetMediator(Mediator m){
            mediator=m;
        }
        public void Changed(){
            mediator.ComponentChanged(this);
        }
        public abstract void Update();
    }
}