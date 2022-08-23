using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    Vector3 velocity;
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 vel)
    {
        velocity = vel;
    }

    public void FixedUpdate()
    {
        //(현재위치 + 이동 속도 * 단위시간)
        rigid.MovePosition(rigid.position + velocity * Time.fixedDeltaTime);
    }

}
