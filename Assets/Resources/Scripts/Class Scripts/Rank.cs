using System;
using System.Collections.Generic;

public class Rank {
    public string name;
    public int modifier;
    public int numObstacles;
    public int numRequiredSkills;
    public int baseDuration;

    public Rank(string name, int modifier, int numObstacles, int numRequiredSkills, int baseDuration) {
        this.name = name;
        this.modifier = modifier;
        this.numObstacles = numObstacles;
        this.numRequiredSkills = numRequiredSkills;
        this.baseDuration = baseDuration;
    }
}
