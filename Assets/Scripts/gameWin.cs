using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameWin : MonoBehaviour
{

    public GameObject winUI;
    public MouseLook mouseLook;
    public PauseMenu pauseMenu;


    private void OnTriggerEnter(Collider other)
    {


        // only if you enter the "exit" object this activates 
        if (other.gameObject.name == "exit")
        {
            Time.timeScale = 0;
            mouseLook.enabled = false;
            pauseMenu.enabled = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            winUI.SetActive(true);
        }

    }
    public void LoadLevel(string name)
    {
        Time.timeScale = 1;
        mouseLook.enabled = true;
        pauseMenu.enabled = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.LoadScene(name);
    }

    public void Quit()
    {
        Application.Quit();
        print("you quit the game");

    }

}