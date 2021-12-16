using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScript : MonoBehaviour
{
    public float speed = .05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = speed * Time.deltaTime;
        transform.Translate(0, xMove, 0);
    }
}
