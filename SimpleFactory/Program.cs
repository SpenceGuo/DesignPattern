using System;
using System.Configuration;

namespace SimpleFactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Product product;
            product = Factory.GetProduct("A"); //通过工厂类创建产品对象
            product.MethodSame();
            product.MethodDiff();
            */
            Chart chart;

            //读取配置文件
            string chartStr = ConfigurationManager.AppSettings["chartType"];
            chart = ChartFactory.GetChart(chartStr); //通过静态工厂方法创建产品
            chart.Display();

            Console.Read();
        }
    }
}
