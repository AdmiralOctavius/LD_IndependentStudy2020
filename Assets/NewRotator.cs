using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//https://answers.unity.com/questions/1126169/how-to-rotate-object-back-and-forth-from-one-rotat.html
//Source on this code
public class NewRotator : MonoBehaviour
{
    public float speed = 0.2f;
    public float maxRotation = 90f;
    public float startRotation = 0f;
    void Update()
    {
        transform.rotation = Quaternion.Euler(0f, startRotation + maxRotation * Mathf.Sin(Time.time * speed), 0f);
    }
}
