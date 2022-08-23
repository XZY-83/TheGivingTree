using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{  
    public Transform target;
    public Vector3 cameraPos;

    [Space(10f)]
    public float cameraSpeed = 10f;
    
    Vector3 TargetPos;
    
    void FixedUpdate()
    {
        //플레이어 위치 + 타겟으로부터의 카메라 위치
        TargetPos = new Vector3(target.position.x+cameraPos.x
                                , target.position.y + cameraPos.y
                                , target.position.z + cameraPos.z);

        //선형보간하여 카메라에 적용
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * cameraSpeed);
    }
}
