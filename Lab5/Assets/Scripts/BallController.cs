using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BallController : MonoBehaviour
{
    
    public GameObject bowlingPin;
    public Rigidbody rb;
    public float strength = 10f;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void LaunchMe()
    {   
        // TO DO 
        // Write code to launch ball
        rb.isKinematic = false;
        rb.AddForce(GetLaunchDirection()*strength,ForceMode.Impulse);
    }

    public Vector3 GetLaunchDirection()
    {
        return bowlingPin.transform.position - transform.position;
    }
}
