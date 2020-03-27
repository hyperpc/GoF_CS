namespace ch04_Builder.Computer
{
    public class LaptopBuilder : ComputerBuilder
    {
        public override void BuilderCPU(){
            computer.CPU = "Intel";
        }
        public override void BuilderMemory(){
            computer.Memory = "SanDisk";
        }
        public override void BuilderDisk(){
            computer.Disk = "Seagate";
        }
        public override void BuilderHost(){
            computer.Host = "hp";
        }
        public override void BuilderDisplay(){
            if(!IsServer()){
            computer.CPU = "LG";
            }
        }
    }
}