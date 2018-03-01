using UnityEngine;
using System.Collections;

public class Character {
    string spriteName;
    string name;
    CharacterClass charClass;
    int level;
    int xp;

    public Character(string name, CharacterClass charClass) {
		level = 1;
		xp = 0;
		this.name = name;
        this.charClass = charClass;
        this.spriteName = charClass.sprite;
	}

	public Character (string name, int level, CharacterClass charClass) {
		this.level = level;
		xp = 0;
		this.name = name;
        this.charClass = charClass;
    }

    public string GetSpriteName() {
        return spriteName;
    }

    public string GetName() {
        return name;
    }

    public CharacterClass GetClass()
    {
        return charClass;
    }

    public int GetLevel()
    {
        return level;
    }

    public int GetXp()
    {
        return xp;
    }

}
