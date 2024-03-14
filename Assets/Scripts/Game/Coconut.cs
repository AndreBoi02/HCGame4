using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coconut : Agent
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {  
        int dir = 0;
        if (collision.gameObject.CompareTag("Zombie"))
        {
            int ran;
            ran = Random.Range(0, 2);
            if (ran == 0)
            {
                dir = 1;
            }
            else
            {
                dir = -1;
            }
            mov.rotate(gameObject, dir);
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            if (gameObject.transform.position.y > 2)
            {
                dir = -1;
            }
            else
            {
                dir = 1;
            }
            mov.rotate(gameObject, dir);
        }
    }
}
