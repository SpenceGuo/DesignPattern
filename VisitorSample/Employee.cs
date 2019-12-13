namespace VisitorSample
{
    interface Employee
    {
        void Accept(Department handler); //接受一个抽象访问者访问
    }
}
