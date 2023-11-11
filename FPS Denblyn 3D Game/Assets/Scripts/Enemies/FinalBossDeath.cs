using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalBossDeath : MonoBehaviour
{
    public int enemyHealth = 0;
    public bool enemyDead = false;
    public Text FBHPDisplay;
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
            GlobalScore.scoreValue += 1000;
            GlobalComplete.killsCount += 1;
            GlobalWeapons.Original = 0;
            GlobalComplete.nextFloor = 3;
            SceneManager.LoadScene(13);
        }
        FBHPDisplay.text = "Boss: " + enemyHealth + "/200";
    }
    void DamageEnemy(int damageAmount)
    {
        enemyHealth -= damageAmount;
        show = enemyHealth;
    }
}
