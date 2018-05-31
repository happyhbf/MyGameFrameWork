public class PlayerSkillStepAttack1 : PlayerState {

	string mAnimation = "Idle";

	public PlayerSkillStepAttack1(Pawn pawn) : base(pawn)
	{
	}

	public override void  BeginState()
	{
		mControllTarget.PawnAnimator.CrossFade (mAnimation, 0);
	}

	public override void  TickState(){}
	public override void  EndState(){}
}
