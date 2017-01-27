using UnityEngine;
using System.Collections;

public class playerStats : MonoBehaviour {
    int baseAttack = 10;
    int baseDefense = 10;
    public float attack;
    public float defense;

    public float defIncreasePerLevel;
    public float attIncreasePerLevel;

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
