using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwordForce = 1000f;
    public float sideForce = 100f;
    public GameManager gameManager;
    public bool endGame;
    public Text scoreText;
    public float score;




    void Update()
    {
        if (!endGame)
        {
            score = (transform.position.z);
            scoreText.text = score.ToString("0");
        }
    }


    void FixedUpdate()
    {

        rb.AddForce(0f, 0f, forwordForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            gameManager.EndGame();
            endGame = true;

        }
    }

}
