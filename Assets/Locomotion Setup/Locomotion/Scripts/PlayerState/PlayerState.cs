using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState :StateBehavior
{
	public PlayerState(Pawn pawn)
	{
		mControllTarget = pawn;
	}

	protected Pawn mControllTarget;
	public Pawn ControllTarget
	{
		set{ mControllTarget = value;}
		get{ return mControllTarget;}
	}

	public override void  BeginState(){}
	public override void  TickState(){}
	public override void  EndState(){}
	
}
