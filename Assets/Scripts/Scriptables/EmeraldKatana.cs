using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Weapon/EmeraldKatana")]
public class EmeraldKatana : Weapon
{
    public override void Initialize()
    {
        GUID += GetHashCode();
    }
}