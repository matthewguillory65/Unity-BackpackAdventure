using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBackpackSaver : MonoBehaviour {

    public Backpack backpack;
    public string fileName = "default-backpack";

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.Assertions.Assert.IsNotNull(backpack, "Assign a backpack...");
            BackpackSaver.Instance.SaveBackpack(backpack, fileName);
        }
	}
}
