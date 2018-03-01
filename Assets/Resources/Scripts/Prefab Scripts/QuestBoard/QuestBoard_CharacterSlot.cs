using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class QuestBoard_CharacterSlot : MonoBehaviour {

	private Character character;
    public static GameObject selectedSlot;

    public void OnMouseDown(BaseEventData eventData) {
        PointerEventData pointerEventData = (PointerEventData)eventData;
        QuestBoard_CharacterSlot thisSlot = pointerEventData.pointerPress.GetComponentInParent<QuestBoard_CharacterSlot>();
        if (thisSlot.GetCharacter() == null)
        {
            SetSelectedSlot(pointerEventData.pointerPress);
            GameManager.SetCharacterSelect(true);
        }
    }

    public void ClearCharacter(BaseEventData eventData)
    {
        PointerEventData pointerEventData = (PointerEventData)eventData;
        QuestBoard_CharacterSlot thisSlot = pointerEventData.pointerPress.GetComponentInParent<QuestBoard_CharacterSlot>();
        Character thisChar = thisSlot.character;
        QuestBoard questBoard = GameManager.GetInstance().GetQuestBoard();
        questBoard.characters.Remove(thisChar);
        thisSlot.SetCharacter(null);
    }

    public void SetCharacter(Character character) {
        this.character = character;
        Image image = transform.Find("Character").GetComponent<Image>();
        if (character != null)
        {
            QuestBoard questBoard = GameManager.GetInstance().GetQuestBoard();
            questBoard.characters.Add(character);
            image.sprite = Resources.Load<Sprite>("Sprites/" + character.GetSpriteName());
            SetOverlay(true);
        }
        else {
            image.sprite = null;
            SetOverlay(false);
        }
    }

    void SetOverlay(bool active)
    {
        GameObject overlay = transform.Find("Overlay").gameObject;
        overlay.SetActive(active);
        Transform label = overlay.transform.Find("Label");
        if (active)
        {
            label.Find("Level").gameObject.GetComponent<Text>().text = "Level " + character.GetLevel();
            label.Find("Name").gameObject.GetComponent<Text>().text = character.GetName();
        } else
        {
            label.Find("Level").gameObject.GetComponent<Text>().text = "";
            label.Find("Name").gameObject.GetComponent<Text>().text = "";
        }
    }

	Character GetCharacter() {
		return character;
	}

    public static void SetSelectedSlot(GameObject newSlot)
    {
        selectedSlot = newSlot;
    }

    public static void SetSelectedSlotCharacter(Character character) {
        QuestBoard_CharacterSlot thisSlot = selectedSlot.GetComponent<QuestBoard_CharacterSlot>();
        thisSlot.SetCharacter(character);
    }
}
