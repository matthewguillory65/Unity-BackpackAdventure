using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBackpackLoader : MonoBehaviour {

    public Backpack backpack = null;
    public string fileName = "default-backpack";

	// Use this for initialization
	void Start ()
    {
        UnityEngine.Assertions.Assert.IsNull(backpack);
        backpack = null;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.F))
            backpack = BackpackLoader.Instance.LoadBackpack(fileName);
	}
}
