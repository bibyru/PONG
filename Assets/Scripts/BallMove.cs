using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    Rigidbody2D rigid;

    float speed = .5f;

    float GetRandDir() {
        return Random.Range(-1f,1f);
    }

    void Start() {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = new Vector2(GetRandDir(), GetRandDir()) * speed;
    }
}
