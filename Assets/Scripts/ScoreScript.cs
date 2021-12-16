using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip deathClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayEnemyDeathAudio()
    {
        audioSource.PlayOneShot(deathClip);
    }
}
