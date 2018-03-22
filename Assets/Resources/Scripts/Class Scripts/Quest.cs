using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest {
    string questName;
    int rankId;
    int goldReward;
    int xpReward;
    ArrayList otherRewards;
    int questTypeId;
    List<int> obstacleIds;
    List<int> requiredSkillIds;
    int duration;
 //   int energyCost;

    public Quest() { }

    public Quest(int guildRating) {
        QuestManager questManager = DataManager.GetInstance().questManager;
        int numRanks = questManager.ranks.Count;
        if (guildRating == Constants.MAX_GUILD_RATING) {
            rankId = numRanks - 1;
        } else {
            int interval = Constants.MAX_GUILD_RATING / numRanks;
            rankId = guildRating / interval;
        }
        Rank rank = questManager.ranks[rankId];
        questTypeId = questManager.GetRandomQuestTypeId();
        QuestType questType = questManager.questTypes[questTypeId];
        goldReward = (int)((Convert.ToDouble(questType.baseGold)) * rank.modifier);
        xpReward = (int)((Convert.ToDouble(questType.baseXp)) * rank.modifier);
        obstacleIds = questManager.GetRandomObstacleIds(rank.numObstacles);
        requiredSkillIds = questManager.GetRandomRequiredSkillIds(rank.numRequiredSkills);
        duration = rank.baseDuration;
        questName = questType.GetRandomQuestName(DataManager.GetInstance().keywordDatabase);
    }
}
