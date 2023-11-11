using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int enemyHealth = 0;
    public bool enemyDead = false;
    public GameObject enemyAI;
    public GameObject theEnemy;
    public int show;

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0 && enemyDead == false)
        {
            enemyDead = true;
            theEnemy.GetComponent<LookPlayer>().enabled = false;
            enemyAI.SetActive(false);
            GlobalScore.scoreValue += 100;
            GlobalComplete.killsCount += 1;
            //Destroy(theEnemy);
            theEnemy.SetActive(false);
        }
    }
    void DamageEnemy(int damageAmount)
    {
        enemyHealth -= damageAmount;
        show = enemyHealth;
    }
}
