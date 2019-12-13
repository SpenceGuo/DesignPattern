using System;

namespace ScreenStateSample
{
    class Screen
    {
        //枚举所有的状态，currentState表示当前状态
        private ScreenState currentState, normalState, largerState, largestState;

        public Screen()
        {
            this.normalState = new NormalState(); //创建正常状态对象
            this.largerState = new LargerState(); //创建二倍放大状态对象
            this.largestState = new LargestState(); //创建四倍放大状态对象
            this.currentState = normalState; //设置初始状态
            this.currentState.Display();
        }

        public void SetState(ScreenState state)
        {
            this.currentState = state;
        }

        //单击事件处理方法，封转了对状态类中业务方法的调用和状态的转换
        public void OnClick()
        {
            if (this.currentState == normalState)
            {
                this.SetState(largerState);
                this.currentState.Display();
            }
            else if (this.currentState == largerState)
            {
                this.SetState(largestState);
                this.currentState.Display();
            }
            else if (this.currentState == largestState)
            {
                this.SetState(normalState);
                this.currentState.Display();
            }
        }
    }
}
