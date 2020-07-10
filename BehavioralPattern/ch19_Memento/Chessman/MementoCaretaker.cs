using System.Collections;
namespace ch19_Memento.Chessman
{
    public class MementoCaretaker
    {
        private MementoChessman _memento;
        internal MementoChessman GetMemento(){
            return _memento;
        }
        internal void SetMemento(MementoChessman memento){
            _memento = memento;
        }

        private ArrayList mementoList = new ArrayList();
        internal MementoChessman GetMementoByIndex(int i){
            return (MementoChessman)mementoList[i];
        }
        internal void SetMementoToList(MementoChessman memento){
            mementoList.Add(memento);
        }
    }
}