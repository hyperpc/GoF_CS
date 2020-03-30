using System;
using System.Text;

namespace ch11_Facade.EncryptExt
{
    public class NewCipherMachine
    {
        public string Encrypt(string plainText){
            System.Console.WriteLine("Data encryption. transp plain text into encryted: ");
            char[] chars = plainText.ToCharArray();
            var es = new StringBuilder();
            int key =10;// set key, move 10 bit
            foreach (var ch in chars)
            {
                int temp = Convert.ToInt32(ch);
                if(ch>='a'&&ch<='z'){
                    temp +=key%26;
                    if(temp>122){
                        temp-=26;
                    }
                    if(temp<97){
                        temp+=26;
                    }
                }
                if(ch>='A' && ch<='Z'){
                    temp +=key%26;
                    if(temp>90){
                        temp-=26;
                    }
                    if(temp<65){
                        temp+=26;
                    }
                }
                es.Append(((char)temp).ToString());
            }

            System.Console.WriteLine(es);
            return es.ToString();
        }
    }
}