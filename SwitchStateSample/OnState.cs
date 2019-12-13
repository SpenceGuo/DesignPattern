using System;

namespace SwitchStateSample
{
    class OnState : SwitchState
    {
        public override void On(Switch s) 
        {
		    Console.WriteLine("已经打开！");
	    }

        public override void Off(Switch s) 
        {
		    Console.WriteLine("关闭！");
		    s.SetState(Switch.GetState("off"));
	    }
    }
}
