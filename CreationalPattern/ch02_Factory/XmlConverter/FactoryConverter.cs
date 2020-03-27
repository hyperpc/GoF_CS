using System.Runtime.CompilerServices;
namespace ch02_Factory.XmlConverter
{
    public abstract class FactoryConverter
    {
        public abstract IData InitConverter();

         public void Convert(){
             var converter = this.InitConverter();
             converter.Convert();
         }
    }
}