using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class EnemyStats : MonoBehaviour {

    public GameObject[] enemyList;
    public GameObject wolf;
    public GameObject viking;
    public GameObject villager;
    public GameObject lynx;
    public GameObject troll;
    public GameObject dwarf;
    public GameObject bear;
    public GameObject boar;
    public GameObject soldier;


    //int enemyPickInt = (int)enemyPick;
    //return enemyPickInt;
    //Debug.Log(enemyPickInt);

    void regEnemyPicker()
    {
        enemyList = new GameObject[8];
        enemyList[0] = wolf;
        enemyList[1] = viking;
        enemyList[2] = villager;
        enemyList[3] = lynx;
        enemyList[4] = troll;
        enemyList[5] = dwarf;
        enemyList[6] = bear;
        enemyList[7] = boar;
        enemyList[8] = soldier;

        GameObject currentEnemy = enemyList[Random.Range(0, enemyList.Length)];

        Debug.Log(currentEnemy);
    }

	// Use this for initialization
	void Start () {
        int enemyPick = Random.Range(0, 8);

        /*enemyList = new GameObject[9];
        enemyList[0] = wolf;
        enemyList[1] = viking;
        enemyList[2] = villager;
        enemyList[3] = lynx;
        enemyList[4] = troll;
        enemyList[5] = dwarf;
        enemyList[6] = bear;
        enemyList[7] = boar;
        enemyList[8] = soldier;

        GameObject currentEnemy = enemyList[Random.Range(0, enemyList.Length)];

        Debug.Log(currentEnemy);*/

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
