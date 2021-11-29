using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{
    [SerializeField] private Transform TargetToFollow;
    [SerializeField] private float minX, maxX;
    [SerializeField] private float minY, maxY;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(TargetToFollow.position.x, minX, maxX), 
                                        Mathf.Clamp(TargetToFollow.position.y, minY, maxY),
                                        transform.position.z);
    }
}
