using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Guild {
	ArrayList characters;
	int funds;

	public Guild() {
		characters = new ArrayList ();
		funds = 0;
		makeTestChars ();
	}

	private void makeTestChars() {
		characters.Add (new Character ("jerry", Constants.CLASS_Mage));
		characters.Add (new Character ("sam", Constants.CLASS_Rogue));
		characters.Add (new Character ("justin", Constants.CLASS_Warrior));
	}

	public ArrayList getCharacters() {
		return characters;
	}
		
}
