using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    public Text scoreText;
    float score ;
    private Rigidbody2D rb;
    public float jumpforce;
    private new AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began || Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x,jumpforce);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "pipe")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void UpdateScore()
    {
        score ++;
        scoreText.text = score.ToString();
        audio.Play();
    }
    

}
