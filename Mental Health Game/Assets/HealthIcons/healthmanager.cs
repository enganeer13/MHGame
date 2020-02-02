using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthmanager : MonoBehaviour
{
    
    public GameObject rose;
    public GameObject enemy;

    public double playerHealth = 1.0;
    public Sprite rose4;
    public Sprite rose3;
    public Sprite rose2;
    public Sprite rose1;
    public Sprite rose0;
    SpriteRenderer playerRenderer;

    public double enemyHealth = 1.0;
    public Sprite enemy4;
    public Sprite enemy3;
    public Sprite enemy2;
    public Sprite enemy1;
    public Sprite enemy0;
    SpriteRenderer enemyRenderer;

    void Start()
    {
        
        playerRenderer = rose.GetComponent(typeof(SpriteRenderer)) as SpriteRenderer;
        enemyRenderer = enemy.GetComponent(typeof(SpriteRenderer)) as SpriteRenderer;
    }

    void Update()
    {
        //Enemy Health
        if(enemyHealth >= 1.0){
            enemyRenderer.sprite = enemy4;
        }
        else if(enemyHealth >= 0.75){
            enemyRenderer.sprite = enemy3;
        }
        else if(enemyHealth >= 0.5){
            enemyRenderer.sprite = enemy2;
        }
        else if(enemyHealth >= 0.25){
            enemyRenderer.sprite = enemy1;
        }
        else{
            enemyRenderer.sprite = enemy0;
            //win
        }


        //Player Health
        if(playerHealth >= 1.0){
            playerRenderer.sprite = rose4;
        }
        else if(playerHealth >= 0.75){
            playerRenderer.sprite = rose3;
        }
        else if(playerHealth >= 0.5){
            playerRenderer.sprite = rose2;
        }
        else if(playerHealth >= 0.25){
            playerRenderer.sprite = rose1;
        }
        else{
            playerRenderer.sprite = rose0;
            //ded
        }
    }
    
}
