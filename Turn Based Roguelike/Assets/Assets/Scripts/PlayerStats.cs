﻿using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour
{
    public float baseAttack = 10;
    public float baseDefense = 10;
    public float baseHP = 40;
    public static float attack;
    public static float defense;
    public static float hp;

    public float defIncreasePerLevel;
    public float attIncreasePerLevel;
    public float healthIncreasePerLevel;

    void StatsChanges()
    {
        baseAttack = attack;
        baseDefense = defense;
        baseHP = hp;
        defIncreasePerLevel = defense / 7;
        attIncreasePerLevel = attack / 7;
        healthIncreasePerLevel = hp / 7;
    }

    void OnLevelUp()
    {
        attack += attIncreasePerLevel;
        defense += defIncreasePerLevel;
        hp += healthIncreasePerLevel;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
