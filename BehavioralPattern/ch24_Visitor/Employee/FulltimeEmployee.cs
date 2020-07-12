namespace ch24_Visitor.Employee
{
    public class FulltimeEmployee : Employee
    {
        private string name;
        private double weeklyWage;
        private int workTime;
        public FulltimeEmployee(string name, double weeklyWage, int workTime){
            this.name=name;
            this.weeklyWage=weeklyWage;
            this.workTime=workTime;
        }
        public string Name{
            get{return name;}
            set{name=value;}
        }
        public double WeeklyWage{
            get{return weeklyWage;}
            set{weeklyWage=value;}
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