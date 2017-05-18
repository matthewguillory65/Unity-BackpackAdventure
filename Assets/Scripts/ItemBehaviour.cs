using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemBehaviour : MonoBehaviour {

    public Item m_ItemConfig;

    Item runtimeItem;

    [System.Serializable]
    public class OnItemChange : UnityEvent
    {

    }

    public OnItemChange onItemChange;

	// Use this for initialization
	void Start ()
    {
        runtimeItem = Instantiate(m_ItemConfig);
        GetComponent<SpriteRenderer>().sprite = runtimeItem.m_Sprite;
        GetComponent<BoxCollider2D>().size = GetComponent<SpriteRenderer>().sprite.bounds.size;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            BackpackBehaviour thebackpack = collision.GetComponent<BackpackBehaviour>();
            if (thebackpack.Inventory.Count < thebackpack.Capacity && Input.GetAxisRaw("Fire2") == 1)
            {
                thebackpack.AddItem(m_ItemConfig);
                Destroy(gameObject);
            }
        }
    }

}
