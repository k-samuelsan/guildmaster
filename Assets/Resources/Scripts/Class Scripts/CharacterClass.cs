using UnityEngine;
using System.Collections;
using LitJson;

public class CharacterClass {
    public string name;
    public int id;
    public string sprite;

    public CharacterClass(string name, int id, string sprite) {
        this.name = name;
        this.id = id;
        this.sprite = sprite;
    }

    public static CharacterClass getClass(int id) {
        return DataManager.getInstance().classDatabase[id];
    }
}
