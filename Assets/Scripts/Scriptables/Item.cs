using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public abstract class Item : ScriptableObject
{
    public string m_ItemName = "New Item";
    public Sprite m_Sprite;
}

public abstract class Weapon : Item
{
    public int m_Damage;

}