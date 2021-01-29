using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverTrigger : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    public AudioSource rattleSource;

    private void Start() {
        rattleSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            rattleSource.Play();
            myAnimationController.SetBool("isActive", true);
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("isActive", false);
        }

    }
}
