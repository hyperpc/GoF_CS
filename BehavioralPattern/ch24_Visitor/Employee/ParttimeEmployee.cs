namespace ch24_Visitor.Employee
{
    public class ParttimeEmployee : Employee
    {
        private string name;
        private double hourlyWage;
        private int workTime;
        public ParttimeEmployee(string name, double hourlyWage, int workTime){
            this.name=name;
            this.hourlyWage=hourlyWage;
            this.workTime=workTime;
        }
        public string Name{
            get{return name;}
            set{name=value;}
        }
        public double HourlyWage{
            get{return hourlyWage;}
            set{hourlyWage=value;}
        }
        public int WorkTime{
            get{return workTime;}
            set{workTime=value;}
        }
        public void Accept(Department handler){
            handler.Visit(this);
        }
    }
}