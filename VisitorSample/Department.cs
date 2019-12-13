namespace VisitorSample
{
    abstract class Department
    {
        //声明一组重载的访问方法，用于访问不同类型的具体元素
        public abstract void Visit(FulltimeEmployee employee);
        public abstract void Visit(ParttimeEmployee employee);	
    }
}
