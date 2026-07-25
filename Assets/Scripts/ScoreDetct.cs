using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDetct : MonoBehaviour
{
   private Bird bird;
    // Start is called before the first frame update
    void Start()
    {
      bird = GameObject.Find("bird").GetComponent<Bird>();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D other)
    {
      
        if (other.gameObject.tag=="player")
        {
            bird.UpdateScore();
        }
        
    }
}
