using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public bool unlocked = false;
    private void OnTriggerEnter2D(Collider2D other) {
        
        if(unlocked)
        SceneManager.LoadScene(2);
    }
}
