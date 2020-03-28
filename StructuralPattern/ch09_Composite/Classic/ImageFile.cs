using System;
namespace ch09_Composite.Classic
{
    public class ImageFile : AbstractFile
    {
        private string name;
        public ImageFile(string name){
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
            System.Console.WriteLine("  >>Scanning Image File {0}", name);
        }
    }
}