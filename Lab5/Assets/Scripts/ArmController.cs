using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmController : MonoBehaviour {
    private Animator animator;
    // Start is called before the first frame update
    void Start() {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            animator.SetBool("ShouldThrowBall",true);
        }
    }

    
    void ReleaseBall()
    {   
        BallController ball = GetComponentInChildren<BallController>();
        if (ball != null)
        {
            ball.transform.parent = null;
            ball.LaunchMe();
        };
    }
}
