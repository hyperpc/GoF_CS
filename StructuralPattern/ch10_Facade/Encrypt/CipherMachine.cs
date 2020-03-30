using System.Text;
namespace ch10_Facade.Encrypt
{
    public class CipherMachine
    {
        public string Encrypt(string plainText){
            System.Console.WriteLine("Data encryption. transp plain text into encryted: ");
            char[] chars = plainText.ToCharArray();
            var es = new StringBuilder();
            foreach(char ch in chars){
                var c = (ch%7).ToString();
                es.Append(c);
            }
            System.Console.WriteLine(es);
            return es.ToString();
        }
    }
}