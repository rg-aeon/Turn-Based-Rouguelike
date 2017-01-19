using UnityEngine;
using System.Collections;

public class EnemyStats : MonoBehaviour {

    ArrayList enemyList;
    int enemyPick;
    Random getRandom = new Random();


    void regEnemyPicker ()
    {
        enemyPick = Random.Range(0, 10);
        //int enemyPickInt = (int)enemyPick;
        //return enemyPickInt;
        //Debug.Log(enemyPickInt);

    }

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
