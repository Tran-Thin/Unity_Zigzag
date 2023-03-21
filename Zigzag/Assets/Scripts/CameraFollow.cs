using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform followTarget;
    private Vector3 startingDistance;

    // Start is called before the first frame update
    void Start()
    {
        followTarget = BallController.instance.transform;
        startingDistance = transform.position - followTarget.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        FollowBall();
    }
    private void FollowBall()
    {
        transform.position = new Vector3 (followTarget.position.x + startingDistance.x, startingDistance.y, followTarget.position.z + startingDistance.z);
    }
}
