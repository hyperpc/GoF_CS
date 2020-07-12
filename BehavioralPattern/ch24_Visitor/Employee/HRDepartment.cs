namespace ch24_Visitor.Employee
{
    public class HRDepartment : Department
    {
        public override void Visit(FulltimeEmployee employee){
            int workTime = employee.WorkTime;
            System.Console.WriteLine($"正式员工{employee.Name}的实际工作时间为{workTime}小时。");
            if(workTime>40){
                workTime = workTime-40;
                System.Console.WriteLine($"正式员工{employee.Name}的实际加班时间为{workTime}小时。");
            } else if(workTime < 40){
                workTime = 40-workTime;
                System.Console.WriteLine($"正式员工{employee.Name}的实际请假时间为{workTime}小时。");
            }
        }
        public override void Visit(ParttimeEmployee employee){
            int workTime = employee.WorkTime;
            System.Console.WriteLine($"临时员工{employee.Name}的实际工作时间为{workTime}小时。");
        }
    }
}