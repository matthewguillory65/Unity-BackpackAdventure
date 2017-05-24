using System;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Backpack Saver", menuName = "GameState/Savers/Backpack Saver", order = 1)]
public class BackpackSaver : ScriptableObject {
    private static BackpackSaver _instance;
    public static BackpackSaver Instance
    {
        get
        {
            if (!_instance)
                _instance = Resources.FindObjectsOfTypeAll<BackpackSaver>().FirstOrDefault();
            if (!_instance)
                _instance = CreateInstance<BackpackSaver>();
            return _instance;
        }
    }

    public void SaveBackpack(Backpack backpack, string filename)
    {
        var path = Application.dataPath + "/StreamingAssets/" + filename + ".json";
        var json = JsonUtility.ToJson(backpack, true);
        System.IO.File.WriteAllText(path, json);
        Debug.Log("Saved " + filename + "!");
    }

    public void TestIt()
    {
        Debug.Log("singleton is up");
    }

}
