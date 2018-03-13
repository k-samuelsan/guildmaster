using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Guild {
    List<Character> characters;
	int funds;

	public Guild() {
		characters = new List<Character>();
		funds = 0;
		MakeTestChars ();
	}

	private void MakeTestChars() {
		characters.Add (new Character ("jerry", CharacterClass.getClass(Constants.CLASS_Mage)));
		characters.Add (new Character ("sam", CharacterClass.getClass(Constants.CLASS_Rogue)));
		characters.Add (new Character ("justin", CharacterClass.getClass(Constants.CLASS_Warrior)));
	}

	public List<Character> getCharacters() {
		return characters;
	}
		
}
