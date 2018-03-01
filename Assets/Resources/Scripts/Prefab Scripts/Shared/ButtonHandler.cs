using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour {

    public void ShowQuestBoard() {
        GameManager.SetQuestBoard(true);
    }

    public void HideQuestBoard() {
        GameManager.SetQuestBoard(false);
    }

    public void HideCharacterSelect() {
        GameManager.SetCharacterSelect(false);
    }

    public void NextTurn() {
        GameManager.GetInstance().NextTurn();
    }
}
