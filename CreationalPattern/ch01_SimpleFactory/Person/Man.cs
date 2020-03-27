namespace ch01_SimpleFactory.Person
{
    public class Man : IPerson
    {
        public void Talk(){
            System.Console.WriteLine("I'm a man");
        }
    }
}