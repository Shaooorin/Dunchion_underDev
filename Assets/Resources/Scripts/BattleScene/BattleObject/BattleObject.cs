using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleObject : MonoBehaviour {

	protected string objName;
	protected int level;
	protected int hp;
	protected int mp;
	protected int strength;
	protected int deffence;
	protected int agillity;
	protected int money;
	protected int experience;

	//------------------------------------------
	//行動選択の記録に必要な変数群

	//技を使う人
	public BattleObject whoUseSkill{get; set;}

	//選択した技
	public int whichUseSkill{get; set;}

	//選択した技を使う相手
	public int skillTarget{get; set;}
	//------------------------------------------

	/// <summary>
	/// BattleObjectが既に覚えている技のリスト
	/// </summary>
	[HideInInspector]
	public List<int> availebleSkills = new List<int>();

}