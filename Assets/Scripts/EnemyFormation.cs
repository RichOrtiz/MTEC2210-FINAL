using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFormation : MonoBehaviour
{
    public bool movingDown;
    public bool movingSide;
    public Vector3 destination;
    public float speed = .5f;
    private float descendSpeed = 1;
    public GameObject bulletPrefab;
    private float timeTillFire;
    public float fireDelay = 0;

    private GameManager gameManager;
    //public AudioSource audioSource;
    //public AudioClip deathClip;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        movingSide = true;
        timeTillFire = fireDelay;
        //destination = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
    }


    void Update()
    {
        if (movingSide)
        {
            MoveHorizontal();
        }
        if (movingDown)
        {
            MoveDown();
        }
        
        if (timeTillFire > 0)
        {
            timeTillFire -= Time.deltaTime;
        }
        else
        {
            EnemyShoot();
            timeTillFire = fireDelay;
        }
    }
    /*public void PlayEnemyDeathAudio()
    {
        audioSource.PlayOneShot(deathClip);
    }*/
    public void EnemyShoot()
    {
        int numberofEnemies = GetComponentsInChildren<EnemyScript>().Length;
        if (numberofEnemies <= 0)
        {
            gameManager.Win();
            return;
        }
        int index = Random.Range(0, numberofEnemies);
        var enemyArray = GetComponentsInChildren<EnemyScript>();
        Vector3 bullPos = enemyArray[index].transform.position;
        Instantiate(bulletPrefab, bullPos, Quaternion.identity);
    }

    public void SetDestinationAndMoveDown()
    {
        destination = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
        movingDown = true;
    }
    public void MoveDown()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, Time.deltaTime * descendSpeed);
        if(transform.position == destination)
        {
            movingDown = false;
            speed *= -1;
            movingSide = true;
        }
    }
    public void MoveHorizontal()
    {
        transform.Translate(speed * Time.deltaTime,0,0);
    }
}
