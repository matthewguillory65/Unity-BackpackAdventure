using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BackpackBehaviour : MonoBehaviour {

    public Backpack m_Backpack;
    public GameObject m_ItemPrefab;
    public float m_DropDistance; //Distance from player that this drops the item
    [HideInInspector]
    public bool AcceptingItems = false;
    
    public int Capacity;

    public List<Item> Inventory;

	// Use this for initialization
	void Start ()
    {
        Capacity = m_Backpack.m_Capacity;
        Inventory = new List<Item>();
        foreach (var it in m_Backpack.m_Items)
            AddItem(it);
        //LoadInventory();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Z) && Inventory.Count > 0)
            RemoveItem(Inventory[0]);
        if (Input.GetKey(KeyCode.L) && Inventory.Count > 0)
            RemoveItem(Inventory[0]);
        if (Input.GetKeyDown(KeyCode.S))
            SaveInventory();
        if (Input.GetKeyDown(KeyCode.A))
            LoadInventory();

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            m_DropDistance = -Mathf.Abs(m_DropDistance);

        if (Input.GetKeyDown(KeyCode.RightArrow))
            m_DropDistance = Mathf.Abs(m_DropDistance);

        if (Input.GetKey(KeyCode.X))
            AcceptingItems = true;
        else
            AcceptingItems = false;
	}

    //Add item to inventory
    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    //Remove item and set it down
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

    //Save this backpack
    void SaveInventory()
    {
        Backpack inventorySave = ScriptableObject.CreateInstance<Backpack>();
        inventorySave.m_Items = Inventory;
        BackpackSaver.Instance.SaveBackpack(inventorySave, "Inventory");
    }

    void LoadInventory()
    {
        Inventory = BackpackLoader.Instance.LoadBackpack("Inventory").m_Items;
    }
}