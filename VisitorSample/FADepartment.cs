using System;

namespace VisitorSample
{
    class FADepartment : Department
    {
        //实现财务部对全职员工的访问
        public override void Visit(FulltimeEmployee employee) 
        {
		    int workTime = employee.WorkTime;
		    double weekWage = employee.WeeklyWage;
		    if(workTime > 40) 
            {
			    weekWage = weekWage + (workTime - 40) * 100;
		    }
		    else if(workTime < 40) 
            {
			    weekWage = weekWage - (40 - workTime) * 80;
			    if(weekWage < 0) 
                {
				    weekWage = 0;
			    }
		    }
            Console.WriteLine("正式员工{0}实际工资为：{1}元。", employee.Name,weekWage);			
	    }

        //实现财务部对兼职员工的访问
        public override void Visit(ParttimeEmployee employee) 
        {
		    int workTime = employee.WorkTime;
		    double hourWage = employee.HourWage;
            Console.WriteLine("临时工{0}实际工资为：{1}元。", employee.Name, workTime * hourWage);		
	    }		
    }
}
