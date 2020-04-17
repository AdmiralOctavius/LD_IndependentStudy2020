using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cratePickup : MonoBehaviour
{

    public GameObject camera;
    public GameObject crateHolder;
    public GameObject crate;
    public bool crateHeld;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (crateHeld)
        {
            //create check here to have object he held higher above head if camera angle is -20x
            crate.transform.position = crateHolder.transform.position;

        }

        if (Input.GetButtonDown("Interact"))
        {
            if (!crateHeld)
            {
                RaycastHit newRay;
                Debug.Log("Button pressed");

                if (Physics.Raycast(camera.transform.position, camera.transform.forward, out newRay, 20f))
                {
                    Debug.Log("Got raycast");
                    Debug.DrawRay(camera.gameObject.transform.position, 100 * camera.transform.forward, Color.red, 10, false);
                    Debug.Log("Hit obj was: " + newRay.collider.name);

                    if (newRay.collider.gameObject.tag == "Crate")
                    {
                        crate = newRay.collider.gameObject;
                        crate.GetComponent<Rigidbody>().useGravity = false;
                        crateHeld = true;
                        crate.GetComponent<Rigidbody>().freezeRotation = true;
                    }
                }
            }
            else
            {
                crateHeld = false;
                crate.GetComponent<Rigidbody>().useGravity = true;
                crate.GetComponent<Rigidbody>().freezeRotation = false;
                crate = null;
            }
        }
    }


}
