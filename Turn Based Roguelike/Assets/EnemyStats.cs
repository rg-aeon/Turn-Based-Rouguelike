using UnityEngine;
using System.Collections;

public class EnemyStats : MonoBehaviour {

    public string[] enemyList;
    int enemyPick = Random.Range(0, 9);
    Random getRandom = new Random();



    //int enemyPickInt = (int)enemyPick;
    //return enemyPickInt;
    //Debug.Log(enemyPickInt);

    void regEnemyPicker ()
    {
        enemyList = new string[9];
        enemyList[0] = "Wolf";
        enemyList[1] = "Bear";
        enemyList[2] = "Viking";
        enemyList[3] = "Giant Snake";
        enemyList[4] = "Farmer";
        enemyList[5] = "Wild Dog";
        enemyList[6] = "Lynx";
        enemyList[7] = "Polar Bear";
        enemyList[8] = "";
        enemyList[9] = "";
       foreach (string enemyList in enemyList)
        {
            
        }
    }

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
