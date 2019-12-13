using System;
using System.Collections;

namespace InterpreterSample
{
    class InstructionHandler
    {
	    private AbstractNode node;
    
        public void Handle(string instruction) 
        {
    	    AbstractNode left = null, right = null;
    	    AbstractNode direction = null, action = null, distance = null;
    	    Stack stack = new Stack(); //声明一个栈对象用于存储抽象语法树
            string[] words = instruction.Split(' '); //以空格分隔指令字符串
    	    for (int i = 0; i < words.Length; i++) 
            {
                //本实例采用栈的方式来处理指令，如果遇到“and”，则将其后的三个单词作为三个终结符表达式连成一个简单句子SentenceNode作为“and”的右表达式，而将从栈顶弹出的表达式作为“and”的左表达式，最后将新的“and”表达式压入栈中。    		        
                if (words[i].Equals("and")) 
                {
    			    left = (AbstractNode)stack.Pop(); //弹出栈顶表达式作为左表达式
    		        string word1= words[++i];
    		        direction = new DirectionNode(word1);
    		        string word2 = words[++i];
    		        action = new ActionNode(word2);
    		        string word3 = words[++i];
    		        distance = new DistanceNode(word3);
    		        right = new SentenceNode(direction,action,distance); //右表达式
    			    stack.Push(new AndNode(left,right)); //将新表达式压入栈中
    		    }
                //如果是从头开始进行解释，则将前三个单词组成一个简单句子SentenceNode并将该句子压入栈中
    		    else 
                {
    		        string word1 = words[i];
    		        direction = new DirectionNode(word1);
    		        string word2 = words[++i];
    		        action = new ActionNode(word2);
    		        string word3 = words[++i];
    		        distance = new DistanceNode(word3);
    		        left = new SentenceNode(direction,action,distance);
    		        stack.Push(left); //将新表达式压入栈中
    		    }
    	    }
    	    this.node = (AbstractNode)stack.Pop(); //将全部表达式从栈中弹出
         }
	
	    public string Output() 
        {
		    string result = node.Interpret(); //解释表达式
		    return result;
	    }
    }
}
