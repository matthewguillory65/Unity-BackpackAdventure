﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Backpack")]
public class Backpack : ScriptableObject {

    public List<Item> m_Items = new List<Item>();
    public int m_Capacity;

}
