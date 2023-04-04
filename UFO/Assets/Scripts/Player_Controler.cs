using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controler : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    public float speed;
    int Score;
    public Text scoreText;
    public Text winText;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        Score = 1;
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rigidbody2D.AddForce(movement*speed);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pickup"))
        {
            Destroy(collision.gameObject);
            Score++;
            UpdateScore();
        }
    }

    void UpdateScore()
    {
        scoreText.text = $"Score: {Score.ToString()}";
        if (true)
        {
            Score++;
        }

        if(Score > 5)
            winText.text = "Wygra³eœ!";
        //winText.gameObject.setActivve(true);
    }
}
