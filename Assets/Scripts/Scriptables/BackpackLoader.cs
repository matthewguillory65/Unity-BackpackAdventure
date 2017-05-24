using System;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Backpack Loader", menuName = "GameState/Savers/Backpack Loader", order = 1)]
public class BackpackLoader : ScriptableObject
{
    private static BackpackLoader _instance;
    public static BackpackLoader Instance
    {
        get
        {
            if (!_instance)
                _instance = Resources.FindObjectsOfTypeAll<BackpackLoader>().FirstOrDefault();
            if (!_instance)
                _instance = CreateInstance<BackpackLoader>();
            return _instance;
        }
    }

    public Backpack LoadBackpack(string filename)
    {
        var path = Application.dataPath + "/StreamingAssets/" + filename + ".json";
        var json = System.IO.File.ReadAllText(path);
        var backpack = CreateInstance<Backpack>();
        JsonUtility.FromJsonOverwrite(json, backpack);
        UnityEngine.Assertions.Assert.IsNotNull(backpack);
        Debug.Log("Loaded " + filename + "!");
        return backpack;
    }

    public void TestIt()
    {
        Debug.Log("singleton is up");
    }

}

