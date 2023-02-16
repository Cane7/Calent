using UnityEngine;

public class Quit : MonoBehaviour
{
    public void ButtonQuit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}