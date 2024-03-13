using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class LawnMower : Agent
{
    private bool isActive = false;
    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        if (isActive)
        {
            mov.move2(dir, speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Zombie"))
        {
            isActive = true;
            Destroy(collision.gameObject);
        }
    }
}
