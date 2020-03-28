namespace ch09_Composite.Classic
{
    public abstract class AbstractFile
    {
        public abstract void Add(AbstractFile file);
        public abstract void Remove(AbstractFile file);
        public abstract AbstractFile GetChild(int i);
        public abstract void KillVirus();
    }
}