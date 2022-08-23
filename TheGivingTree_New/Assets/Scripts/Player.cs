using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    PlayerController controller;

    void Start()
    {
        controller = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //방향에 대한 입력 받기
        //GetAxisRaw >> -1,0,1의 값 반환 (즉시 반응) / GetAxis >> -1~1 값 반환 (부드럽게)
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        //벡터 방향값 * 이동 속도
        Vector3 moveVelocity = moveInput.normalized * moveSpeed;

        controller.Move(moveVelocity);
    }
}
