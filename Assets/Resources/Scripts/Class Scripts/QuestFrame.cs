using System;
using System.Collections.Generic;

public class QuestFrame {
    Quest quest;
    List<Character> characters;
    public int durationRemaining;

    public QuestFrame(Quest quest, List<Character> characters, int duration) {
        this.quest = quest;
        this.characters = characters;
        this.durationRemaining = duration;
    }

}
