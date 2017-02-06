using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

    public static float playerHP;
    public static float playerAtt;

	// Use this for initialization
	void Start () {
        playerHP = PlayerStats.hp;
        playerAtt = EnemyStats.enemyAttack;
        playerHP = playerHP - playerAtt;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
