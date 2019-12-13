using System;

namespace ScreenStateSample
{
    class LargerState : ScreenState
    {
        public override void Display()
        {
            Console.WriteLine("二倍大小！");
        }
    }
}
