namespace ch01_SimpleFactory.Person
{
    public class Robot : IPerson
    {
        public void Talk(){
            System.Console.WriteLine("I'm a robot");
        }
    }
}