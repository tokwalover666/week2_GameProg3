using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon 
{
    int damage_dagger = 10;
    int damage_shotgun = 30;
    int damage_AK47 = 15;


    public int Damage_dagger
    {
        get { return damage_dagger; } 
        set {damage_dagger = value; }
    }
    public int Damage_shotgun
    {
        get { return damage_shotgun; }
        set { damage_shotgun = value; }
    }
    public int Damage_AK47
    {
        get { return damage_shotgun; }
        set { damage_AK47 = value; }
    }

}

public class DamagePowerUp
{

    //percentage powerUps
    float concentration = 10;

    //baseDamage powerUps
    int focus = 20;

    public float Concentration
    {
        get { return concentration; }
        set { concentration = value; }
    }
    public int Focus
    {
        get { return focus; }
        set { focus = value; }
    }


    #region lastweek
    float boostUp = 5;

    //Percentage Values

    public float BoostUp
    {
        get { return boostUp; }
        set { boostUp = value; }
    }
    //Base Values

    float Berserk;

    public float BoostBerserk
    {
        get { return Berserk; }
        set { Berserk = value; }
    }
    #endregion
}
