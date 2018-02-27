using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharacterSelect_CharacterSlot : MonoBehaviour
{
	private Character character;

	void OnMouseDown() {
        QuestBoard_CharacterSlot.setSelectedSlotCharacter(character);
		GameManager.getInstance().characterSelect.SetActive (false);
	}

	public void setCharacter(Character character) {
		this.character = character;
        Image image = transform.Find("Character").GetComponent<Image>();
        image.sprite = Resources.Load<Sprite> ("Sprites/" + character.getSpriteName());
	}
}

