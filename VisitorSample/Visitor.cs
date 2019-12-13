using System;
using System.Collections.Generic;

namespace VisitorSample
{
    abstract class Visitor
    {
        public abstract void Visit(ConcreteElementA elementA);
        public abstract void Visit(ConcreteElementB elementB);

        public void Visit(ConcreteElementC elementC)
        {
            //元素ConcreteElementC操作代码
        }
    }

    class ConcreteVisitor : Visitor 
    {
	    public override void Visit(ConcreteElementA elementA) 
        {
		    //元素ConcreteElementA操作代码
	    }

        public override void Visit(ConcreteElementB elementB) 
        {
		    //元素ConcreteElementB操作代码
	    }
    }

    interface Element
    {
        void Accept(Visitor visitor);
    }

    class ConcreteElementA : Element 
    {
	    public void Accept(Visitor visitor) 
        {
		    visitor.Visit(this);
	    }
	
	    public void OperationA() 
        {
		    //业务方法
	    }
    }

    class ConcreteElementB : Element
    {
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public void OperationB()
        {
            //业务方法
        }
    }

    class ConcreteElementC : Element
    {
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public void OperationC()
        {
            //业务方法
        }
    }

    class ObjectStructure
    {
        private List<Element> list = new List<Element>(); //定义一个集合用于存储元素对象

        //接受访问者的访问操作
        public void Accept(Visitor visitor)
        {
            foreach (Object obj in list)
            {
                ((Element)obj).Accept(visitor); //遍历访问集合中的每一个元素
            }
        }

        public void AddElement(Element element)
        {
            list.Add(element);
        }

        public void RemoveElement(Element element)
        {
            list.Remove(element);
        }
    }
}
