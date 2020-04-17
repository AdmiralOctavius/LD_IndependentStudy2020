using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinHolder : MonoBehaviour
{

    public int coinCount = 0;
    public AudioSource playerAudio;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoin()
    {
        coinCount++;
        playerAudio.PlayOneShot(clip);
    }
}
