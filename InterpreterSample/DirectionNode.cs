namespace InterpreterSample
{
    class DirectionNode : AbstractNode 
    {
	    private string direction;
	
	    public DirectionNode(string direction) 
        {
		    this.direction = direction;
	    }
	
        //方向表达式的解释操作
	    public override string Interpret() 
        {
		    if (direction.Equals("up")) 
            {
			    return "向上";
		    }
		    else if (direction.Equals("down")) 
            {
			    return "向下";
		    }
		    else if (direction.Equals("left")) 
            {
			    return "向左";
		    }
		    else if (direction.Equals("right")) 
            {
			    return "向右";
		    }
		    else 
            {
			    return "无效指令";
		    }
	    }
    }
}
