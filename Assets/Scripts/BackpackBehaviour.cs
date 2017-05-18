using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BackpackBehaviour : MonoBehaviour {

    public Backpack m_Backpack;
    public GameObject m_ItemPrefab;
    public float m_DropDistance; //Distance from player that this drops the item
    
    public int Capacity;

    public List<Item> Inventory;


    [System.Serializable]
    public class OnBackpackChange : UnityEvent<Item>
    {

    }

    public OnBackpackChange onBackpackChange;

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
        if (Input.GetAxis("Fire1") == 1 && Inventory.Count > 0)
            RemoveItem(Inventory[0]);
	}

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void RemoveItem(Item item)
    {
        if (!Inventory.Contains(item)) return;
        if (Inventory.Count == 0) return;
        GameObject droppedItem = Instantiate(m_ItemPrefab);
        droppedItem.transform.position = this.transform.position + new Vector3(m_DropDistance, 0);
        droppedItem.GetComponent<ItemBehaviour>().m_ItemConfig = item;
        droppedItem.transform.parent = null;
        Inventory.Remove(item);
    }
}