namespace ch09_Composite.Classic
{
    public class VideoFile:AbstractFile
    {
        private string name;
        public VideoFile(string name){
            this.name = name;
        }

        public override void Add(AbstractFile file){
            System.Console.WriteLine("Not Supported!");
        }
        public override void Remove(AbstractFile file){
            System.Console.WriteLine("Not Supported!");
        }
        public override AbstractFile GetChild(int i){
            System.Console.WriteLine("Not Supported!");
            return null;
        }
        public override void KillVirus(){
            System.Console.WriteLine("  >>Scanning Video File {0}", name);
        }
    }
}