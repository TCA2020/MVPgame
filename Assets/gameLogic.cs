using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gameLogic : MonoBehaviour
{
    [SerializeField] private Rigidbody2D mine;
    [SerializeField] private float mSpeed = 5.0f;

    private MVPmodel subm = new MVPmodel();
   
    void Start()
    {
       
    }

    
    void FixedUpdate()
    {
        mine.velocity = Vector2.left * mSpeed;       
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Player collided with " + other.name);
        //mSpeed *= -1;
        subm.HpDmg(10);
    }
}
