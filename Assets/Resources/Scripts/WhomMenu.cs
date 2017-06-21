using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhomMenu : MonoBehaviour {

	CanvasGroup canvasGroup;
	GameObject whomContent;
	GameMaster gm;

	public GameObject wNode;

	string whom;

	void Awake(){
//		canvasGroup = GetComponent<CanvasGroup> ();
//		canvasGroup.alpha = 0;
		whomContent = GameObject.Find("Canvas/WhomMenu/WhomField/WhomView/Viewport/Content");

		gm = GameObject.Find ("GameMaster").GetComponent<GameMaster>();
	}

	void Start () {
		foreach(Enemy en in gm.enemyOnBattlefield){
			GameObject nodes = Instantiate (wNode,whomContent.transform);
			nodes.GetComponent<RectTransform> ().offsetMax = new Vector2 (0,0);
			nodes.GetComponent<RectTransform> ().offsetMin = new Vector2 (0,0);
			nodes.GetComponent<Toggle> ().group = this.GetComponent<ToggleGroup> ();
			//WhomNodeのTextを取得し、敵の名前を挿入
			nodes.transform.GetChild (0).GetComponent<Text> ().text = en.GetComponent<Enemy> ().enemyName;

//			nodes.GetComponent<WhomNode> ().candidateToUseSkill = en.GetComponent<Enemy> ().enemyName;
//			nodes.GetComponent<WhomNode> ().numberOfCanditate = gm.enemyOnBattlefield.IndexOf(en);
		}
	}

	void Update () {
	}
}
