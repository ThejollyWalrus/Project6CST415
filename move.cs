using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody rb;
    private float moveSpeed;
    private float dirX, dirZ;
    public bool hit = false;
    public float delay = 155;
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public bool camSwap = true;

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
        if (Input.GetKeyDown("m"))
        {
            //   camSwap = !camSwap;
            // cam1.gameObject.SetActive(camSwap);
            //cam2.gameObject.SetActive(!camSwap);
            cam1.gameObject.SetActive(true);
            cam2.gameObject.SetActive(false);
            cam3.gameObject.SetActive(false);
        }

        else if (Input.GetKeyDown("n"))
        {
            cam1.gameObject.SetActive(false);
            cam2.gameObject.SetActive(true);
            cam3.gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown("b"))
        {
            cam1.gameObject.SetActive(false);
            cam2.gameObject.SetActive(false);
            cam3.gameObject.SetActive(true);

        }

        dirZ = Input.GetAxis("Horizontal") * moveSpeed;
        // dirX = Input.GetAxis("Vertical") * moveSpeed;
        if (hit == true)
        {
            if (delay > 0)
            {
                dirX = 3.0f;
                delay = delay - 1;
                return;
            }
            hit = false;
            delay = 155;
        }
        dirX = moveSpeed;
    }

    IEnumerator Wait(float duration)
    {
        //This is a coroutine
        //Debug.Log("Start Wait() function. The time is: " + Time.time);
        //Debug.Log("Float duration = " + duration);
        yield return new WaitForSeconds(duration);   //Wait
        //Debug.Log("End Wait() function and the time is: " + Time.time);
    }


    private void FixedUpdate()
    {
        //moveDirection = transform.Transformdirection(Vector3.forward) * moveSpeed;
       //rb.velocity = new Vector3(0, 0, moveDirection);
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);

    }

    void OnTriggerEnter(Collider blocker)
    {
        if (blocker.CompareTag("box"))
        {
            Destroy(blocker.gameObject);
            hit = true;
        }
        else if (blocker.CompareTag("whale"))
        {
            hit = true;
        }
    }




}


