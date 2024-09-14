using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class Bird : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapStrength;  
    public LogicManager logic;
    public bool birdIsAlive = true;
    public SpriteRenderer spriteR;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myrigidbody.velocity = Vector2.up * flapStrength;
        }
        if (transform.position.y > 5 || transform.position.y < -5){
            logic.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collide)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
