using System;
namespace ch09_Composite.Safe
{
    public class ImageFile : AbstractFile
    {
        private string name;
        public ImageFile(string name){
            this.name = name;
        }

        public override void KillVirus(){
            System.Console.WriteLine("  >>Scanning Image File {0}", name);
        }
    }
}