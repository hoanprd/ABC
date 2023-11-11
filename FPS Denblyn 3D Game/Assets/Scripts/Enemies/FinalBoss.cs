using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalBoss : MonoBehaviour
{
    SoldierAI003 AI003;
    EnemyDeath ED;
    [SerializeField] private Renderer myObject;
    public GameObject FBHPDisplay;
    public Transform player;
    public Transform FinalB;
    public float MoveSpeed = 4f;
    //public Rigidbody rb;
    private Vector3 movement;
    //public int move;

    // Start is called before the first frame update
    void Start()
    {
        //rb = this.GetComponent<Rigidbody>();
        FBHPDisplay.SetActive(true);
        myObject.material.color = Color.blue;
        AI003 = FindObjectOfType<SoldierAI003>();
        ED = FindObjectOfType<EnemyDeath>();
    }

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
        //FBHPDisplay.GetComponent<Text>().text = "Boss: " + ED.enemyHealth + "/200";
    }

    private void FixedUpdate()
    {
        MoveCharacter(movement);
    }

    void MoveCharacter(Vector3 direction)
    {
        //rb.MovePosition((Vector3)transform.position + (direction * MoveSpeed * Time.deltaTime));
        if (AI003.lookingAtPlayer == true)
            FinalB.position = new Vector3(FinalB.position.x + (direction.x * MoveSpeed * Time.deltaTime), FinalB.position.y, FinalB.position.z + (direction.z * MoveSpeed * Time.deltaTime));
    }
}
