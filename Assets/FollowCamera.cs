using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField]GameObject entityToFollow;

    void LateUpdate()
    {
        transform.position = entityToFollow.transform.position + new Vector3(0,0,-10);
    }
}
