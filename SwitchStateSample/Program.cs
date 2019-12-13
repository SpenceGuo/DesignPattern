using System;

namespace SwitchStateSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Switch s1, s2;
            s1 = new Switch("开关1");
            s2 = new Switch("开关2");

            s1.On();
            s2.On();
            s1.Off();
            s2.Off();
            s2.On();
            s1.On();

            Console.Read();
        }
    }
}
