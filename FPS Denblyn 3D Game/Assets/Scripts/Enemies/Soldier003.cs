using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier003 : MonoBehaviour
{
    SoldierAI003 AI003;
    [SerializeField] private Renderer myObject;
    public Transform player;
    public Transform s003;
    public float MoveSpeed = 4f;
    //public Rigidbody rb;
    private Vector3 movement;
    //public int move;

    // Start is called before the first frame update
    void Start()
    {
        //rb = this.GetComponent<Rigidbody>();
        myObject.material.color = Color.blue;
        AI003 = FindObjectOfType<SoldierAI003>();
    }

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        MoveCharacter(movement);
    }

    void MoveCharacter(Vector3 direction)
    {
        //rb.MovePosition((Vector3)transform.position + (direction * MoveSpeed * Time.deltaTime));
        if (AI003.lookingAtPlayer == true)
            s003.position = new Vector3(s003.position.x + (direction.x * MoveSpeed * Time.deltaTime), s003.position.y, s003.position.z + (direction.z * MoveSpeed * Time.deltaTime));
    }
}
