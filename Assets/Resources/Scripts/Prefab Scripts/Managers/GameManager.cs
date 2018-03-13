using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static Guild guild;
	int weekCounter;
    static GameManager gameManager;
    static DataManager dataManager;

	public GameObject thisWeek;
	public GameObject questBoard;
	public GameObject characterSelect;

	// Use this for initialization
	void Start () {
		gameManager = this;
        dataManager = DataManager.getInstance();
		guild = new Guild ();
		weekCounter = 0;
		NextTurn ();
	}

	public void NextTurn () {
		Debug.Log (gameManager.weekCounter);
		gameManager.weekCounter++;
        questBoard.GetComponent<QuestBoard>().Refresh();
        characterSelect.GetComponent<CharacterSelect>().Refresh();
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
