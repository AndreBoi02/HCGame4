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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            
        }
    }
}
