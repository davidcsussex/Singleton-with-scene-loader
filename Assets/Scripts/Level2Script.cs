using UnityEngine;

public class Level2Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioManager.instance.StopClip();
        AudioManager.instance.PlayClip(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
