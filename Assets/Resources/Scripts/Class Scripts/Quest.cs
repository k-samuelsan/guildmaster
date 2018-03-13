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
    int energyCost;

    public Quest() { }

    public Quest(int guildRating) {

    }
}
