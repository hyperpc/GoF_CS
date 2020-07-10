namespace ch20_Observer.AllyTeam
{
    public interface IObserver_Ally
    {
        public string Name{get;set;}
        public void Help();
        public void BeAttacked(Subject_Ally acc);
    }
}