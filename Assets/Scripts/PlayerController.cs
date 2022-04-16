using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Hoehe des Spielers zum Springen
    public float height;
    public float gravityChange;
    private Rigidbody2D rb;
    public bool isOnGround;
    public bool isGameOver;

    public GameObject panel;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Spieler schneller runter ja?
        Physics.gravity *= gravityChange;
        isOnGround = true;
        isGameOver = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            //Impulse -> Schnell hoch uund langsam runter
            rb.AddForce(Vector2.up * height, ForceMode2D.Impulse);
            isOnGround = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            isGameOver = true;
            Time.timeScale = 0;
            panel.SetActive(true);
        }
    }
}
