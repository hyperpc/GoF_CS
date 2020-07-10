
using System.Collections.Generic;
namespace ch20_Observer.AllyTeam
{
    public abstract class Subject_Ally
    {
        protected string allyName;
        protected List<IObserver_Ally> players = new List<IObserver_Ally>();
        public void SetAllyName(string name){
            allyName = name;
        }
        public string GetAllyName(){
            return allyName;
        }
        public void Join(IObserver_Ally obs){
            System.Console.WriteLine($"{obs.Name} join {allyName} ally!");
            players.Add(obs);
        }
        public void Quit(IObserver_Ally obs){
            System.Console.WriteLine($"{obs.Name} quit {allyName} ally!");
            players.Remove(obs);
        }
        public abstract void Notify(string name);
    }
}