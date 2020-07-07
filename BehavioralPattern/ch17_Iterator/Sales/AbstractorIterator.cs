namespace ch17_Iterator.Sales
{
    public interface AbstractorIterator
    {
        void Next();
        bool IsLast();
        void Previous();
        bool IsFirst();
        object GetNextItem();
        object GetPreviousItem();
    }
}