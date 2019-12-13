using System;

namespace SwitchStateSample
{
    class OffState : SwitchState
    {
        public override void On(Switch s) 
        {
		    Console.WriteLine("打开！");
		    s.SetState(Switch.GetState("on"));
	    }

        public override void Off(Switch s) 
        {
            Console.WriteLine("已经关闭！");
	    }
    }
}
