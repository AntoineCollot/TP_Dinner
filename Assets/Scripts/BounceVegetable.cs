using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceVegetable : MonoBehaviour
{
    Animator anim;
    [Range(0, 10)] public float bounceForce = 5;
    [Range(0, 1)] public float bounceUpward = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
