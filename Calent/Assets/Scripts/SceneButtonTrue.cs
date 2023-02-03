using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButtonTrue : MonoBehaviour
{
    public GameObject panelToLoad;

    public void ButtonClick()
    {
        panelToLoad.SetActive(true);
    }

}
