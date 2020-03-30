namespace ch11_Facade.Encrypt
{
    public class EncryptFacade
    {
        private FileReader reader;
        private FileWriter writer;
        private CipherMachine cipher;
        public EncryptFacade(){
            reader = new FileReader();
            writer = new FileWriter();
            cipher = new CipherMachine();
        }
        public void FileEncrypt(string srcfilepath, string desfilepath){
            var plain = reader.Read(srcfilepath);
            var encrypt = cipher.Encrypt(plain);
            writer.Write(encrypt, desfilepath);
        }
    }
}