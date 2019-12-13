namespace VisitorSample
{
    class FulltimeEmployee : Employee
    {
        private string name; //员工姓名
        private double weeklyWage; //员工周薪
        private int workTime; //工作时间

        public FulltimeEmployee(string name, double weeklyWage, int workTime)
        {
            this.name = name;
            this.weeklyWage = weeklyWage;
            this.workTime = workTime;
        }	

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double WeeklyWage
        {
            get { return weeklyWage; }
            set { weeklyWage = value; }
        }

        public int WorkTime
        {
            get { return workTime; }
            set { workTime = value; }
        }

        public void Accept(Department handler)
        {
            handler.Visit(this); //调用访问者的访问方法
        }
    }
}
