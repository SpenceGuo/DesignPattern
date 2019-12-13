using System.Collections.Generic;

namespace IteratorSample
{
    /*
    class ProductListNew : AbstractObjectList 
    {
	    public ProductListNew(List<object> products) : base(products)
        {
	    }
	
	    public override AbstractIterator CreateIterator() 
        {
		    return new ProductIterator();
	    }
	
	    //商品迭代器：具体迭代器，内部类实现
	    private class ProductIterator : AbstractIterator 
        {
		    private int cursor1;
		    private int cursor2;
		
		    public ProductIterator() 
            {
			    cursor1 = 0;
			    cursor2 = objects.Count - 1;
		    }
		
		    public void Next() 
            {
			    if(cursor1 < objects.Count) 
                {
				    cursor1++;
			    }
		    }
		
		    public bool IsLast() 
            {
			    return (cursor1 == objects.Count);
		    }
		
		    public void Previous() 
            {
			    if(cursor2 > -1) 
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
			    return objects[cursor1];
		    } 
			
		    public object GetPreviousItem() 
            {
			    return objects[cursor2];
		    } 	
	    }
    }
    */
}
