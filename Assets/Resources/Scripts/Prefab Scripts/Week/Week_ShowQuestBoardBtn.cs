using UnityEngine;
using System.Collections;

public class Week_ShowQuestBoardBtn : MonoBehaviour {

	void OnMouseDown() {
		//todo: start next week;
		GameManager.instQuestBoard.SetActive (true);
	}
}
