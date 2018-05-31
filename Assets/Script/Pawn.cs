using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//key:skillID, value:time

public class Pawn : MonoBehaviour 
{
	public Animator PawnAnimator;
	StateManager mSateManager;

	void Awake()
	{
		mSateManager = new StateManager ();
		mSateManager.RegisterStates ("Idle", new PlayerStateIdle(this));
		mSateManager.RegisterStates ("Run", new PlayerStateWalk(this));
	}

	// Use this for initialization
	void Start () 
	{
			
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyUp(KeyCode.Z))
		{
			//PlayAnim ("Run");
			mSateManager.TransitionStateTo ("Run");
		}

		if(Input.GetKeyUp(KeyCode.X))
		{
			//PlayAnim ("Idle");
			mSateManager.TransitionStateTo ("Idle");
		}
	}

	void PlayAnim(string animName)
	{
		PawnAnimator.CrossFade (animName, 0);
	}

	void UseSkill (int skillid)
	{

	}
}
