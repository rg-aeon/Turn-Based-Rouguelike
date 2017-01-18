using UnityEngine;
using System.Collections;

public class playerStats : MonoBehaviour {
    int baseAttack = 10;
    int baseDefense = 10;
    new public float attack;
    new public float defense;

    new public float defIncreasePerLevel;
    new public float attIncreasePerLevel;

    void StatsChanges ()
    {
        defIncreasePerLevel = defense / 7;
        attIncreasePerLevel = attack / 7;
    }

    void OnLevelUp ()
    {
        attack += attIncreasePerLevel;
        defense += defIncreasePerLevel;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
