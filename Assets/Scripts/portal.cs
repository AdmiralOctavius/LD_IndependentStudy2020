using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{

    public GameObject teleportEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("got here");
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Player")
        {
            
            collision.gameObject.transform.position = teleportEnd.gameObject.transform.position;
        }
    }
}
