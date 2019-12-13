using System;

namespace SimpleFactorySample
{
    class HistogramChart : Chart 
    {
	    public HistogramChart() 
        {
		    Console.WriteLine("创建柱状图！");
	    }
	
	    public void Display() 
        {
            Console.WriteLine("显示柱状图！");
	    }
    }
}
