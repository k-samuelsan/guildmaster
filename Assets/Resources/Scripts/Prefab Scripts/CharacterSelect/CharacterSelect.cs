using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour {
    public GameObject characterSlot;
	ArrayList characters;
	ArrayList characterSlots;
	int currentPageIdx = 0; //each page holds Const.NUM_CHARS_PER_PAGE characters

    void Start() {
        this.characterSlots = new ArrayList();
        Transform[] children = gameObject.GetComponentsInChildren<Transform>();
        GameObject characterSlotsObject = transform.Find("CharacterSlots").gameObject;
        for (int i = 0; i < Constants.NUM_CHARS_PER_PAGE; i++) {
            GameObject thisSlot = Instantiate(characterSlot) as GameObject;
            thisSlot.transform.parent = characterSlotsObject.transform;
            characterSlots.Add(thisSlot);
        }
		characters = GameManager.guild.getCharacters ();
		updateSlots ();
	}

	ArrayList getCharactersFromCurrentPage() {
		int startIdx = 1 * currentPageIdx;
        int count = Constants.NUM_CHARS_PER_PAGE;
        //if there is less than NUM_CHARS_PER_PAGE on this page, only get that many characters
        if (startIdx + count > characters.Count) {
            count = characters.Count % Constants.NUM_CHARS_PER_PAGE;
        }
        return characters.GetRange (startIdx, count);
	}

	void updateSlots() {
		ArrayList charactersInPage = getCharactersFromCurrentPage ();
        for (int i = 0 ; i < charactersInPage.Count; i++) {
			Character thisCharacter = (Character) charactersInPage [i];
			GameObject thisSlot = (GameObject) characterSlots [i];
			CharacterSelect_CharacterSlot slot = thisSlot.GetComponent<CharacterSelect_CharacterSlot> ();
			slot.setCharacter (thisCharacter);
		}
	}
}
