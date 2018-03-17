using System;
using System.Collections.Generic;

public class QuestType {
    public string name;
    public int baseXp;
    public int baseGold;
    public List<string> questNames;

    public QuestType(string name, int baseXp, int baseGold, List<string> questNames) {
        this.name = name;
        this.baseXp = baseXp;
        this.baseGold = baseGold;
        this.questNames = questNames;
    }
}
