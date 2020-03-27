namespace ch04_Builder.Computer
{
    public class ComputerController
    {
        public Computer Construct(ComputerBuilder builder){
            builder.BuilderCPU();
            builder.BuilderMemory();
            builder.BuilderDisk();
            builder.BuilderHost();
            builder.BuilderDisplay();
            return builder.CreateComputer();
        }
    }
}