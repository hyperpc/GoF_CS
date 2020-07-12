namespace ch24_Visitor.Employee
{
    public abstract class Department
    {
        public abstract void Visit(FulltimeEmployee employee);
        public abstract void Visit(ParttimeEmployee employee);
    }
}