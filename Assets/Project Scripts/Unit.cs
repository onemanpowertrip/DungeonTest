using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;
    public int unitLevel;
    public int perception;
    public int armorClass;
    public int currentHP;
    public int maxHP;
    public int meleeAttackBonus;
    public int rangedAttackBonus;
    public int spellAttackBonus;
    public int meleeDamage;
    public int rangedDamage;
    public int speed;

   public bool TakeDamage(int dmg)
    {
        currentHP -= dmg;

        if (currentHP <= 0)
            return true;
        else
            return false;
    }

    public void Heal(int amountHealed)
    {
        currentHP += amountHealed;
        if (currentHP > maxHP)
            currentHP = maxHP;
    }
}
