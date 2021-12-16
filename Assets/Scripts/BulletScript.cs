using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private GameManager gameManager;

    public float speed;
    private float mod;
    public bool isPlayerBullet;

    
    //private EnemyFormation enemyFormation;

    
    void Start()
    {
        
        //enemyFormation = GameObject.Find("EnemyFormation").GetComponent<EnemyFormation>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        if (isPlayerBullet)
        {
            mod = 1;
        }
        else
        {
            mod = -1;
        }
    }

    
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime * mod, 0);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            gameManager.IncreaseScore(collision.gameObject.GetComponent<EnemyScript>().scoreValue);
            
            //enemyFormation.PlayEnemyDeathAudio();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            gameManager.RestartGame();
        }
        Destroy(gameObject);
    }
}
