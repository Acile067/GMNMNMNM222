using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string nivo;
    
    public bool loadLevel;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (loadLevel)
        {
            SceneManager.LoadScene(nivo); 
        }
    }
}
