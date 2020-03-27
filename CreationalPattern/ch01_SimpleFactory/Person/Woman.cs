namespace ch01_SimpleFactory.Person
{
    public class Woman : IPerson
    {        
        public void Talk(){
            System.Console.WriteLine("I'm a woman");
        }
    }
}