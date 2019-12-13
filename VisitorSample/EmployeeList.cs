using System;
using System.Collections;

namespace VisitorSample
{
    class EmployeeList
    {
        //定义一个集合用于存储员工对象
        private ArrayList list = new ArrayList();

        public void AddEmployee(Employee employee)
        {
            list.Add(employee);
        }

        //遍历访问员工集合中的每一个员工对象
        public void Accept(Department handler) 
        {
		    foreach(Object obj in list) 
            {
			    ((Employee)obj).Accept(handler);
		    }
	    }
    }
}
