using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private SpriteRenderer sp;
    private Vector2 sas;
    private Collider2D col;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 sus = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        sas = sus.normalized * speed;
    }

    void FixedUpdate() 
    {
        if (Input.GetAxisRaw("Horizontal") > 0) 
        {
            sp.flipX = false;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            sp.flipX = true;
        }
        rb.MovePosition(rb.position + sas * Time.fixedDeltaTime);
    }
}
