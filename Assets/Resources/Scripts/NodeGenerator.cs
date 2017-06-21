using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class NodeGenerator : MonoBehaviour {

	private GameMaster gm;

	//gameobject.fin()ではなくインスペクターで紐づけを推奨
	//最終的にはContentが増えるので、それも含めた実装を考えること
	private GameObject content;

	public GameObject node;

//	UnityAction hogehoge = hoge;

	void Awake(){
		gm = GameObject.Find("GameMaster").GetComponent<GameMaster> ();

//		whomMenu = GameObject.Find ("WhomeMenu");

		//"Content"がplayerOnBattlefieldの数だけ回る
		//すべてのUI要素にContentがプレイヤーの数だけつくられる
		//それぞれのウィンドウの"Viewport"以下の子要素(Transform t in Viewport.transform)、
		//つまりContentのそれぞれをforeachで回せる
		//これでContentの準備オッケー！

		content = GameObject.Find ("SkillMenu/AbilityView/Viewport/Content");

		foreach(int ps in gm.playerOnBattlefield[0].availebleSkills){
			GameObject nodes = Instantiate (node,content.transform);
			nodes.GetComponent<RectTransform> ().offsetMax = new Vector2 (0,0);
			nodes.GetComponent<RectTransform> ().offsetMin = new Vector2 (0,0);
			nodes.GetComponent<SkillNode>().skillName = SkillDictionary.skillDic[ps][0];
			nodes.GetComponent<SkillNode>().skillInfo = SkillDictionary.skillDic[ps][2];
			nodes.GetComponent<Toggle> ().group = this.GetComponent<ToggleGroup> ();
//			nodes.GetComponent<Toggle> ().onValueChanged.AddListener (hogehoge);
//			インスタンス時にOnClick()のコールバックを登録してみようかな
		}
	}

	void Start(){

	}

}
