using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpGirl : MonoBehaviour
{
   
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>() != null && collision.gameObject.tag == "girl")
        {
            gameObject.AddComponent<FixedJoint>();
            gameObject.GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
           
        }
    }
}
