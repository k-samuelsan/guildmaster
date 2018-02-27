using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestBoard : MonoBehaviour {
    public GameObject characterSlot;
	ArrayList characterSlots;

    void Start()
    {
        this.characterSlots = new ArrayList();
        Transform[] children = gameObject.GetComponentsInChildren<Transform>();
        GameObject characterSlotsObject = transform.Find("CharacterSlots").gameObject;
        for (int i = 0; i < Constants.NUM_CHARS_PER_QUEST; i++)
        {
            GameObject thisSlot = Instantiate(characterSlot) as GameObject;
            thisSlot.transform.parent = characterSlotsObject.transform;
            characterSlots.Add(thisSlot);
        }
    }
}
