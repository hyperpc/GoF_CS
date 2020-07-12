using System.Collections;
namespace ch24_Visitor.Employee
{
    public class EmployeeList
    {
        private ArrayList list = new ArrayList();
        public void AddEmployee(Employee employee){
            list.Add(employee);
        }
        public void Accept(Department handler){
            foreach(object obj in list){
                ((Employee)obj).Accept(handler);
            }
        }
    }
}