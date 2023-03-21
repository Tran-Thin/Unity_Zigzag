using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    bool hasBeenTouched;
    private Rigidbody myRb;
    private Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hasBeenTouched  && myRb.isKinematic)
        {
            if(Vector3.Distance(transform.position, myTransform.position) > 2.25f)
            {
                myRb.isKinematic = false;
            }
            if(transform.position.y < -5f)
            {
                Destroy(this.gameObject);
            }
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            myTransform = collision.transform;
            if (!hasBeenTouched)
            {
                PlatformGenerator.instance.NextPlatform();
                hasBeenTouched = true;
            }
        }
        
    }
}
