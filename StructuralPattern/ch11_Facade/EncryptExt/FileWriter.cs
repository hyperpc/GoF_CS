using System.Text;
using System.IO;
namespace ch11_Facade.EncryptExt
{
    public class FileWriter
    {
        public void Write(string encrytStr, string filepath){
            System.Console.WriteLine("Save encrypted text.");
            try{
                using(var fs = new FileStream(filepath, FileMode.Create)){
                    byte[] bts = Encoding.Default.GetBytes(encrytStr);
                    fs.Write(bts, 0, bts.Length);
                    fs.Flush();
                    fs.Close();
                }
            }catch(FileNotFoundException ex){
                System.Console.WriteLine("File not exist!");
                System.Console.WriteLine(ex.Message);
            }catch(IOException ex){
                System.Console.WriteLine("File operation wrong!");
                System.Console.WriteLine(ex.Message);
            }
        }

    }
}