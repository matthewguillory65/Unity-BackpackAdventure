using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour {

    public Item m_ItemConfig;

    Item runtimeItem;

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
            collision.GetComponent<BackpackBehaviour>().AddItem(runtimeItem);
            Destroy(gameObject);
        }
    }

}
