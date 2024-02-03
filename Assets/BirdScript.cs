using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapstrength;
    public float birdSpeed = 3;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioSource jump;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& birdIsAlive)
        {
            jump.Play(0);
            myRigidbody.velocity = Vector2.up * birdSpeed;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
        logic.gameOver();

    }
}
