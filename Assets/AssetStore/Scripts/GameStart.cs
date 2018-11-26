using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{

	void Update ()
    {
	    if (Input.GetButtonUp("Fire1"))
        {
            SceneManager.LoadScene(1);
        }	
	}
}
