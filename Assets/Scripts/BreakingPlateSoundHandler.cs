using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BreakingPlateSoundHandler : MonoBehaviour
{
    [SerializeField]
    AudioClip breakingPlateAudio;
    void Awake()
    {
        this.GetComponent<AudioSource>().clip = breakingPlateAudio;
        this.GetComponent<AudioSource>().Play();
    }

   
}
