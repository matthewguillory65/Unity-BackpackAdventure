using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class LootTable : ScriptableObject
{
    [System.Serializable]
    public class ItemChance
    {
        public Item theItem;
        [Range(0,1)]
        public float chance;
    }

    [SerializeField]
    public List<ItemChance> itemList;

    public List<Item> Roll()
    {
        float theRoll = Random.Range(0f, 1f);
        List<Item> droppedItems = new List<Item>();

        foreach (var i in itemList)
            if (i.chance > theRoll)
                droppedItems.Add(i.theItem);

        return droppedItems;
    }
}