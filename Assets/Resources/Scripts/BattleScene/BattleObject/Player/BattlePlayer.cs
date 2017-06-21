using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattlePlayer : BattleObject {

	public string playerName {get; set;}
	public int playerLv {get; set;}
	public int playerHp {get; set;}
	public int playerMp {get; set;}
	public int playerSTR {get; set;}
	public int playerDEF {get; set;}
	public int playerAGI {get; set;}
	public int playerEXP {get; set;}

	private Hashtable playerData;

	void Awake(){
		int c = Random.Range (1,3);
		if(c == 1){
			playerData = PlayerHashTable.playerList["player001"];
		}
		if(c == 2){
			playerData = PlayerHashTable.playerList["player002"];
		}

		playerName = (string)playerData["playerName"];
		playerLv = (int)playerData["playerLV"];
		playerHp = (int)playerData["playerHp"];
		playerMp = (int)playerData["playerMp"];
		playerSTR = (int)playerData["playerSTR"];
		playerDEF = (int)playerData["playerDEF"];
		playerAGI = (int)playerData["playerAGI"];
		playerEXP = (int)playerData["playerEXP"];

		base.objName = playerName;
		base.level = playerLv;
		base.hp = playerHp;
		base.mp = playerMp;
		base.strength = playerSTR;
		base.deffence = playerDEF;
		base.agillity = playerAGI;
		base.experience = playerEXP;

//		それぞれの持つ技の管理 (テスト用/こうやって使うメモ)
//		for(int i = 0;i < 5;i++){
//			this.playerSkill.Add ((int)Random.Range(1,6));
//		}
//		foreach(int ps in base.availebleSkill){
//			Debug.Log (playerName + "の技" + ps +" : " + SkillDictionary.skillDic[ps][2]);
//		}

		//ある程度ランダムに、BattleObjectの持つ技の情報を登録
		for(int i = 1; i < ((int)(Random.Range(2,7))); i++){
			base.availebleSkills.Add (i);
		}
	}

	void Start () {
		
	}

}
