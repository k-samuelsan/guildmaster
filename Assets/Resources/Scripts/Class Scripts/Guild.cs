using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Guild {
	ArrayList characters;
	int funds;

	public Guild() {
		characters = new ArrayList ();
		funds = 0;
		MakeTestChars ();
	}

	private void MakeTestChars() {
		characters.Add (new Character ("jerry", CharacterClass.getClass(Constants.CLASS_Mage)));
		characters.Add (new Character ("sam", CharacterClass.getClass(Constants.CLASS_Rogue)));
		characters.Add (new Character ("justin", CharacterClass.getClass(Constants.CLASS_Warrior)));
	}

	public ArrayList getCharacters() {
		return characters;
	}
		
}
