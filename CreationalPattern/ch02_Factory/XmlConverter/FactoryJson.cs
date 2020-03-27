namespace ch02_Factory.XmlConverter
{
    public class FactoryJson : FactoryConverter
    {
        public override IData InitConverter(){
            return new JsonData();
        }
    }
}