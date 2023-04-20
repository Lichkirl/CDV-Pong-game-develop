using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    [SerializeField]private float speed = 5f;
    public KeyCode upKey;
    public KeyCode downKey;
    public Color playerColor;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = playerColor;
        
        Debug.Log("Hey");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(upKey) && transform.position.y < 5)
        {
            rb.velocity = Vector2.up * speed;
        }
        else if(Input.GetKey(downKey) && transform.position.y > -5)
        {
            rb.velocity = Vector2.down * speed;
        }
        else { rb.velocity = Vector2.zero; }    
        
        Debug.Log("Update");
    }
}
