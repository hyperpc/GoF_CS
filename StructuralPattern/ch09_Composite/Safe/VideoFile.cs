namespace ch09_Composite.Safe
{
    public class VideoFile:AbstractFile
    {
        private string name;
        public VideoFile(string name){
            this.name = name;
        }

        public override void KillVirus(){
            System.Console.WriteLine("  >>Scanning Video File {0}", name);
        }
    }
}