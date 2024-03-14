using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Agent
{
    ZomHealth zomHp;
    protected override void Start()
    {
        base.Start();
        dir = transform.right * - 1;
        zomHp = GetComponent<ZomHealth>();
        zomHp.setHealth(3);
    }

    protected override void Update()
    {
        base.Update();
        zomHp.death();
    }

    private void OnTriggerEnter2D(Collider2D collision)
{
        if (collision.gameObject.CompareTag("Coconut"))
        {
            print("Hit");
            zomHp.takeDamage(1);
        }
    }
}
