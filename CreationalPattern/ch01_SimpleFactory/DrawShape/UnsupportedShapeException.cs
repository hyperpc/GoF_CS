using System;
namespace ch01_SimpleFactory.DrawShape
{
    public class UnsupportedShapeException : Exception
    {
        public UnsupportedShapeException(){
        }
        public UnsupportedShapeException(string message) : base(message){
        }
        public UnsupportedShapeException(string message, Exception inner) : base(message, inner){
        }
    }
}