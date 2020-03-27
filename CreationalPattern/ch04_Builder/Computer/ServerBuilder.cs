namespace ch04_Builder.Computer
{
    public class ServerBuilder : ComputerBuilder
    {
        public override void BuilderCPU(){
            computer.CPU = "Intel";
        }
        public override void BuilderMemory(){
            computer.Memory = "Kingston";
        }
        public override void BuilderDisk(){
            computer.Disk = "Seagate";
        }
        public override void BuilderHost(){
            computer.Host = "Dell";
        }
        public override void BuilderDisplay(){
            if(!IsServer()){
            computer.CPU = "LG";
            }
        }

        public override bool IsServer(){
            return true;
        }
    }
}