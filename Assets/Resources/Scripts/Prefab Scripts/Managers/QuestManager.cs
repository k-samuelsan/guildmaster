using LitJson;
using System;
using System.Collections.Generic;

public class QuestManager {
    public List<Rank> ranks;
    public List<QuestType> questTypes;
    List<Obstacle> obstacles;

    public QuestManager(JsonData questData) {

    }
    
    public int GetRandomQuestTypeId() {
        return UnityEngine.Random.Range(0, questTypes.Count - 1);
    }

    public List<int> GetRandomObstacleIds(int numObstacles) {
        List<int> obstacleIds = new List<int>();
        //todo: 
        return obstacleIds;
    }

    internal List<int> GetRandomRequiredSkillIds(int numRequiredSkills) {
        List<int> requiredSkillIds = new List<int>();
        //todo: 
        return requiredSkillIds;
    }
}
