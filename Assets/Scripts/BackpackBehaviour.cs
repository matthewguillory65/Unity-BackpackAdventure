using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackBehaviour : MonoBehaviour {

    public Backpack m_Backpack;

    Backpack runtimeBackpack;

	// Use this for initialization
	void Start ()
    {
        runtimeBackpack = Instantiate(m_Backpack);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void AddItem(Item item)
    {
        m_Backpack.m_Items.Add(item);
    }
}
