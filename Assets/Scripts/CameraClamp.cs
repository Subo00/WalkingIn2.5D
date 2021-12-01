using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{
    [SerializeField] private Transform TargetToFollow;
    [SerializeField] private float minX, maxX;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(TargetToFollow.position.x, minX, maxX), 
                                        transform.position.y,
                                        transform.position.z);
    }
}
