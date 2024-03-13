using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    protected Movement mov;
    [SerializeField] protected float speed = 1f;
    protected Vector2 dir = Vector2.zero;

    protected virtual void Start()
    {
        mov = GetComponent<Movement>();
        dir = transform.right;
    }

    protected virtual void Update()
    {
        mov.move2(dir, speed);
    }
}
