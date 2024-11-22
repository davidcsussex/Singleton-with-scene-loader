using UnityEngine;

public class FrontendScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioManager.instance.StopClip();
        AudioManager.instance.PlayClip(0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
