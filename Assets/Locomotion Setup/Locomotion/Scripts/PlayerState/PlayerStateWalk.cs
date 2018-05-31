public class PlayerStateWalk : PlayerState 
{
	string mAnimation = "Run";

	public PlayerStateWalk(Pawn pawn) : base(pawn)
	{
	}

	public override void  BeginState()
	{
		mControllTarget.PawnAnimator.CrossFade (mAnimation, 0);
	}

	public override void  TickState(){}
	public override void  EndState(){}
}
