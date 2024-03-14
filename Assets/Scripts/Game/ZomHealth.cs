using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZomHealth : MonoBehaviour
{
    private int health = 0;

    public void setHealth(int Health)
    {
        health = Health;
    }

    public void setHealth()
    {
        health = Random.Range(1,3);
    }

    public void takeDamage(int dmg)
    {
        health -= dmg;
    }

    public void death()
    {
        if (health > 0) return;
        //Call PoolObject
        print("Dead XD");
        gameObject.SetActive(false);
    }
}
