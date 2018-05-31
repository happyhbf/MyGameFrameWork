

public class StateBehavior 
{
	private string mStateName;
	public string StateName
	{
		set{ mStateName = value;}
		get{ return mStateName;}
	}

	public virtual void  BeginState(){}
	public virtual void  TickState(){}
	public virtual void  EndState(){}
}
