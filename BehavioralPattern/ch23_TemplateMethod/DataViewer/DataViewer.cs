namespace ch23_TemplateMethod.DataViewer
{
    public abstract class DataViewer
    {
        public abstract void GetData();
        public void ConvertData(){
            System.Console.WriteLine("将数据转换为XML格式！");
        }
        public abstract void DisplayData();
        public virtual bool IsNotXMLData(){
            return true;
        }
        public void Process(){
            GetData();
            if(IsNotXMLData()){
                ConvertData();
            }
            DisplayData();
        }
    }
}