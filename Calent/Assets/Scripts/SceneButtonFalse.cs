using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButtonFalse : MonoBehaviour
{
    public GameObject panelToUnload;

    public void ButtonClick()
    {
        panelToUnload.SetActive(false);
    }

}
