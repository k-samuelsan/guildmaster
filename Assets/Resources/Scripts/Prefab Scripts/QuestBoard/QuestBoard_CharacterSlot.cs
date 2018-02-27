using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class QuestBoard_CharacterSlot : MonoBehaviour {

	private Character character;
    public static GameObject selectedSlot;

    public void OnMouseDown(BaseEventData eventData) {
        GameManager.setCharacterSelect(true);
        PointerEventData pointerEventData = (PointerEventData)eventData;
        setSelectedSlot(pointerEventData.pointerPress);
	}

	public void setCharacter(Character character) {
		this.character = character;
	}

	Character getCharacter() {
		return character;
	}

    public static void setSelectedSlot(GameObject newSlot)
    {
        selectedSlot = newSlot;
        Image image = newSlot.gameObject.transform.Find("Character").GetComponent<Image>();
        image.sprite = Resources.Load<Sprite>("Sprites/test-sprite");
    }

    public static void setSelectedSlotCharacter(Character character) {
        selectedSlot.GetComponent<QuestBoard_CharacterSlot>().setCharacter(character);
    }
}
