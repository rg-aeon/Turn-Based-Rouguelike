using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;


public class OnClick : MonoBehaviour {

    public static float EnemyHP;
    public static float PlayerAtt;

    [SerializeField]
    private Button attackButton;

    // Use this for initialization
    void Start () {
        Button attack = attackButton.GetComponent<Button>();
        attack.onClick.AddListener(onAttack);
    }

    void onAttack()
    {
        EnemyHP = EnemyStats.enemyHP;
        PlayerAtt = PlayerStats.attack;
        EnemyHP = EnemyHP - PlayerAtt;
        Debug.Log("Player Attack");
    }

    // Update is called once per frame
    void Update () {
	
	}
}
