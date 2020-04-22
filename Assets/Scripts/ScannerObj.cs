using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannerObj : MonoBehaviour
{

    public GameObject startPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
       // Debug.Log("Got here, Obj is: " + col.gameObject.name);


        RaycastHit newRay;

        //Docs to source of direction code
        //https://docs.unity3d.com/Manual/DirectionDistanceFromOneObjectToAnother.html
        var heading = col.gameObject.transform.position - startPoint.gameObject.transform.position;
        var distance = heading.magnitude;
        var direction = heading / distance;
        if(Physics.Raycast(startPoint.gameObject.transform.position, direction, out newRay))
        {
           // Debug.Log("Got raycast");
          //  Debug.DrawRay(startPoint.gameObject.transform.position, direction, Color.blue, 10,false);
          //  Debug.Log("Hit obj was: " + newRay.collider.name);
            if(newRay.collider.tag == "Player")
            {
                this.gameObject.GetComponent<AudioSource>().Play();
            }
        }
    }

    void OnTriggerStay(Collider col)
    {
        //Debug.Log("Got here, Obj is: " + col.gameObject.name);


        RaycastHit newRay;

        //Docs to source of direction code
        //https://docs.unity3d.com/Manual/DirectionDistanceFromOneObjectToAnother.html
        var heading = col.gameObject.transform.position - startPoint.gameObject.transform.position;
        var distance = heading.magnitude;
        var direction = heading / distance;
        if (Physics.Raycast(startPoint.gameObject.transform.position, direction, out newRay))
        {
            //Debug.Log("Got raycast");
           // Debug.DrawRay(startPoint.gameObject.transform.position, direction, Color.blue, 10, false);
            //Debug.Log("Hit obj was: " + newRay.collider.name);
            if (newRay.collider.tag == "Player")
            {
                if(this.GetComponent<AudioSource>().isPlaying ==false)
                    this.gameObject.GetComponent<AudioSource>().Play();
            }
        }
    }
}
