namespace ch10_Facade.EncryptExt
{
    public class NewEncryptFacade : AbstractEncryptFacade
    {
        private FileReader reader;
        private FileWriter writer;
        private NewCipherMachine cipher;
        public NewEncryptFacade(){
            reader = new FileReader();
            writer = new FileWriter();
            cipher = new NewCipherMachine();
        }
        public override void FileEncrypt(string srcfilepath, string desfilepath){
            var plain = reader.Read(srcfilepath);
            var encrypt = cipher.Encrypt(plain);
            writer.Write(encrypt, desfilepath);
        }
    }
}