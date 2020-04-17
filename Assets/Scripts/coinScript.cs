using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{

    public  float CoinRotateSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.gameObject.transform.rotation.SetEulerAngles(this.gameObject.transform.eulerAngles.x, this.gameObject.transform.eulerAngles.y, this.gameObject.transform.eulerAngles.z + CoinRotateSpeed);
        Quaternion rotation = Quaternion.Euler(this.gameObject.transform.eulerAngles.x, this.gameObject.transform.eulerAngles.y, this.gameObject.transform.eulerAngles.z + CoinRotateSpeed);
        this.gameObject.transform.rotation = rotation;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<coinHolder>().AddCoin();  
            Destroy(gameObject);
        }
    }
}
