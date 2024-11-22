using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.1f, 0, 0);

        if( Input.GetKeyDown("a") )
        {
            AudioManager.instance.PlayClip(4);
        }
        if (Input.GetKeyDown("d"))
        {
            AudioManager.instance.PlayClip(5);
        }


    }
}

