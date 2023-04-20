using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{

    public Rigidbody2D rb2d;
    public float speed = 1f;
    public Vector2 vel;
    public Color pColorL;
    public Color pColorR;   
    public int scoreP1 = 0;
    public int scoreP2 = 0;
    public TextMeshProUGUI scoreLeft;
    public TextMeshProUGUI scoreRight;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        scoreLeft.text = scoreP1.ToString();
        scoreRight.text = scoreP2.ToString();
        ResetBall();
        ReDirectBall();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && rb2d.velocity.magnitude < 0.1f)
        {
            ReDirectBall();
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb2d.velocity = Vector2.Reflect(vel, collision.contacts[0].normal);
        vel = rb2d.velocity;
        if (collision.transform.tag == "Player")
        {
            speed += 0.5f;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.position.x < 0)
        {
            scoreP1 += 1;
            scoreLeft.text = scoreP1.ToString();

        }
        if (transform.position.x > 0)
        {
            scoreP2 += 1;
            scoreRight.text = scoreP2.ToString();
        }
        
        
        ResetBall();
        
        
    }
    private void ReDirectBall()
    {
        rb2d.velocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized * speed;
        vel = rb2d.velocity;
    }
    void ResetBall()
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }
}
