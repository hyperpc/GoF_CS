namespace ch04_Builder.Computer
{
    public abstract class ComputerBuilder
    {
        protected Computer computer = new Computer();
        
        public abstract void BuilderCPU();
        public abstract void BuilderMemory();
        public abstract void BuilderDisk();
        public abstract void BuilderHost();
        public abstract void BuilderDisplay();

        public virtual bool IsServer(){
            return false;
        }
        
        public Computer CreateComputer(){
            return computer;
        }
    }
}