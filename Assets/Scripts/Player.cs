using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public float jumpSpeed = 1f;
    private Rigidbody rb;
    public GameObject gamelose;

    void Start()
    {
        
        gamelose.SetActive(false);
        rb = GetComponent<Rigidbody>();
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisAnimation.Play();
            rb.velocity = Vector2.up * jumpSpeed;
        }
        if (transform.position.y <= -4.46)
        {
            gamelose.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Obstacle"))
        {
            gamelose.SetActive(true);
            Time.timeScale = 0;
        }
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("ScoreCollider"))
        {
            GameManager.thisManager.UpdateScore();
        }
    }
}
