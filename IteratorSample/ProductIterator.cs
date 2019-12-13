using System.Collections.Generic;

namespace IteratorSample
{
    class ProductIterator : AbstractIterator 
    {
        private ProductList productList;
        private List<object> products;
        private int cursor1; //定义一个游标，用于记录正向遍历的位置
        private int cursor2; //定义一个游标，用于记录逆向遍历的位置

        public ProductIterator(ProductList list)
        {
            this.productList = list;
            this.products = list.GetObjects(); //获取集合对象
            cursor1 = 0; //设置正向遍历游标的初始值
            cursor2 = products.Count - 1; //设置逆向遍历游标的初始值
        }

        public void Next()
        {
            if (cursor1 < products.Count)
            {
                cursor1++;
            }
        }

        public bool IsLast()
        {
            return (cursor1 == products.Count);
        }

        public void Previous()
        {
            if (cursor2 > -1)
            {
                cursor2--;
            }
        }

        public bool IsFirst()
        {
            return (cursor2 == -1);
        }

        public object GetNextItem()
        {
            return products[cursor1];
        }

        public object GetPreviousItem()
        {
            return products[cursor2];
        } 	
    }
}
