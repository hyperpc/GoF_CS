namespace ch20_Observer.AllyTeam
{
    public class Subject_AllyCtrlCenter : Subject_Ally
    {
        public Subject_AllyCtrlCenter(string name){
            System.Console.WriteLine($"{name} ally setup!");
            System.Console.WriteLine("----------------------");
            allyName = name;
        }
        public override void Notify(string name){
            System.Console.WriteLine($"{allyName} ally urgent notice, ally team member {name} was attacked!");
            foreach(var obs in players){
                if(!((IObserver_Ally)obs).Name.Equals(name)){
                    ((IObserver_Ally)obs).Help();
                }
            }
        }
    }
}