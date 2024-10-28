using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public enum enemyMovementstate
{
   
    
    Patrol,
    Engage
}
public class enemyMovement : MonoBehaviour
{
    enemyMovementstate _currentState = enemyMovementstate.Patrol;
    private Rigidbody2D rb;
    
   
    int enemyspeed = 1;
    bool isFaceingRight = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Patrol()
    {
        enemyMove();

    }

    void enemyMove()
    {
        if (isFaceingRight) rb.velocity = new Vector2(enemyspeed, 0);
        else rb.velocity = new Vector2(-enemyspeed, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EdgeCollider"))
        {
            
        }
    }
}
