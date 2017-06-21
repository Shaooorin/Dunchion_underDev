using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class WhomNode : MonoBehaviour,IPointerDownHandler{

	//プロパティにするasigned but never usedの警告が出ない
	GameMaster gm{ get; set;}

	void Start () {
//		player = GameObject.Find ("Char01").GetComponent<BattlePlayer> ();
		gm = GameObject.Find ("GameMaster").GetComponent<GameMaster> ();
	}

	void Update () {
	}

	public void OnPointerDown(PointerEventData data){
		
	}
}
