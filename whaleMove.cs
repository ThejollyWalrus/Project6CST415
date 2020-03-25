using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whaleMove : MonoBehaviour
{
    private Rigidbody rb;
    private float moveSpeed;
    private float dirX, dirZ;
    // Start is called before the first frame update
    private void Start()
    {
        moveSpeed = 6f;
        //fwdSpeed = 6f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


        dirZ = Input.GetAxis("Horizontal") * moveSpeed;
        // dirX = Input.GetAxis("Vertical") * moveSpeed;
        
        dirX = moveSpeed;
    }

  

    private void FixedUpdate()
    {
        //moveDirection = transform.Transformdirection(Vector3.forward) * moveSpeed;
        //rb.velocity = new Vector3(0, 0, moveDirection);
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);

    }

   


}


