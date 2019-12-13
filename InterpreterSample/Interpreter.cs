using System.Collections;

namespace InterpreterSample
{
    abstract class AbstractExpression
    {
        public abstract void Interpret(Context ctx);
    }

    class TerminalExpression : AbstractExpression 
    {
	    public override void Interpret(Context ctx) 
        {
		    //终结符表达式的解释操作
	    }
    }

    class NonterminalExpression : AbstractExpression 
    {
	    private AbstractExpression left;
	    private AbstractExpression right;
	
	    public NonterminalExpression(AbstractExpression left,AbstractExpression right) 
        {
		    this.left=left;
		    this.right=right;
	    }
	
	    public override void Interpret(Context ctx) 
        {
		    //递归调用每一个组成部分的interpret()方法
		    //在递归调用时指定组成部分的连接方式，即非终结符的功能
	    }	
    }

    class Context
    {
        private Hashtable ht = new Hashtable();

        //往环境类中设值
        public void Assign(string key, string value)
        {
            ht.Add(key,value);
        }

        //获取存储在环境类中的值
        public string Lookup(string key)
        {
            return (string)ht[key];
        }
    }
}
