namespace VisitorSample
{
    class ParttimeEmployee : Employee
    {
        private string name; //员工姓名
        private double hourWage; //员工时薪
        private int workTime; //工作时间

        public ParttimeEmployee(string name, double hourWage, int workTime)
        {
            this.name = name;
            this.hourWage = hourWage;
            this.workTime = workTime;
        }	

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double HourWage
        {
            get { return hourWage; }
            set { hourWage = value; }
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
