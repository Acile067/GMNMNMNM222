using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class SvetloTreperi : MonoBehaviour
{
    public Light2D svetlo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        svetlo.pointLightOuterRadius = Mathf.Lerp(1.5f, 2f, Mathf.PingPong(Time.time * 2, 1));
    }
}
