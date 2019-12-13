using System;

namespace AbstractFactorySample
{
    class SpringTextField : TextField 
    {
	    public void Display() 
        {
		    Console.WriteLine("显示绿色边框文本框。");
	    }
    }
}
