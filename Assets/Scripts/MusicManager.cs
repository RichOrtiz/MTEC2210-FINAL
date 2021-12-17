using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager musicManager;

    // Update is called once per frame
    void Awake()
    {
        DontDestroyOnLoad(this);
        if(musicManager == null)
        {
            musicManager = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
