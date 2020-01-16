using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleHead : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("needleHead")){
            Debug.Log("Game over");
            Time.timeScale = 0;
        }
    }
}
