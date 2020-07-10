namespace ch19_Memento.Chessman
{
    public class MementoChessman
    {
        //private string label;
        //private int x;
        //private int y;

        internal string Label{get;set;}
        internal int X{get;set;}
        internal int Y{get;set;}
        internal MementoChessman(string label, int x, int y){
            Label = label;
            X=x;
            Y=y;
        }
    }
}