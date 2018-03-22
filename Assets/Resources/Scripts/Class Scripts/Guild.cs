using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Guild {
    List<Character> characters;
    int lifeTimeFunds;
	int funds;
    int questsPerWeek;

	public Guild() {
		characters = new List<Character>();
		funds = 0;
        lifeTimeFunds = 0;
        questsPerWeek = Constants.BASE_QUESTS_PER_WEEK;
		MakeTestChars ();
	}

	private void MakeTestChars() {
		characters.Add (new Character ("jerry", CharacterClass.getClass(Constants.CLASS_Mage)));
		characters.Add (new Character ("sam", CharacterClass.getClass(Constants.CLASS_Rogue)));
		characters.Add (new Character ("justin", CharacterClass.getClass(Constants.CLASS_Warrior)));
	}

	public List<Character> GetCharacters() {
		return characters;
	}

    public int GetQuestsPerWeek() {
        return questsPerWeek;
    }

    public int GetGuildRating() {
        int guildRating = 0;
        foreach (Character character in characters) {
            guildRating += character.GetLevel();
        }
        return guildRating;
    }
		
}
