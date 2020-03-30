using System.Text;
using System.IO;
namespace ch11_Facade.EncryptExt
{
    public class FileReader
    {
        public string Read(string filepath){
            System.Console.WriteLine("Read plain text");
            var sb = new StringBuilder();
            try{
            using(var fs = new FileStream(filepath, FileMode.Open)){
                int data;
                while((data=fs.ReadByte())!=-1){
                    sb.Append((char)data);
                }
                fs.Close();
                System.Console.WriteLine(sb.ToString());
            }
            }catch(FileNotFoundException ex){
                System.Console.WriteLine("File not exist!");
                System.Console.WriteLine(ex.Message);
            }catch(IOException ex){
                System.Console.WriteLine("File operation wrong!");
                System.Console.WriteLine(ex.Message);
            }
            return sb.ToString();
        }
    }
}