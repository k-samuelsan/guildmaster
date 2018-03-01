using LitJson;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JsonManager {
    static JsonManager jsonManager;
    public List<CharacterClass> classDatabase = new List<CharacterClass>();

    private JsonManager() { }

    public void init() {
        ConstructClassDB();
    }

    void ConstructClassDB()
    {
        JsonData json = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/CharClass.json"));
        for (int i = 0; i < json.Count; i++) {
            classDatabase.Add(new CharacterClass((string)json[i]["name"], (int)json[i]["id"], (string)json[i]["sprite"]));
        }
    }

    public static JsonManager getInstance() {
        if (jsonManager == null) {
            jsonManager = new JsonManager();
        }
        return jsonManager;
    }
	
}
