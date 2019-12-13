using System;

namespace SwitchStateSample
{
    class Switch
    {
        private static SwitchState currentState, onState, offState; //定义三个静态的状态对象
        private string name;

        public Switch(string name)
        {
            this.name = name;
            onState = new OnState();
            offState = new OffState();
            currentState = onState;
        }

        public void SetState(SwitchState state)
        {
            currentState = state;
        }

        public static SwitchState GetState(string type)
        {
            if (type.Equals("on"))
            {
                return onState;
            }
            else
            {
                return offState;
            }
        }

        //打开开关
        public void On() 
        {
		    Console.Write(name);
            currentState.On(this);
	    }

        //关闭开关
        public void Off() 
        {
            Console.Write(name);
            currentState.Off(this);
	    }
    }
}
