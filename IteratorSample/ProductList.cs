using System.Collections.Generic;

namespace IteratorSample
{
    class ProductList : AbstractObjectList
    {
        public ProductList(List<object> products)
            : base(products)
        {
        }

        //实现创建迭代器对象的具体工厂方法
        public override AbstractIterator CreateIterator()
        {
            return new ProductIterator(this);
        }
    }
}
