using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour {
	public static QuestBoard_CharacterSlot currentSlot;
	ArrayList characters;
	ArrayList characterSlots;
	int currentPage = 0; //each page holds Const.NUM_CHARS_PER_PAGE characters

	void Start() {
		characterSlots = new ArrayList ();
		Transform[] children = gameObject.GetComponentsInChildren<Transform> ();
		foreach (Transform child in children) {
			if(child.CompareTag("Character Slots")) {
				foreach (Transform slot in child.GetComponentsInChildren<Transform>()) {
					if (slot.CompareTag ("Character Slot")) {
						characterSlots.Add (slot);
					}
				}
			}
		}	
		characters = GameManager.guild.getCharacters ();
		updateSlots ();
	}

	ArrayList getCharactersFromCurrentPage() {
		int startIdx = 1 * currentPage;
		return characters.GetRange (startIdx, startIdx + Constants.NUM_CHARACTERS_PER_CHAR_SELECT_PAGE);
	}

	void updateSlots() {
		ArrayList charactersInPage = getCharactersFromCurrentPage ();
		for (int i = 0 ; i < Constants.NUM_CHARACTERS_PER_CHAR_SELECT_PAGE; i++) {
			GameObject thisCharacter = (GameObject) charactersInPage [i];
			GameObject thisSlot = (GameObject) characterSlots [i];
			CharacterSelect_CharacterSlot slot = thisSlot.GetComponent<CharacterSelect_CharacterSlot> ();
			slot.setCharacter (thisCharacter.GetComponent<Character>());
		}
	}

		

	public void setCurrentSlot(QuestBoard_CharacterSlot newSlot) {
		currentSlot = newSlot;
	}
}
