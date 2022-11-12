using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClickEvent : MonoBehaviour
{
    public int SceneIndex;

    public void ButtonClick()
    {
        SceneManager.LoadScene(SceneIndex);
    }

}
