namespace ch24_Visitor.Employee
{
    public interface Employee
    {
        void Accept(Department handler);
    }
}