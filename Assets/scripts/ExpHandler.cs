using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpHandler
{
    int currentLvl;
    float currentExp;
    float maxExp;

    public int CurrentLvl
    {
        get { return CurrentLvl; }
        set { CurrentLvl = value; }
    }
    public float CurrentExp
    {
        get { return CurrentExp; }
        set { CurrentExp = Mathf.Clamp(value, 0f, maxExp); }
    }
    public int MaxExp
    {
        get { return MaxExp; }
        set { MaxExp = value; }
    }
    public void GainExperience(float experienceToAdd)
    {
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
