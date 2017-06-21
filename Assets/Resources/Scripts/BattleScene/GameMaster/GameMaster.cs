using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {

	public List<BattleObject> allBattleObj = new List<BattleObject> ();

	public List<Enemy> enemyOnBattlefield = new List<Enemy>();

	public List<BattlePlayer> playerOnBattlefield = new List<BattlePlayer>();

	public enum GameState{
		INTRODUCTION,
		DETERMINATION,
		PL_SELECTION,
		EN_SELECTION,
		EXECUTION,
		LOSE_EXIT,
		VICTORY_EXIT
	}

	GameState state = GameState.INTRODUCTION;

	//プレイヤー全員の総HP
	int totalHP_Player;

	//エネミー全員の総HP
	int totalHP_Enemy;

	void Awake () {
		//"BattleObject"tagのついているオブジェクトをフィールドから一斉に取得
		GameObject[] bObj = GameObject.FindGameObjectsWithTag ("BattleObject");
		foreach(GameObject gameO in bObj){
			//エネミーとプレイヤーをそれぞれ実体化し、同じリストに格納
			//同じBattleObject型リストに格納するが、PlayerとEnemyは分けて実体化する必要がある
			BattleObject battleO;
			if(gameO.GetComponent<BattlePlayer>() == true){
				battleO = gameO.GetComponent<BattlePlayer> ();
				allBattleObj.Add (battleO);
			}else if(gameO.GetComponent<Enemy>() == true){
				battleO = gameO.GetComponent<Enemy> ();
				allBattleObj.Add (battleO);
			}
		}

		//allbattleObjからプレイヤーとエネミーの実体を分け、別々の配列に格納する
		foreach(BattleObject bo in allBattleObj){
			if(bo is BattlePlayer){
				//場に存在するプレイヤーだけをリストに格納
				playerOnBattlefield.Add ((BattlePlayer)bo);
			}else if(bo is Enemy){
				//場に存在するエネミーだけをリストに格納
				enemyOnBattlefield.Add ((Enemy)bo);
			}
		}

		//敵味方それぞれをヒエラルキーの順番でソート
		enemyOnBattlefield.Sort ((a,b) => a.transform.GetSiblingIndex() - b.transform.GetSiblingIndex());
		playerOnBattlefield.Sort ((a,b) => a.transform.GetSiblingIndex() - b.transform.GetSiblingIndex());
	}

	void Start(){
	}

	void Update(){
//
//		//戦闘初期状態 (敵の説明や状況のアナウンス)
//		if(state == GameState.INTRODUCTION){
//			if((playerOnBattlefield[playerOnBattlefield.Count-1]).selection == true){
//				Debug.Log ("ALL Players Selected BattleOrders.");
//
//				state = GameState.EN_SELECTION;
//			}
//		}
//
//		//プレイヤーの選択状態なら
//		if(state == GameState.PL_SELECTION){
//			if((playerOnBattlefield[playerOnBattlefield.Count-1]).selection == true){
//				Debug.Log ("ALL Players Selected BattleOrders.");
//
//				state = GameState.EN_SELECTION;
//			}
//		}
//
//		//エネミーの選択状態なら
//		if(state == GameState.EN_SELECTION){
//			if((enemyOnBattlefield[enemyOnBattlefield.Count-1]).selection == true){
//				Debug.Log ("ALL Enemies Selected BattleOrders.");
//
//				state = GameState.EXECUTION;
//			}
//		}
//
//		//実行状態(貯まったbattleOrderを処理する状態)なら
//		if(state == GameState.EXECUTION){
//			Debug.Log ("ALL BattleOrder was Executed.");
//
//			state = GameState.DETERMINATION;
//		}
//
//		//判定状態(戦闘終了と戦闘続行を判定する)なら
//		if(state == GameState.DETERMINATION){
//			foreach(BattlePlayer bp in playerOnBattlefield){
//				totalHP_Player += bp.playerHp;
//			}
//			foreach(Enemy en in enemyOnBattlefield){
//				totalHP_Enemy += en.enemyHp;
//			}
//
//			//戦闘状態はループしなければいけない
//
//			//プレイヤーの勝利
//			if(totalHP_Enemy <= 0){
//				Debug.Log ("BattleExitConditinal Determine. : DeterminationValue => " + battleExit);
//				Debug.Log ("ALL HEROS WARE SLAYNED.");
//				state = GameState.LOSE_EXIT;
//			}
//
//			//エネミーの勝利
//			if(totalHP_Enemy <= 0){
//				Debug.Log ("BattleExitConditinal Determine. : DeterminationValue => " + battleExit);
//				Debug.Log ("ALL ENEMIES WARE PANISHED.\nbut,What did they to you ?");
//				state = GameState.VICTORY_EXIT;
//			}
//		}
	}

	public void GameStateChange(){
		switch (this.state) {
			case GameState.INTRODUCTION:
				Debug.Log ("hoge");
				break;
			case GameState.PL_SELECTION:
				Debug.Log ("hoge");
				break;
			case GameState.EN_SELECTION:
				Debug.Log ("hoge");
				break;
			case GameState.EXECUTION:
				Debug.Log ("hoge");
				break;
			case GameState.DETERMINATION:
				Debug.Log ("hoge");
				break;
			case GameState.LOSE_EXIT:
				Debug.Log ("hoge");
				break;
			case GameState.VICTORY_EXIT:
				Debug.Log ("hoge");
				break;
			default:
				Debug.LogError ("遷移状態に異常を検知。ステートがループを抜けています。");
				break;
		}
	}
}
