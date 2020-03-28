namespace ch09_Composite.Safe
{
    public class TextFile:AbstractFile
    {
        private string name;
        public TextFile(string name){
            this.name = name;
        }

        public override void KillVirus(){
            System.Console.WriteLine("  >>Scanning Text File {0}", name);
        }
    }
}