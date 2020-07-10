namespace ch19_Memento.Chessman
{
    public class MementoOriginator
    {        
        internal string Label{get;set;}
        internal int X{get;set;}
        internal int Y{get;set;}
        internal MementoOriginator(string label, int x, int y){
            Label = label;
            X=x;
            Y=y;
        }
        internal MementoChessman Save(){
            return new MementoChessman(Label,X,Y);
        }
        internal void Restore(MementoChessman memento){
            Label=memento.Label;
            X=memento.X;
            Y=memento.Y;
        }

    }
}