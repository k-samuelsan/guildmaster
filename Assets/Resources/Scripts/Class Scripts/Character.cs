﻿using UnityEngine;
using System.Collections;

public class Character {
    string spriteName;
	string name;
	string characterClass;
	int level;
	int xp;

	public Character(string name, string characterClass) {
		level = 0;
		xp = 0;
		this.name = name;
		this.characterClass = characterClass;
        this.spriteName = "test-sprite";
	}

	public Character (string name, int level, string characterClass) {
		this.level = level;
		xp = 0;
		this.name = name;
		this.characterClass = characterClass;
	}

    public string getSpriteName() {
        return spriteName;
    }

}
