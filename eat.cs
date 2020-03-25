using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eat : MonoBehaviour
{
    public Camera lostCamera;
    public Camera followCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider eater)
    {
        if (eater.CompareTag("dude"))
        {
            Destroy(eater.gameObject);
            followCamera.enabled = false;
            lostCamera.enabled = true;
        }
    }

}
