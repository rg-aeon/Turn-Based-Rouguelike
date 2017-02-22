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

    public static float enemyAttack = 0;
    public static float enemyDefense = 0;
    public static float enemyHP = 0;
    public static float dmgTaken = 0;

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

    void spawnEnemy()
    {
        foreach (GameObject gameObject in enemyList)
        {
            if (gameObject == wolf)
            {
                enemyAttack = 5;
                enemyDefense = 5;
                enemyHP = 20;
            }
            if (gameObject == viking)
            {
                enemyAttack = 10;
                enemyDefense = 7;
                enemyHP = 20;
            }
            if (gameObject == villager)
            {
                enemyAttack = 3;
                enemyDefense = 3;
                enemyHP = 15;
            }
            if (gameObject == lynx)
            {
                enemyAttack = 7;
                enemyDefense = 7;
                enemyHP = 23;
            }
            if (gameObject == troll)
            {
                enemyAttack = 12;
                enemyDefense = 14;
                enemyHP = 30;
            }
            if (gameObject == dwarf)
            {
                enemyAttack = 10;
                enemyDefense = 15;
                enemyHP = 27;
            }
            if (gameObject == bear)
            {
                enemyAttack = 8;
                enemyDefense = 9;
                enemyHP = 26;
            }
            if (gameObject == boar)
            {
                enemyAttack = 7;
                enemyDefense = 12;
                enemyHP = 15;
            }
            if (gameObject == soldier)
            {
                enemyAttack = 12;
                enemyDefense = 12;
                enemyHP = 15;
            }
        }
    }

	// Use this for initialization
	void Start () {
        

    }
	
	 //Update is called once per frame
	void Update () {
        
        }

    }



