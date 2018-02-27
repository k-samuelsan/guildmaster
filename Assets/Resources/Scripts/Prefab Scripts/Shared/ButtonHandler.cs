using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour {

    public void ShowQuestBoard() {
        GameManager.setQuestBoard(true);
    }

    public void HideQuestBoard() {
        GameManager.setQuestBoard(false);
    }

    public void HideCharacterSelect() {
        GameManager.setCharacterSelect(false);
    }

    public void NextTurn() {
        GameManager.nextTurn();
    }
}
