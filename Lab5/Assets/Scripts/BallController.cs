using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BallController : MonoBehaviour
{
    
    public GameObject bowlingPin;
    public void Start()
    {
        
    }

    public void LaunchMe()
    {   
        // TO DO 
        // Write code to launch ball
    }

    public Vector3 GetLaunchDirection()
    {
        return bowlingPin.transform.position - transform.position;
    }
}
