using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Agent
{
    protected override void Start()
    {
        base.Start();
        dir = transform.right * - 1;
    }

    protected override void Update()
    {
        base.Update();
        
    }
}
