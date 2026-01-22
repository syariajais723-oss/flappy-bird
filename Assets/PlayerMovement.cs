using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;          // Rigidbody player
    public float jumpForce;  // besar loncatan
    public int score = 0;    // skor pemain

    public Text scoreTxt;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // ambil komponen Rigidbody2D
    }

    void Update()
    {
        scoreTxt.text = "" + score;


        if (Input.GetMouseButtonDown(0))  // klik kiri / tap layar
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("poin"))
        {
            score++;
            Debug.Log("Score: " + score);
        }

        if(collision.gameObject.tag =="pipa")
        {
            Destroy(gameObject);
        }

    }
}
