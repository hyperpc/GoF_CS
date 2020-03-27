namespace ch04_Builder.Computer
{
    public class PCBuilder : ComputerBuilder
    {
        public override void BuilderCPU(){
            computer.CPU = "AMD";
        }
        public override void BuilderMemory(){
            computer.Memory = "Kingston";
        }
        public override void BuilderDisk(){
            computer.Disk = "WD";
        }
        public override void BuilderHost(){
            computer.Host = "Lenovo";
        }
        public override void BuilderDisplay(){
            if(!IsServer()){
            computer.Display = "AOC";
            }
        }
    }
}