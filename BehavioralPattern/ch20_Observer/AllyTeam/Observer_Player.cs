namespace ch20_Observer.AllyTeam
{
    public class Observer_Player : IObserver_Ally
    {
        private string playername{get;set;}
        public Observer_Player(string name){
            playername = name;
        }
        public string Name{
            get{return playername;}
            set{playername=value;}
        }
        public void Help(){
            System.Console.WriteLine($"Hold on, {this.playername} coming!");
        }
        public void BeAttacked(Subject_Ally acc){
            System.Console.WriteLine($"{this.playername} was attacked!");
            acc.Notify(playername);
        }
    }
}