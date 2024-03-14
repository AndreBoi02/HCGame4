using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public void move2(Vector2 dir, float speed) {
        transform.Translate(dir * speed * Time.deltaTime);
    }

    public void rotate(GameObject obj, float way2go) {
        obj.transform.localRotation = Quaternion.Euler(0, 0, 0);
        obj.transform.localRotation = Quaternion.Euler( 0, 0, 45 * way2go);
    }
}
