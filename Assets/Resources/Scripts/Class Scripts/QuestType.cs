using LitJson;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class QuestType {
    public string name;
    public int baseXp;
    public int baseGold;
    public List<string> questNames;

    public QuestType(string name, int baseXp, int baseGold, JsonData questNames) {
        this.name = name;
        this.baseXp = baseXp;
        this.baseGold = baseGold;
        this.questNames = new List<string>();
        for (int i = 0; i < questNames.Count; i++) {
            this.questNames.Add((string) questNames[i]);
        }
    }

    public string GetRandomQuestName(Dictionary<string, List<string>> keywordDatabase) {
        string questName = questNames[UnityEngine.Random.Range(0, questNames.Count)];
        List<string> tags = CommonUtils.GetTags(questName);
        foreach (string tag in tags) {
            List<string> keywords;
            if (keywordDatabase.TryGetValue(tag, out keywords)) {
                Regex tagPattern = new Regex(Regex.Escape(tag));
                String keyword = keywords[UnityEngine.Random.Range(0, keywords.Count)];
                tagPattern.Replace(questName, keyword, 1);
            }
        }
        return questName;
    }
}
