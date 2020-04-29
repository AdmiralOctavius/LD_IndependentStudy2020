using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoadScript : MonoBehaviour
{

    public string nextLevel;
    public Image overlayImage;
    public float currentBlackAlphaState;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider Col)
    {

        //SceneManager.LoadScene(nextLevel);
        StartCoroutine("Fade");
    }


    IEnumerator Fade()
    {
        for (float ft = 0f; ft <= 1.1; ft += 0.1f)
        {
            overlayImage.color = new Color(overlayImage.color.r, overlayImage.color.g, overlayImage.color.b, ft);
            //Color c = renderer.material.color;
            //c.a = ft;
            //renderer.material.color = c;
            currentBlackAlphaState = ft;
            yield return new WaitForSeconds(.1f);
        }
        SceneManager.LoadScene(nextLevel);
    }
}
