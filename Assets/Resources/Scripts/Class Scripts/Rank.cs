using System;
using System.Collections.Generic;

public class Rank {
    public string name;
    public double modifier;
    public int numObstacles;
    public int numRequiredSkills;

    Rank(string name, double modifier, int numObstacles, int numRequiredSkills) {
        this.name = name;
        this.modifier = modifier;
        this.numObstacles = numObstacles;
        this.numRequiredSkills = numRequiredSkills;
    }
}
