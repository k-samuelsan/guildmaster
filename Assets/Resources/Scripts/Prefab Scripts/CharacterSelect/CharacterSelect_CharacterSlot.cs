using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class CharacterSelect_CharacterSlot : MonoBehaviour
{
    private Character character;

    public void OnMouseDown(BaseEventData eventData)
    {
        PointerEventData pointerEventData = (PointerEventData)eventData;
        GameObject thisSlot = pointerEventData.pointerPress;
        Character thisChar = thisSlot.GetComponent<CharacterSelect_CharacterSlot>().getCharacter();
        QuestBoard questBoard = GameManager.GetInstance().GetQuestBoard();
        if (!questBoard.characters.Contains(thisChar))
        {
            QuestBoard_CharacterSlot.SetSelectedSlotCharacter(thisChar);
            GameManager.SetCharacterSelect(false);
        }
    }

    public void setCharacter(Character character) {
        this.character = character;
        Image image = transform.Find("Character").GetComponent<Image>();
        image.sprite = Resources.Load<Sprite>("Sprites/" + character.GetSpriteName());
    }

    public Character getCharacter() {
        return character;
  }
}

