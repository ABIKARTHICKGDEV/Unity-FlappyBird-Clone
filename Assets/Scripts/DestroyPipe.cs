using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPipe : MonoBehaviour
{
    public float destroyXPosition ; // X position at which the pipe will be destroyed

    void Update() {
        // Check if the pipe has moved past the destroy position
        if (transform.position.x <= destroyXPosition) {
            Destroy(gameObject); // Destroy the pipe
        }
    }
}
