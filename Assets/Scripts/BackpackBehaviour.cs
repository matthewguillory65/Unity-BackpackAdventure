using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackBehaviour : MonoBehaviour {

    public Backpack m_Backpack;
    
    public int Capacity;

    public List<Item> Inventory;

	// Use this for initialization
	void Start ()
    {
        Capacity = m_Backpack.m_Capacity;
        Inventory = new List<Item>();
        foreach (var it in m_Backpack.m_Items)
        {
            AddItem(it);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void RemoveItem(Item item)
    {
        if (!Inventory.Contains(item)) return;
        if (Inventory.Count == 0) return;
        Inventory.Remove(item);
    }
}
