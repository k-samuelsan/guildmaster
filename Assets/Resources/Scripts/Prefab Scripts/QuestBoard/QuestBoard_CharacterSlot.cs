using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestBoard_CharacterSlot : MonoBehaviour {

	private Character character;

	void OnMouseDown() {
		GameManager.instCharacterSelect.SetActive(true);
		CharacterSelect characterSelect = GameManager.instCharacterSelect.GetComponent<CharacterSelect>();
		characterSelect.setCurrentSlot(this);
	}

	public void setCharacter(Character character) {
		this.character = character;
	}

	Character getCharacter() {
		return character;
	}
}
