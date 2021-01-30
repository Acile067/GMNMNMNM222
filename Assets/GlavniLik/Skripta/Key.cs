using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public SceneSwitch scenaSwitch;
    private bool isFollowing;

    public float followSpeed;

    public Transform followTarget;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isFollowing)
        {
            transform.position = Vector3.Lerp(transform.position, followTarget.position, followSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player")
        {
            scenaSwitch.unlocked = true;
            if (!isFollowing)
            {
                PlayerGo thePlayer = FindObjectOfType<PlayerGo>();

                followTarget = thePlayer.keyFollowPoint;
                isFollowing = true;
                thePlayer.followingKey = this;
            }
        }
    }
}
