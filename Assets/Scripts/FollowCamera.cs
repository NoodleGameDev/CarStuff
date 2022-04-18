using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] private GameObject followedObject;

    void LateUpdate()
    {
        Vector3 newPosition = new Vector3(
            followedObject.transform.position.x, 
            followedObject.transform.position.y, 
            -10);
        transform.position = newPosition;
    }
}
