using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Items
{
    public string Name;
    public string Description;
    public int ID;
    public GameObject Model;
}
public enum EquippedWeapons
{
    dagger,
    shotgun,
    AK47
}
public class GameManager : MonoBehaviour
{
    [Header("Player_Stats")]
    public float baseDamage;
    public float finalDamage;

    [Header("Weapons_Equipped")]
    public EquippedWeapons equippedWeapons;

    [Header("Exp")]
    public float ExpToAdd;
    public int currentLvl;
    public float currentExp;
    float maxExp;
    public int playerLevel;

    [Header("ItemsList")]
    [SerializeField]
    private List<Items> itemList = new();

    public List<Items> ItemList
    {
        get { return itemList; }
    }

    private void OnValidate()
    {
        #region WeaponEquipped
        Weapon weapon = new Weapon();


        switch (equippedWeapons)
        {
            case EquippedWeapons.AK47:
                finalDamage = baseDamage + weapon.Damage_AK47;
                break;
            case EquippedWeapons.dagger:
                finalDamage = baseDamage + weapon.Damage_dagger;
                break;
            case EquippedWeapons.shotgun:
                finalDamage =baseDamage + weapon.Damage_shotgun;
                break;
            default:
                break;
        }
        #endregion
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            DamagePowerUp_Concentration();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            DamagePowerUp_Focus();
        }
    }

    #region lastweek
    private void BoostUpPowerUp()
    {
        DamagePowerUp dmgPowerUp = new DamagePowerUp();
        finalDamage += dmgPowerUp.BoostUp;
    }

    public void BerserkPowerUp()
    {
        DamagePowerUp dmgPowerUp = new DamagePowerUp();
    }
    #endregion

    public void DamagePowerUp_Focus()
    {
        DamagePowerUp dmgPowerUp = new DamagePowerUp();
        finalDamage += dmgPowerUp.Focus;
    }

    public void DamagePowerUp_Concentration()
    {
        DamagePowerUp dmgPowerUp = new();
        float powerUpDamage = (finalDamage * dmgPowerUp.Concentration)/ 100;
        finalDamage = powerUpDamage + finalDamage;
    }

    public void ResetValues()
    {
        Weapon weapon = new Weapon();


        switch (equippedWeapons)
        {
            case EquippedWeapons.AK47:
                finalDamage = baseDamage + weapon.Damage_AK47;
                break;
            case EquippedWeapons.dagger:
                finalDamage = baseDamage + weapon.Damage_dagger;
                break;
            case EquippedWeapons.shotgun:
                finalDamage = baseDamage + weapon.Damage_shotgun;
                break;
            default:
                break;
        }
    }

    public void ExpSystem()
    {
        ExpHandler addExp = new ExpHandler();
        playerLevel = addExp.CurrentLvl;
        maxExp = addExp.MaxExp;
        currentExp = addExp.CurrentExp;
    }
    public void AddExp(float experienceToAdd)
    {
        experienceToAdd = ExpToAdd;
        currentExp += experienceToAdd;
        if (currentExp >= maxExp)
        {
            LevelUp();
        }
    }
    public void LevelUp()
    {
        currentLvl++;
        currentExp = 0;
        maxExp *= 1.5f; //increase maxExp by 50% each level
    }
}
