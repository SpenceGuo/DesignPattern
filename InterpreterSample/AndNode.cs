namespace InterpreterSample
{
    class AndNode : AbstractNode 
    {
	    private AbstractNode left; //And的左表达式
	    private AbstractNode right; //And的右表达式

	    public AndNode(AbstractNode left, AbstractNode right) 
        {
		    this.left = left;
		    this.right = right;
	    }
    
        //And表达式解释操作
	    public override string Interpret() 
        {
		    return left.Interpret() + "再" + right.Interpret();
	    }
    }
}
