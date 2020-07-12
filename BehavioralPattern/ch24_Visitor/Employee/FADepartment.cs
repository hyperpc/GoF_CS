namespace ch24_Visitor.Employee
{
    public class FADepartment : Department
    {
        public override void Visit(FulltimeEmployee employee){
            int workTime = employee.WorkTime;
            double weekWage = employee.WeeklyWage;
            if(workTime>40){
                weekWage = weekWage+(workTime-40)*100;
            } else if(workTime<40){
                weekWage = weekWage-(40-workTime)*80;
                if(weekWage<0){
                    weekWage=0;
                }
            }
            System.Console.WriteLine($"正式员工{employee.Name}的实际工资为{weekWage}元。");
        }
        public override void Visit(ParttimeEmployee employee){
            int workTime = employee.WorkTime;
            double hourWage = employee.HourlyWage;
            System.Console.WriteLine($"临时工{employee.Name}的实际工资为{workTime*hourWage}元。");
        }
    }
}