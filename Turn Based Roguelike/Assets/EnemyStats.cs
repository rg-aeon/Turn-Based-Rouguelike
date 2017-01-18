using UnityEngine;
using System.Collections;

public class EnemyStats : MonoBehaviour {

    new ArrayList enemyList;
    new int enemyPick;
    Random getRandom = new Random();

    void RegEnemyPicker ()
    {
        enemyPick = getRandom.Next(0, 10);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
