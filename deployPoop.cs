using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class deployPoop : MonoBehaviour
{
    public GameObject poopPrefab;
    public float respawnTime = 1.0f;
    public GameObject Playerr;
    public int distance = 2;
    public Transform log;
    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
      //  spawnPoop();
    }

    private void spawnPoop()
    {
       // GameObject a = Instantiate(poopPrefab) as GameObject;
        Instantiate(log, transform.position, transform.rotation);
    }
    

    void OnTriggerEnter(Collider blocker)
    {
        if (blocker.CompareTag("box"))
        {
            count += 1;
            for (int i = count; i > 0; i--)
            {
                spawnPoop();
            }
        }
    }
        // Up
   }
