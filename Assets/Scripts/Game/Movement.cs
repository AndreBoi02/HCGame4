using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    void move2(Vector2 dir, float speed){
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
