namespace ch23_TemplateMethod.DataViewer
{
    public class JsonDataViewer : DataViewer
    {
        public override void GetData(){
            System.Console.WriteLine("从JSON文件中获取数据！");
        }
        public override void DisplayData(){
            System.Console.WriteLine("以柱状图显示数据！");
        }
        public override bool IsNotXMLData(){
            return true;
        }
    }
}