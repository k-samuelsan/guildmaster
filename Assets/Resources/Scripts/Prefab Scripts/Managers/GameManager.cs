using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
	public static Guild guild;
	int weekCounter;
    static GameManager gameManager;
    static DataManager dataManager;

	public GameObject thisWeek;
	public GameObject questBoard;
	public GameObject characterSelect;

    List<QuestFrame> questFrames;

	// Use this for initialization
	void Start () {
		gameManager = this;
        dataManager = DataManager.GetInstance();
		guild = new Guild ();
		weekCounter = 0;
        questFrames = new List<QuestFrame>();
		NextTurn ();
	}

	public void NextTurn () {
		Debug.Log (gameManager.weekCounter);
		gameManager.weekCounter++;
        questBoard.GetComponent<QuestBoard>().Refresh();
        characterSelect.GetComponent<CharacterSelect>().Refresh();
        dataManager.questManager.Refresh();
	}

    public static GameManager GetInstance() {
        return gameManager;
    }

    public QuestBoard GetQuestBoard() {
        return questBoard.GetComponent<QuestBoard>();
    }

    public CharacterSelect GetCharacterSelect() {
        return characterSelect.GetComponent<CharacterSelect>();
    }

    public static void SetCharacterSelect(bool active)
    {
        gameManager.characterSelect.SetActive(active);
    }

    public static void SetQuestBoard(bool active)
    {
        gameManager.questBoard.SetActive(active);
    }
}
