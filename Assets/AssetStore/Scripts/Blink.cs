using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public float    blinkOnTime = 1.0f;
    public float    blinkOffTime = 1.0f;

    TextMeshProUGUI     renderer;
    float               timeElapsed;

	void Start ()
    {
        renderer = GetComponent<TextMeshProUGUI>();
        renderer.enabled = true;

        timeElapsed = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        timeElapsed += Time.deltaTime;

	    if (renderer.enabled)
        {
            if (timeElapsed > blinkOnTime)
            {
                timeElapsed = 0.0f;
                renderer.enabled = false;
            }
        }	
        else
        {
            if (timeElapsed > blinkOffTime)
            {
                timeElapsed = 0.0f;
                renderer.enabled = true;
            }
        }
    }
}
