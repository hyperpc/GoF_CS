using System.Collections.Generic;
namespace ch09_Composite.Classic
{
    public class Folder : AbstractFile
    {
        private string name;
        private List<AbstractFile> fileList = null;
        public Folder(string name){
            this.name = name;
            fileList = new List<AbstractFile>();
        }

        public override void Add(AbstractFile file){
            fileList.Add(file);
        }
        public override void Remove(AbstractFile file){
            fileList.Remove(file);
        }
        public override AbstractFile GetChild(int i){
            return (AbstractFile)fileList[i];
        }
        public override void KillVirus(){
            System.Console.WriteLine("  >>Scanning Folder {0}", name);
            foreach(var file in fileList){
                ((AbstractFile)file).KillVirus();
            }
        }
    }
}