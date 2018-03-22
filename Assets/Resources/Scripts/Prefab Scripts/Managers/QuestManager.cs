using LitJson;
using System;
using System.Collections.Generic;

public class QuestManager {
    public List<Rank> ranks;
    public List<QuestType> questTypes;
    List<Obstacle> obstacles;
    public List<Quest> thisWeekQuests;

    public QuestManager(JsonData questData) {
        ranks = new List<Rank>();
        obstacles = new List<Obstacle>();
        questTypes = new List<QuestType>();
        JsonData rankData = questData["ranks"];
        foreach (JsonData rank in rankData) {
            ranks.Add(new Rank((string) rank["name"], (int) rank["modifier"], (int) rank["numObstacles"], (int) rank["numRequiredSkills"], (int) rank["baseDuration"]));
        }
        JsonData obstacleData = questData["obstacles"];
        foreach (JsonData obstacle in obstacleData) {
            obstacles.Add(new Obstacle((string) obstacle["name"]));
        }
        JsonData requiredSkillData = questData["requiredSkills"];
        //todo
        JsonData questTypeData = questData["questTypes"];
        foreach (JsonData questType in questTypeData) {
            questTypes.Add(new QuestType((string) questType["name"], (int) questType["baseXp"], (int) questType["baseGold"], (JsonData) questType["questNames"]));
        }
    }
    
    public int GetRandomQuestTypeId() {
        return UnityEngine.Random.Range(0, questTypes.Count - 1);
    }

    public List<int> GetRandomObstacleIds(int numObstacles) {
        List<int> obstacleIds = new List<int>();
        //todo: 
        obstacleIds.Add(1);

        return obstacleIds;
    }

    public List<int> GetRandomRequiredSkillIds(int numRequiredSkills) {
        List<int> requiredSkillIds = new List<int>();
        //todo: 
        requiredSkillIds.Add(1);

        return requiredSkillIds;
    }

    public void Refresh() {
        Guild guild = GameManager.guild;
        int guildRating = guild.GetGuildRating();
        thisWeekQuests = new List<Quest>();
        for (int i = 0; i < guild.GetQuestsPerWeek(); i++) {
            thisWeekQuests.Add(new Quest(guildRating));
        }

    }
}
