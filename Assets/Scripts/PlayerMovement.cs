using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 50;
    public float maxSpeed = 20;
    public float upSpeed = 40;
    private bool onGroundState = true;
    private Rigidbody2D marioBody;
    private SpriteRenderer marioSprite;
    public GameObject enemies;
    public BoxCollider2D marioCollider;
    public Sprite deathSprite;
    public Sprite normalSprite;
    private bool dead = false;

    // state
    [System.NonSerialized]
    public bool alive = true;
    private bool moving = false;
    private bool jumpedState = false;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
        marioBody = GetComponent<Rigidbody2D>();
        marioSprite = GetComponent<SpriteRenderer>();
        marioCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if ((col.gameObject.CompareTag("Ground") || col.gameObject.CompareTag("Enemy") || col.gameObject.CompareTag("Obstacles")) && !onGroundState)
        {
            onGroundState = true;
        }
    }
    // FixedUpdate is called 50 times a second
    void FixedUpdate()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy") && alive)
        {
            Debug.Log("Collided with goomba!");
            alive = false;
        }
    }
    public void Jump()
    {
        if (alive && onGroundState)
        {
            // jump
            marioBody.AddForce(Vector2.up * upSpeed, ForceMode2D.Impulse);
            onGroundState = false;
            jumpedState = true;
        }
    }

    private void ResetGame()
    {
        // reset position
        marioBody.transform.position = new Vector3(-5.33f, -4.69f, 0.0f);
        // reset sprite direction
        dead = false;
        alive = true;
    }
}
//Events: Level restart, score change, death, powerup stuff, 
//FSM: Alive running, alive jumping, dead, powerup1, powerup2
