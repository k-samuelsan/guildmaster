using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static Guild guild;
	int weekCounter;
    static GameManager gameManager;

	public GameObject thisWeek;
	public GameObject questBoard;
	public GameObject characterSelect;

	// Use this for initialization
	void Start () {
		gameManager = this;
		guild = new Guild ();
		weekCounter = 0;
		nextTurn ();
	}

	public static void nextTurn () {
		Debug.Log (gameManager.weekCounter);
		gameManager.weekCounter++;
	}

    public static GameManager getInstance() {
        return gameManager;
    }

    public static void setCharacterSelect(bool active)
    {
        gameManager.characterSelect.SetActive(active);
    }

    public static void setQuestBoard(bool active)
    {
        gameManager.questBoard.SetActive(active);
    }
}
