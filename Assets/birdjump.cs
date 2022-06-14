using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class birdjump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumppower;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumppower;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (score.Score > score.BestScore)
        {
            score.BestScore = score.Score;
        }
        
        SceneManager.LoadScene("gameoverscene");

    }
}
