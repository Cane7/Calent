using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Photon.Pun;
using UnityEngine;


public class Pause : MonoBehaviour
{
        public static bool paused = false;
        private bool disconnecting = false;

    public void TogglePause()
    {
        if (disconnecting) return;

        if (paused == false)
        {
            paused = true;
        } else if(paused == true)
        {
            paused = false;
        }

            transform.GetChild(0).gameObject.SetActive(paused);
            Cursor.lockState = (paused) ? CursorLockMode.None : CursorLockMode.Confined;
            Cursor.visible = paused;
        }

        public void Quit()
        {
            disconnecting = true;
            PhotonNetwork.LeaveRoom();
            SceneManager.LoadScene("Menu");
        }
    
}