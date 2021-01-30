using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuOptions : MonoBehaviour
{
    public Animator anim;
    public void PlayGame()
    {
        anim.Play("TranStart");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
