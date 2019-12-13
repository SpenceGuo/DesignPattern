namespace IteratorSample
{
    interface Iterator
    {
        void First(); //将游标指向第一个元素
        void Next(); //将游标指向下一个元素
        bool HasNext(); //判断是否存在下一个元素
        object CurrentItem(); //获取游标指向的当前元素
    }

    class ConcreteIterator : Iterator 
    {
	    private ConcreteAggregate objects; //维持一个对具体聚合对象的引用，以便于访问存储在聚合对象中的数据
	    private int cursor; //定义一个游标，用于记录当前访问位置
	    public ConcreteIterator(ConcreteAggregate objects) 
        {
		    this.objects = objects;
	    }

	    public void First() 
        {  
            //实现代码  
        }
		
	    public void Next() 
        { 
            //实现代码  
        }

	    public bool HasNext() 
        {  
            //实现代码
            return false;
        }
	
	    public object CurrentItem() 
        {  
            //实现代码
            return null;
        }
    }

    interface Aggregate
    {
        Iterator CreateIterator();
    }
    
    class ConcreteAggregate : Aggregate 
    {	
        //......	
	    public Iterator CreateIterator() 
        {
		    return new ConcreteIterator(this);
	    }
	    //......
    }
}
