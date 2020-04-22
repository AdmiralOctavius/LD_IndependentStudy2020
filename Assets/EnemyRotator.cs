using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotator : MonoBehaviour
{
    public float rot1;
    public float rot2;

    public bool rotated = false;

    public float speed = 1.0f;

    private float startTime;
    private float journeyLength;

    // Start is called before the first frame update
    void Start()
    {

        startTime = Time.time;
        journeyLength = this.transform.rotation.y - rot1;
        Debug.Log(journeyLength);
        //StartCoroutine("rotateTo1");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //READ THIS IN MORNING
        //https://answers.unity.com/questions/1204245/rotating-smoothly-between-two-angles-mathematical.html
        Vector3 to = new Vector3(0, rot1, 0);
        if (this.gameObject.transform.rotation.y <= rot1)
        {

        }
        if(this.gameObject.transform.rotation.y >= rot1)
        {
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, 0.1f);
        }
        else if (this.gameObject.transform.rotation.y != rot1)
        {

            float distCovered = (Time.time - startTime) * speed;
            float fractionOfJourney = distCovered / journeyLength;
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, fractionOfJourney);
        }
    }

    IEnumerator rotateTo1()
    {
        int i = 10;
        Vector3 to = new Vector3(0, rot1, 0);

        

        while(this.gameObject.transform.rotation.y <= rot1)
        {
            i++;
            if(i >= 10)
            {
                yield return new WaitForSeconds(.1f);
            }
            float distCovered = (Time.time - startTime) * speed;
            float fractionOfJourney = distCovered / journeyLength;
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, fractionOfJourney);
        }
        //Should end it
        yield return null;
    }
}
