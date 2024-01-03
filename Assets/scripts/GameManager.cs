using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum eEquippedWeapons
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
    public eEquippedWeapons equippedWeapons;


    private void OnValidate()
    {
        #region Weapon Equipped
        Weapon weapon = new Weapon();


        switch (equippedWeapons)
        {
            case eEquippedWeapons.AK47:
                finalDamage = baseDamage + weapon.Damage_AK47;
                break;
            case eEquippedWeapons.dagger:
                finalDamage = baseDamage + weapon.Damage_dagger;
                break;
            case eEquippedWeapons.shotgun:
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
            BoostUpPowerUp();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            BerserkPowerUp();
        }
    }

    private void BoostUpPowerUp()
    {
        DamagePowerUp dmgPowerUp = new DamagePowerUp();
        finalDamage += dmgPowerUp.BoostUp;
    }

    public void BerserkPowerUp()
    {
        DamagePowerUp dmgPowerUp = new DamagePowerUp();
    }

}
