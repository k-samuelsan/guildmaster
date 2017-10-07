using UnityEngine;
using System.Collections;

public class CharacterSelect_CharacterSlot : MonoBehaviour
{
	private Character character;

	void OnMouseDown() {
		CharacterSelect.currentSlot.setCharacter (character);
		GameManager.instCharacterSelect.SetActive (false);
	}

	public void setCharacter(Character character) {
		this.character = character;
	}
}

