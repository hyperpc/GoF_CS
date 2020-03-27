namespace ch02_Factory.XmlConverter
{
    public class FactoryTxt : FactoryConverter
    {
        public override IData InitConverter(){
            return new TxtData();
        }
    }
}