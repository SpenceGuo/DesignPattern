using System;

namespace ScreenStateSample
{
    class NormalState : ScreenState
    {
        public override void Display() 
        {
		    Console.WriteLine("正常大小！");
	    }
    }
}
