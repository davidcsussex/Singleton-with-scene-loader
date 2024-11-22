using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip[] clips;

    public Audio test;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(clips[2], 0.7f); // start soundtrack

        print(test.text);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.1f, 0, 0);

        if( Input.GetKeyDown("a") )
        {
            audioSource.PlayOneShot(clips[0], 0.7f); // play audio clip with volume 0.7
        }
        if (Input.GetKeyDown("s"))
        {
            audioSource.PlayOneShot(clips[1], 0.7f); // play audio clip with volume 0.7
        }


    }
}

