using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public static BallController instance;
    Rigidbody myRB;
    public bool isStarted;
    public bool isGoingRight;
    bool isAlive = true;
    public float currentSpeed;
    
    private void OnEnable()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
     myRB = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        if( isStarted && isAlive)
        {
            MoveBall();
        }
    }
    private void MoveBall()
    {
        if (isGoingRight)
        {
            myRB.velocity = (Vector3.right * currentSpeed) + Physics.gravity;
        }
        else
        {
            myRB.velocity = (Vector3.forward * currentSpeed) + Physics.gravity;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "DeathZone")
        {
            isAlive = false;
            myRB.velocity = Physics.gravity;
            MenuController.instance.GameOver();
        }
    }
}
