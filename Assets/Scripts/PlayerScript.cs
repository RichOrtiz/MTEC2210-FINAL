﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 5;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(xMove, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }



}