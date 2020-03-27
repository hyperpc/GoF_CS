namespace ch01_SimpleFactory.Person
{
    public class Nvwa
    {
        public static IPerson Generate(string type){
            IPerson person = null;
            switch(type){
                case "M":
                person = new Man();
                break;
                case "W":
                person = new Woman();
                break;
                case "R":
                default:
                person = new Robot();
                break;
            }
            return person;
        }
    }
}