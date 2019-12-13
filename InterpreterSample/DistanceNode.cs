namespace InterpreterSample
{
    class DistanceNode : AbstractNode 
    {
	    private string distance;
	
	    public DistanceNode(string distance) 
        {
		    this.distance = distance;
	    }
	
        //距离表达式的解释操作
	    public override string Interpret() 
        {
		    return this.distance;
	    }	
    }
}
