using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public abstract class Item : ScriptableObject
{
    protected string m_ItemName;
    protected int GUID;
    public Sprite m_Sprite;
}

public abstract class Weapon : Item
{
    protected string prefixid = "001";
    public int m_Damage;
    public abstract void Initialize();

}