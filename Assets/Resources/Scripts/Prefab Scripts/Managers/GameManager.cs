using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static Guild guild;
	int weekCounter;

	public GameObject week;
	public GameObject questBoard;
	public GameObject characterSelect;

	public static GameObject thisWeek;
	public static GameManager gameManager;
	public static GameObject instQuestBoard;
	public static GameObject instCharacterSelect;

	// Use this for initialization
	void Start () {
		gameManager = this;
		guild = new Guild ();
		weekCounter = 0;
		nextTurn ();
		instQuestBoard = Instantiate (questBoard) as GameObject;
		instQuestBoard.SetActive (false);
		instCharacterSelect = Instantiate (characterSelect) as GameObject;
		instCharacterSelect.SetActive (false);
	}

	public void nextTurn () {
		Debug.Log (weekCounter);
		if (thisWeek) {
			Destroy (thisWeek);
		}
		weekCounter++;
		thisWeek = Instantiate (week) as GameObject;
	} 
}
