using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class WindowController : MonoBehaviour {

	CanvasGroup targetGraphic;
	CanvasGroup mineGraphic;
	[SerializeField]
	private GameObject hoge;

	void Awake(){
		mineGraphic = this.GetComponent<CanvasGroup> ();
	}

	public void SwitchWindow(GameObject target){
		targetGraphic = target.GetComponent<CanvasGroup> ();
		if(targetGraphic.alpha == 0 && mineGraphic.alpha == 1){
			//相手が見えず自分が見えるときは相手を見えなくする
			target.GetComponent<CanvasGroup> ().alpha = 1;
		}else if(targetGraphic.alpha == 1 && mineGraphic.alpha == 0){
			//相手が見えて自分が見えないときは自分を見えなくする？
			//
			target.GetComponent<CanvasGroup> ().alpha = 0;
		}else if(targetGraphic.alpha == 0 && mineGraphic.alpha == 0){
			Debug.Log ("相手も自分も見えない");
		}

		//switch文で書き換えるか？
		//

	}
}
