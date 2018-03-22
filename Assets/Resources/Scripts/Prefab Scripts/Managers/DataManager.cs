using LitJson;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager {
    static DataManager dataManager;
    public QuestManager questManager;
    public List<CharacterClass> classDatabase = new List<CharacterClass>();
    public Dictionary<string, List<string>> keywordDatabase = new Dictionary<string, List<string>>();

    private DataManager() {
        ConstructClassDB();
        ConstructQuestManager();
    }

    void ConstructQuestManager() {
        JsonData questData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/QuestData.json"));
        questManager = new QuestManager(questData);
    }

    void ConstructClassDB()
    {
        JsonData classData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/ClassData.json"));
        for (int i = 0; i < classData.Count; i++) {
            classDatabase.Add(new CharacterClass((string)classData[i]["name"], (int)classData[i]["id"], (string)classData[i]["sprite"]));
        }
    }

    public static DataManager GetInstance() {
        if (dataManager == null) {
            dataManager = new DataManager();
        }
        return dataManager;
    }
	
}
