using UnityEngine;

public class Level1Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioManager.instance.StopClip();
        AudioManager.instance.PlayClip(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
