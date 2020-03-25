using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraCloseScript : MonoBehaviour
{

    GameObject playerObj;
    Vector3 cameraOffSet;

    // Use this for initialization
    void Start()
    {
        playerObj = GameObject.Find("Player");
        cameraOffSet = new Vector3(15, 5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerObj.transform.position + cameraOffSet;
    }
}

