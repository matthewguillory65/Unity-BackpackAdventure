using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour {

    public GameObject itemObject;
    public LootTable table;
    public float timeUntilSpawn = 5;

	void Start () {
        StartCoroutine(Spawn());
	}
	
	IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeUntilSpawn);
            GameObject newItem = Instantiate(itemObject);
            newItem.GetComponent<ItemBehaviour>().m_ItemConfig = table.Roll()[0];
        }
    }
}
