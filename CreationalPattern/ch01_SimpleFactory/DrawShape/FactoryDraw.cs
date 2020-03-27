using System;
using System.Text;

namespace ch01_SimpleFactory.DrawShape
{
    public class FactoryDraw
    {
        public static IShape Draw(string type){
            IShape shape = null;
            try{
            switch(type){
                case "circle":
                shape = new Circle();
                break;
                case "rectangle":
                shape = new Rectangle();
                break;
                case "triangle":
                shape = new Triangle();
                break;
                default:
                var ExceptionMessage = new StringBuilder();
                if(string.IsNullOrWhiteSpace(type)){
                    ExceptionMessage.AppendLine("UnsupportedShapeException Message");
                }else {
                    ExceptionMessage.AppendFormat("UnsupportedShapeException Message: {0}", type);
                    ExceptionMessage.AppendLine();
                }
                throw new UnsupportedShapeException(ExceptionMessage.ToString());
            }
                shape.Draw();
            }catch(Exception ex){
                System.Console.WriteLine("Exception occur----->> " + ex.Message);
            }
            return shape;
        }
    }
}