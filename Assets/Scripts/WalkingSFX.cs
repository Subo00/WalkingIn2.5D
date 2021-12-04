using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingSFX : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
    }
}
