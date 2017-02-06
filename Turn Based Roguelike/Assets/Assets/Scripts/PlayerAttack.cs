using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

    public static float EnemyHP;
    public static float PlayerAtt;

    void onAttack()
    {
        EnemyHP = EnemyStats.enemyHP;
        PlayerAtt = PlayerStats.attack;
        EnemyHP = EnemyHP - PlayerAtt;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
