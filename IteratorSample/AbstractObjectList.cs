using System.Collections.Generic;

namespace IteratorSample
{
    abstract class AbstractObjectList
    {
        protected List<object> objects = new List<object>();

        public AbstractObjectList(List<object> objects)
        {
            this.objects = objects;
        }

        public void AddObject(object obj)
        {
            this.objects.Add(obj);
        }

        public void RemoveObject(object obj)
        {
            this.objects.Remove(obj);
        }

        public List<object> GetObjects()
        {
            return this.objects;
        }

        //声明创建迭代器对象的抽象工厂方法
        public abstract AbstractIterator CreateIterator();
    }
}
