using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Equipment", menuName = "Item/Equipment")]

public class Equipment : Items
{
    public int Damage;
    public float RangeDamage;
    public float DamageReduction;
    public int Heal;
    public float RangeHeal;
}
