using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadFrontend()
    {
        LevelManager.lm.LoadScene("Frontend");
    }

    public void LoadLevel1()
    {
        LevelManager.lm.LoadScene("Level 1");
    }

    public void LoadLevel2()
    {
        LevelManager.lm.LoadScene("Level 2");
    }


}
