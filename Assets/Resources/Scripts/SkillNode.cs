using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SkillNode : MonoBehaviour, IPointerEnterHandler,IPointerDownHandler {

	//技の名前の情報
	public string skillName{ get; set;}

	//技の説明文の情報
	public string skillInfo{ get; set;}

	private GameObject whom;

	GameObject nameHolder;
	Text info;

	void Awake(){
		nameHolder = this.transform.GetChild (0).gameObject;
		info = GameObject.Find("Canvas/MenuWindow/SkillMenu/InfoSpace/Text").GetComponent<Text>();
	}

	void Start(){
		nameHolder.GetComponent<Text> ().text = skillName;
		whom = GameObject.Find ("WhomMenu");
	}

	//IPointerEnterHandlerインターフェースの実装によりアクセス権はpublicに制限される
	public void OnPointerEnter(PointerEventData data){
		info.text = skillInfo;
	}

//	void Update(){
//	}

	public void OnPointerDown(PointerEventData data){
		if (whom.GetComponent<CanvasGroup> ().alpha == 0) {
			whom.GetComponent<CanvasGroup> ().alpha = 1;
		} else {
			whom.GetComponent<CanvasGroup> ().alpha = 0;
		}


	}

}