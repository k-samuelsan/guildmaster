using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestBoard : MonoBehaviour {
    public GameObject characterSlot;
	ArrayList characterSlots;
    public ArrayList characters;

    public void Refresh()
    {
        this.characters = new ArrayList();
        this.characterSlots = new ArrayList();
        GameObject characterSlotsObject = transform.Find("CharacterSlots").gameObject;
        for (int i = 0; i < Constants.NUM_CHARS_PER_QUEST; i++)
        {
            GameObject thisSlot = Instantiate(characterSlot) as GameObject;
            thisSlot.transform.SetParent(characterSlotsObject.transform);
            characterSlots.Add(thisSlot);
        }
    }
}
