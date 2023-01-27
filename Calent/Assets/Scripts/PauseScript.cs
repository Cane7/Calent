using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{

    public GameObject pauseMenu;
    public bool isPaused = false;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if(isPaused == true)
            {
                ResumeGame();
            }

            if (isPaused == false)
            {
                PauseGame();
            }
        }

    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
    }


}
