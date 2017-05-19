using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSaveJson : MonoBehaviour
{

    [System.Serializable]
    public class PlayerInfo
    {
        public int Health;
        public int Guts;
        public int Intelligence;
        public int Charisma;
    }

    [SerializeField]
    PlayerInfo player;

	// Use this for initialization
	void Start ()
    {
        var info = new PlayerInfo() { Health = 5, Guts = 5, Intelligence = 5, Charisma = 5 };
        player = info;
        Save();
	}

    string path;

	public void Save()
    {
        path = Application.dataPath + "/Saves/PlayerInfo/";
        string filename = "playerinfo.json";
        var json = JsonUtility.ToJson(player, true);
        System.IO.File.WriteAllText(path + filename, json);
    }
}
