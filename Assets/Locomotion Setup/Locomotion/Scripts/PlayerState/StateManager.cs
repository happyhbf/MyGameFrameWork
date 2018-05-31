using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager 
{
	Pawn mTarget;
	StateBehavior mCurrentState;
	Dictionary<string, StateBehavior> mStateMap = new Dictionary<string, StateBehavior>();

	public void RegisterStates(string stateName, StateBehavior state)
	{
		mStateMap.Add (stateName, state);
	}



	public void TransitionStateTo(string targetState)
	{
		if(mCurrentState == null)
		{
			mCurrentState = mStateMap [targetState];
			mCurrentState.BeginState ();
			return;
		}

		if (mCurrentState.StateName != targetState) 
		{
			mCurrentState.EndState ();
			mCurrentState = mStateMap [targetState];
			mCurrentState.BeginState ();
		}
	}
}
