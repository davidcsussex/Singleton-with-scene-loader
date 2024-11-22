using UnityEngine;

[CreateAssetMenu(fileName = "Audio", menuName = "Scriptable Objects/Audio")]
public class Audio : ScriptableObject
{
    public AudioClip[] clips;
    public string text = "hello";

}
