using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverTrigger : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    public AudioSource rattleSource;
    public GameObject Vrata1;

    private void Start() {
        rattleSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !myAnimationController.GetBool("isActive"))
        {
            rattleSource.Play();
            myAnimationController.SetBool("isActive", true);
            Destroy(Vrata1);
        }

    }

    
}
